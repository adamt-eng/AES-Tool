# AES Tool

AES Tool is a simple Windows Forms application that allows users to perform AES (Advanced Encryption Standard) encryption and decryption. This tool provides a user-friendly interface for selecting encryption settings such as Cipher Mode, Encoding, Key Size, and Padding Mode.

## Features

- **AES Encryption/Decryption**: Utilizes the AES algorithm to encrypt and decrypt data.
- **Customizable Settings**: 
  - **Cipher Mode**: Select between different block cipher modes (CBC, CFB, ECB).
  - **Encoding**: Choose the encoding format (Hexadecimal, Base64).
  - **Key Size**: Configure the key size (e.g., 256-bit).
  - **Padding Mode**: Select a padding scheme (e.g., PKCS7).
- **Graphical User Interface**: Simple and easy-to-use interface for configuring the encryption parameters.
- **IV and Secret Key Generation**: The tool provides two buttons to easily generate a secure Initialization Vector (IV) and a secret key for encryption.

## Installation

### 1. **Prerequisites**

- Ensure that you have [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your machine:

- You can verify the .NET SDK installation by running:

  ```bash
  dotnet --version
  ```

### 2. **Download the Source Code**

- Clone this repository using the following command:

  ```bash
  git clone https://github.com/adamt-eng/AES-Tool
  ```

### 3. **Navigate to the Project Directory**

- After cloning the repository, navigate into the project directory:

  ```bash
  cd AES-Tool
  ```

### 4. **Compile the Source Code**

- Restore dependencies with the following command:

  ```bash
  dotnet restore
  ```

- Once dependencies are restored, compile the project using:

  ```bash
  dotnet build --configuration Release
  ```

### 5. **Run the Application:**

- If the build is successful, you can run the application with:

  ```bash
  dotnet run
  ```

## Usage

1. Launch the application.
2. Select the desired options from the available dropdowns:
   - **Cipher Mode**
   - **Encoding**
   - **Key Size**
   - **Padding Mode**
3. Use the **Generate IV** button to create a secure Initialization Vector (IV).
4. Use the **Generate Key** button to generate a secret key.
5. Input the text you want to encrypt or decrypt.
6. Click the appropriate button (`Encrypt` or `Decrypt`).
7. The output will be displayed in the `Output` area.
