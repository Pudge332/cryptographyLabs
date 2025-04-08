using System.Numerics;

RSA rsa = new RSA();
rsa.GenerateKeys(512); // Генерация ключей (512 бит)

Console.WriteLine("Открытый ключ (e, n):");
Console.WriteLine($"e = {rsa.PublicKeyE}");
Console.WriteLine($"n = {rsa.PublicKeyN}");

Console.WriteLine("\nЗакрытый ключ (d, p, q):");
Console.WriteLine($"d = {rsa.PrivateKeyD}");
Console.WriteLine($"p = {rsa.PrivateKeyP}");
Console.WriteLine($"q = {rsa.PrivateKeyQ}");

// Шифрование и дешифрование
BigInteger message = 123456;
Console.WriteLine($"\nИсходное сообщение: {message}");

BigInteger ciphertext = rsa.Encrypt(message);
Console.WriteLine($"Зашифрованное сообщение: {ciphertext}");

BigInteger decrypted = rsa.Decrypt(ciphertext);
Console.WriteLine($"Расшифрованное сообщение: {decrypted}");

//2
// Участник A
var alice = new DiffieHellman();
alice.GenerateParameters(512);
alice.GenerateKeys();

// Участник B
var bob = new DiffieHellman();
bob.PrimeP = alice.PrimeP; // Общие параметры
bob.BaseG = alice.BaseG;
bob.GenerateKeys();

// Обмен открытыми ключами
BigInteger alicePublicKey = alice.PublicKeyY;
BigInteger bobPublicKey = bob.PublicKeyY;

// Вычисление общего секрета
BigInteger aliceSecret = alice.ComputeSharedSecret(bobPublicKey);
BigInteger bobSecret = bob.ComputeSharedSecret(alicePublicKey);

Console.WriteLine($"Параметры:\np = {alice.PrimeP}\ng = {alice.BaseG}\n");
Console.WriteLine($"Ключ Alice:\nПриватный: {alice.PrivateKeyX}\nПубличный: {alice.PublicKeyY}\n");
Console.WriteLine($"Ключ Bob:\nПриватный: {bob.PrivateKeyX}\nПубличный: {bob.PublicKeyY}\n");
Console.WriteLine($"Общий секрет Alice: {aliceSecret}");
Console.WriteLine($"Общий секрет Bob: {bobSecret}");
Console.WriteLine($"Совпадают: {aliceSecret == bobSecret}");

//3
// Отправитель
var crypto = new HybridCryptoSystem();

// Генерация ключей
crypto.GenerateAndSaveKeys();

// Шифрование и подпись
crypto.EncryptAndSign("Секретное сообщение");

// На стороне получателя
var receiver = new HybridCryptoSystem();
receiver.ImportPrivateKey();
string result = receiver.DecryptAndVerify();

Console.WriteLine($"Результат: {result}");