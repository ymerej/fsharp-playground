module TestProject1.CopilotGenTest

(*
I want you to write two F#  methods: Save and Open.

The Save method should take the contents of a textbox (named Text) and use the AES crypto provider to encrypt the context of Text to a file. The code should first save the crypto providers IV to the file (non-encrypted) and then write the contents of Text to the (same) file encrypted.

The Open method should first read the IV from the file and then use that IV to read the rest of the file and decrypt it and store the decrypted text in Text.

Both methods should use the same password - "12345678"
*)

open System.IO
open System.Security.Cryptography
open System.Text

let password = "12345678"

let generateKeyAndIV (password : string) =
    let key = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes("SaltIsGood"), 10000)
    (key.GetBytes(32), key.GetBytes(16))

let Save (text: string) (filePath: string) =
    let (key, iv) = generateKeyAndIV password
    use aes = Aes.Create()
    aes.Key <- key
    aes.IV <- iv

    use fileStream = new FileStream(filePath, FileMode.Create)
    fileStream.Write(iv, 0, iv.Length)

    use cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
    use streamWriter = new StreamWriter(cryptoStream)
    streamWriter.Write(text)

let Open (filePath: string) =
    let (key, _) = generateKeyAndIV password
    use fileStream = new FileStream(filePath, FileMode.Open)
    
    let iv = Array.zeroCreate<byte> 16
    fileStream.Read(iv, 0, iv.Length) |> ignore

    use aes = Aes.Create()
    aes.Key <- key
    aes.IV <- iv

    use cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read)
    use streamReader = new StreamReader(cryptoStream)
    streamReader.ReadToEnd()
    
open Xunit

(*
generate F# XUnit tests for the two functions
*)

[<Fact>]
let ``Save and Open should correctly encrypt and decrypt text`` () =
    // Arrange
    let originalText = "This is a test text."
    let filePath = "testfile.txt"

    // Act
    Save originalText filePath
    let decryptedText = Open(filePath)

    // Assert
    Assert.Equal(originalText, decryptedText)

    // Clean up
    if File.Exists(filePath) then
        File.Delete(filePath)