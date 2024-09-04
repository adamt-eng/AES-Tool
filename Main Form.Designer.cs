namespace AESTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label labelKeySize;
            Label labelPaddingMode;
            Label labelCipherMode;
            Button buttonEncrypt;
            Button buttonDecrypt;
            GroupBox groupBoxSecretKeyOptions;
            Button buttonGenerateSecretKey;
            GroupBox groupBoxEncoding;
            GroupBox groupBoxInput;
            GroupBox groupBoxIVOptions;
            Button buttonGenerateIV;
            GroupBox groupBoxAesOptions;
            GroupBox groupBoxOutput;
            textBoxSecretKey = new TextBox();
            listBoxKeySize = new ListBox();
            listBoxEncoding = new ListBox();
            textBoxText = new TextBox();
            textBoxIV = new TextBox();
            listBoxPaddingMode = new ListBox();
            listBoxCipherMode = new ListBox();
            textBoxTextResult = new TextBox();
            labelKeySize = new Label();
            labelPaddingMode = new Label();
            labelCipherMode = new Label();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            groupBoxSecretKeyOptions = new GroupBox();
            buttonGenerateSecretKey = new Button();
            groupBoxEncoding = new GroupBox();
            groupBoxInput = new GroupBox();
            groupBoxIVOptions = new GroupBox();
            buttonGenerateIV = new Button();
            groupBoxAesOptions = new GroupBox();
            groupBoxOutput = new GroupBox();
            groupBoxSecretKeyOptions.SuspendLayout();
            groupBoxEncoding.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxIVOptions.SuspendLayout();
            groupBoxAesOptions.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // labelKeySize
            // 
            labelKeySize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKeySize.Location = new Point(508, 12);
            labelKeySize.Name = "labelKeySize";
            labelKeySize.Size = new Size(244, 30);
            labelKeySize.TabIndex = 0;
            labelKeySize.Text = "Key Size in Bits:";
            labelKeySize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPaddingMode
            // 
            labelPaddingMode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaddingMode.Location = new Point(6, 26);
            labelPaddingMode.Name = "labelPaddingMode";
            labelPaddingMode.Size = new Size(246, 30);
            labelPaddingMode.TabIndex = 1;
            labelPaddingMode.Text = "Padding Mode:";
            labelPaddingMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCipherMode
            // 
            labelCipherMode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCipherMode.Location = new Point(6, 146);
            labelCipherMode.Name = "labelCipherMode";
            labelCipherMode.Size = new Size(244, 30);
            labelCipherMode.TabIndex = 2;
            labelCipherMode.Text = "Cipher Mode";
            labelCipherMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEncrypt.Location = new Point(12, 431);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(513, 60);
            buttonEncrypt.TabIndex = 3;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDecrypt.Location = new Point(531, 431);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(508, 60);
            buttonDecrypt.TabIndex = 4;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // groupBoxSecretKeyOptions
            // 
            groupBoxSecretKeyOptions.Controls.Add(buttonGenerateSecretKey);
            groupBoxSecretKeyOptions.Controls.Add(textBoxSecretKey);
            groupBoxSecretKeyOptions.Controls.Add(listBoxKeySize);
            groupBoxSecretKeyOptions.Controls.Add(labelKeySize);
            groupBoxSecretKeyOptions.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxSecretKeyOptions.Location = new Point(12, 153);
            groupBoxSecretKeyOptions.Name = "groupBoxSecretKeyOptions";
            groupBoxSecretKeyOptions.Size = new Size(758, 135);
            groupBoxSecretKeyOptions.TabIndex = 5;
            groupBoxSecretKeyOptions.TabStop = false;
            groupBoxSecretKeyOptions.Text = "Secret Key Options";
            // 
            // buttonGenerateSecretKey
            // 
            buttonGenerateSecretKey.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGenerateSecretKey.Location = new Point(6, 78);
            buttonGenerateSecretKey.Name = "buttonGenerateSecretKey";
            buttonGenerateSecretKey.Size = new Size(496, 51);
            buttonGenerateSecretKey.TabIndex = 6;
            buttonGenerateSecretKey.Text = "Generate Secret Key";
            buttonGenerateSecretKey.UseVisualStyleBackColor = true;
            buttonGenerateSecretKey.Click += buttonGenerateSecretKey_Click;
            // 
            // textBoxSecretKey
            // 
            textBoxSecretKey.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSecretKey.Location = new Point(6, 45);
            textBoxSecretKey.Name = "textBoxSecretKey";
            textBoxSecretKey.PlaceholderText = "Enter secret key";
            textBoxSecretKey.Size = new Size(496, 27);
            textBoxSecretKey.TabIndex = 7;
            // 
            // listBoxKeySize
            // 
            listBoxKeySize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxKeySize.FormattingEnabled = true;
            listBoxKeySize.ItemHeight = 20;
            listBoxKeySize.Items.AddRange(new object[] { "128", "192", "256" });
            listBoxKeySize.Location = new Point(508, 45);
            listBoxKeySize.Name = "listBoxKeySize";
            listBoxKeySize.Size = new Size(244, 84);
            listBoxKeySize.TabIndex = 8;
            listBoxKeySize.SelectedIndexChanged += listBoxKeySize_SelectedIndexChanged;
            // 
            // groupBoxEncoding
            // 
            groupBoxEncoding.Controls.Add(listBoxEncoding);
            groupBoxEncoding.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxEncoding.Location = new Point(531, 294);
            groupBoxEncoding.Name = "groupBoxEncoding";
            groupBoxEncoding.Size = new Size(244, 131);
            groupBoxEncoding.TabIndex = 9;
            groupBoxEncoding.TabStop = false;
            groupBoxEncoding.Text = "Input/Key/IV Encoding";
            // 
            // listBoxEncoding
            // 
            listBoxEncoding.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxEncoding.FormattingEnabled = true;
            listBoxEncoding.ItemHeight = 20;
            listBoxEncoding.Items.AddRange(new object[] { "Base64", "Hexadecimal" });
            listBoxEncoding.Location = new Point(6, 26);
            listBoxEncoding.Name = "listBoxEncoding";
            listBoxEncoding.Size = new Size(232, 84);
            listBoxEncoding.TabIndex = 10;
            listBoxEncoding.SelectedIndexChanged += listBoxEncoding_SelectedIndexChanged;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxText);
            groupBoxInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxInput.Location = new Point(12, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(513, 135);
            groupBoxInput.TabIndex = 11;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Input";
            // 
            // textBoxText
            // 
            textBoxText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxText.Location = new Point(6, 26);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.PlaceholderText = "Enter text";
            textBoxText.Size = new Size(501, 103);
            textBoxText.TabIndex = 12;
            // 
            // groupBoxIVOptions
            // 
            groupBoxIVOptions.Controls.Add(buttonGenerateIV);
            groupBoxIVOptions.Controls.Add(textBoxIV);
            groupBoxIVOptions.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxIVOptions.Location = new Point(12, 288);
            groupBoxIVOptions.Name = "groupBoxIVOptions";
            groupBoxIVOptions.Size = new Size(513, 135);
            groupBoxIVOptions.TabIndex = 13;
            groupBoxIVOptions.TabStop = false;
            groupBoxIVOptions.Text = "Initialization Vector (IV) Options";
            // 
            // buttonGenerateIV
            // 
            buttonGenerateIV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGenerateIV.Location = new Point(6, 78);
            buttonGenerateIV.Name = "buttonGenerateIV";
            buttonGenerateIV.Size = new Size(496, 51);
            buttonGenerateIV.TabIndex = 14;
            buttonGenerateIV.Text = "Generate Initialization Vector (IV)";
            buttonGenerateIV.UseVisualStyleBackColor = true;
            buttonGenerateIV.Click += buttonGenerateIV_Click;
            // 
            // textBoxIV
            // 
            textBoxIV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIV.Location = new Point(6, 45);
            textBoxIV.Name = "textBoxIV";
            textBoxIV.PlaceholderText = "Enter initialization vector";
            textBoxIV.Size = new Size(496, 27);
            textBoxIV.TabIndex = 15;
            // 
            // groupBoxAesOptions
            // 
            groupBoxAesOptions.Controls.Add(listBoxPaddingMode);
            groupBoxAesOptions.Controls.Add(labelPaddingMode);
            groupBoxAesOptions.Controls.Add(listBoxCipherMode);
            groupBoxAesOptions.Controls.Add(labelCipherMode);
            groupBoxAesOptions.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxAesOptions.Location = new Point(781, 153);
            groupBoxAesOptions.Name = "groupBoxAesOptions";
            groupBoxAesOptions.Size = new Size(258, 276);
            groupBoxAesOptions.TabIndex = 16;
            groupBoxAesOptions.TabStop = false;
            groupBoxAesOptions.Text = "AES Options";
            // 
            // listBoxPaddingMode
            // 
            listBoxPaddingMode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxPaddingMode.FormattingEnabled = true;
            listBoxPaddingMode.ItemHeight = 20;
            listBoxPaddingMode.Items.AddRange(new object[] { "None", "ANSIX923", "ISO10126", "PKCS7", "Zeros" });
            listBoxPaddingMode.Location = new Point(8, 59);
            listBoxPaddingMode.Name = "listBoxPaddingMode";
            listBoxPaddingMode.Size = new Size(244, 84);
            listBoxPaddingMode.TabIndex = 17;
            listBoxPaddingMode.SelectedIndexChanged += listBoxPaddingMode_SelectedIndexChanged;
            // 
            // listBoxCipherMode
            // 
            listBoxCipherMode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCipherMode.FormattingEnabled = true;
            listBoxCipherMode.ItemHeight = 20;
            listBoxCipherMode.Items.AddRange(new object[] { "CBC", "CFB", "ECB" });
            listBoxCipherMode.Location = new Point(8, 179);
            listBoxCipherMode.Name = "listBoxCipherMode";
            listBoxCipherMode.Size = new Size(244, 84);
            listBoxCipherMode.TabIndex = 18;
            listBoxCipherMode.SelectedIndexChanged += listBoxCipherMode_SelectedIndexChanged;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxTextResult);
            groupBoxOutput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxOutput.Location = new Point(531, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(508, 135);
            groupBoxOutput.TabIndex = 19;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Output";
            // 
            // textBoxTextResult
            // 
            textBoxTextResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTextResult.Location = new Point(6, 26);
            textBoxTextResult.Multiline = true;
            textBoxTextResult.Name = "textBoxTextResult";
            textBoxTextResult.PlaceholderText = "This text box is read-only";
            textBoxTextResult.ReadOnly = true;
            textBoxTextResult.Size = new Size(496, 103);
            textBoxTextResult.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 503);
            Controls.Add(groupBoxEncoding);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxAesOptions);
            Controls.Add(groupBoxIVOptions);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxSecretKeyOptions);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonEncrypt);
            MaximizeBox = false;
            MaximumSize = new Size(1067, 542);
            MinimumSize = new Size(1067, 542);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AES";
            groupBoxSecretKeyOptions.ResumeLayout(false);
            groupBoxSecretKeyOptions.PerformLayout();
            groupBoxEncoding.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxIVOptions.ResumeLayout(false);
            groupBoxIVOptions.PerformLayout();
            groupBoxAesOptions.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPaddingMode;
        private ListBox listBoxCipherMode;
        private ListBox listBoxKeySize;
        private ListBox listBoxEncoding;
        private TextBox textBoxSecretKey;
        private TextBox textBoxText;
        private TextBox textBoxIV;
        private TextBox textBoxTextResult;
    }
}
