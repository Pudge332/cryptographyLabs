using System.Security.Cryptography;
using System.Text;

public class HybridCryptoSystem
{
    private readonly System.Security.Cryptography.RSA _rsa;
    private readonly string _publicKeyPath = "public.key";
    private readonly string _privateKeyPath = "private.key";
    private readonly string _encryptedSessionKeyPath = "session.key.enc";
    private readonly string _encryptedDataPath = "data.enc";
    private readonly string _ivPath = "iv.bin";
    private readonly string _signaturePath = "signature.sig";

    public HybridCryptoSystem(int keySize = 2048)
    {
        _rsa = System.Security.Cryptography.RSA.Create(keySize);
    }

    public void GenerateAndSaveKeys()
    {
        File.WriteAllText(_publicKeyPath, _rsa.ExportSubjectPublicKeyInfoPem());
        File.WriteAllText(_privateKeyPath, _rsa.ExportPkcs8PrivateKeyPem());
    }

    public void EncryptAndSign(string message)
    {
        // Шифрование данных AES
        using var aes = Aes.Create();
        aes.KeySize = 256;
        aes.GenerateKey();
        aes.GenerateIV();

        byte[] plainData = Encoding.UTF8.GetBytes(message);
        byte[] encryptedData;
        using (var encryptor = aes.CreateEncryptor())
        {
            encryptedData = encryptor.TransformFinalBlock(plainData, 0, plainData.Length);
        }

        // Шифрование ключа AES с помощью RSA
        byte[] encryptedKey = _rsa.Encrypt(aes.Key, RSAEncryptionPadding.OaepSHA256);

        // Создание подписи для исходных данных
        byte[] signature = _rsa.SignData(plainData, HashAlgorithmName.SHA256, RSASignaturePadding.Pss);

        // Сохранение данных
        File.WriteAllBytes(_encryptedSessionKeyPath, encryptedKey);
        File.WriteAllBytes(_encryptedDataPath, encryptedData);
        File.WriteAllBytes(_ivPath, aes.IV);
        File.WriteAllBytes(_signaturePath, signature);
    }

    public string DecryptAndVerify()
    {
        // Загрузка данных
        byte[] encryptedKey = File.ReadAllBytes(_encryptedSessionKeyPath);
        byte[] encryptedData = File.ReadAllBytes(_encryptedDataPath);
        byte[] iv = File.ReadAllBytes(_ivPath);
        byte[] signature = File.ReadAllBytes(_signaturePath);

        // Расшифровка ключа AES
        byte[] aesKey = _rsa.Decrypt(encryptedKey, RSAEncryptionPadding.OaepSHA256);

        // Расшифровка данных
        using var aes = Aes.Create();
        aes.Key = aesKey;
        aes.IV = iv;

        byte[] decryptedData;
        using (var decryptor = aes.CreateDecryptor())
        {
            decryptedData = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
        }

        // Проверка подписи
        if (!_rsa.VerifyData(decryptedData, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pss))
        {
            throw new CryptographicException("Недействительная подпись!");
        }

        return Encoding.UTF8.GetString(decryptedData);
    }

    public void ImportPublicKey()
    {
        string publicKeyPem = File.ReadAllText(_publicKeyPath);
        _rsa.ImportFromPem(publicKeyPem);
    }

    public void ImportPrivateKey()
    {
        string privateKeyPem = File.ReadAllText(_privateKeyPath);
        _rsa.ImportFromPem(privateKeyPem);
    }
}