using System.Security.Cryptography;

namespace AESTool;

internal partial class MainForm : Form
{
    private readonly Aes _aes;

    internal MainForm()
    {
        InitializeComponent();

        // Initialize _aes
        _aes = Aes.Create();

        // Set default selections for the list boxes
        listBoxCipherMode.SelectedIndex = 0;
        listBoxEncoding.SelectedIndex = 1;
        listBoxKeySize.SelectedIndex = 2;
        listBoxPaddingMode.SelectedIndex = 3;
    }

    // Enum for specifying the encoding mode for the input, secret key, and IV
    private enum Encoding { Hexadecimal, Base64 }
    private Encoding _encoding;

    // Method to convert byte array to a string encoded however the user has specified (hex or base64)
    private string BytesToEncodedString(byte[] bytes)
    {
        return _encoding switch
        {
            Encoding.Hexadecimal => Convert.ToHexString(bytes),
            Encoding.Base64 => Convert.ToBase64String(bytes),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    // Method to convert hex or base64 string to byte array
    private byte[] EncodedStringToBytes(string chars)
    {
        return _encoding switch
        {
            Encoding.Hexadecimal => Convert.FromHexString(chars),
            Encoding.Base64 => Convert.FromBase64String(chars),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    // Set encoding mode
    private void listBoxEncoding_SelectedIndexChanged(object sender, EventArgs e)
    {
        _encoding = ((ListBox)sender).SelectedItem!.ToString() switch
        {
            "Hexadecimal" => Encoding.Hexadecimal,
            "Base64" => Encoding.Base64,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    // Set cipher mode
    private void listBoxCipherMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        _aes.Mode = ((ListBox)sender).SelectedItem!.ToString() switch
        {
            "CBC" => CipherMode.CBC,
            "ECB" => CipherMode.ECB,
            "CFB" => CipherMode.CFB,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    // Set padding mode
    private void listBoxPaddingMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        _aes.Padding = ((ListBox)sender).SelectedItem!.ToString() switch
        {
            "None" => PaddingMode.None,
            "PKCS7" => PaddingMode.PKCS7,
            "Zeros" => PaddingMode.Zeros,
            "ANSIX923" => PaddingMode.ANSIX923,
            "ISO10126" => PaddingMode.ISO10126,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    // Set key size
    private void listBoxKeySize_SelectedIndexChanged(object sender, EventArgs e) => _aes.KeySize = int.Parse(((ListBox)sender).SelectedItem!.ToString()!);

    // Generate secret key
    private void buttonGenerateSecretKey_Click(object sender, EventArgs e)
    {
        _aes.GenerateKey();
        textBoxSecretKey.Text = BytesToEncodedString(_aes.Key);
    }

    // Generate IV
    private void buttonGenerateIV_Click(object sender, EventArgs e)
    {
        _aes.GenerateIV();
        textBoxIV.Text = BytesToEncodedString(_aes.IV);
    }

    // Validate user input
    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(textBoxSecretKey.Text))
        {
            MessageBox.Show("Please set a secret key or generate one.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (string.IsNullOrWhiteSpace(textBoxIV.Text))
        {
            MessageBox.Show("Please set an IV or generate one.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        try
        {
            _aes.Key = EncodedStringToBytes(textBoxSecretKey.Text);
            _aes.IV = EncodedStringToBytes(textBoxIV.Text);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return true;
    }

    private void buttonEncrypt_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            return;
        }

        using var memoryStream = new MemoryStream();
        using (var cryptoStream = new CryptoStream(memoryStream, _aes.CreateEncryptor(), CryptoStreamMode.Write))
        {
            var plainBytes = System.Text.Encoding.ASCII.GetBytes(textBoxText.Text);
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
            cryptoStream.FlushFinalBlock();
        }

        textBoxTextResult.Text = BytesToEncodedString(memoryStream.ToArray());
    }

    private void buttonDecrypt_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            return;
        }

        // This try-catch is essential for appropiately responding to most exceptions that could occur
        // Invalid input, invalid key, invalid iv, etc.
        try
        {
            using var memoryStream = new MemoryStream();
            using (var cryptoStream = new CryptoStream(memoryStream, _aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                var plainBytes = EncodedStringToBytes(textBoxText.Text);
                cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                cryptoStream.FlushFinalBlock();
            }

            textBoxTextResult.Text = System.Text.Encoding.ASCII.GetString(memoryStream.ToArray(), 0, memoryStream.ToArray().Length);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}