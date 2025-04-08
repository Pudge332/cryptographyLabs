using System.Numerics;
using System.Security.Cryptography;

public class RSA
{
    public BigInteger PublicKeyE { get; private set; }
    public BigInteger PublicKeyN { get; private set; }
    public BigInteger PrivateKeyD { get; private set; }
    public BigInteger PrivateKeyP { get; private set; }
    public BigInteger PrivateKeyQ { get; private set; }

    private readonly RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();

    /// <summary>
    /// Генерирует пару ключей (открытый и закрытый).
    /// </summary>
    /// <param name="bitLength">Длина простых чисел p и q в битах ( ≥ 512).</param>
    public void GenerateKeys(int bitLength = 512)
    {
        // Генерация двух различных простых чисел p и q
        PrivateKeyP = GeneratePrime(bitLength);
        PrivateKeyQ = GeneratePrime(bitLength);
        while (PrivateKeyP == PrivateKeyQ)
            PrivateKeyQ = GeneratePrime(bitLength);

        // Вычисление n и φ(n)
        PublicKeyN = PrivateKeyP * PrivateKeyQ;
        BigInteger phi = (PrivateKeyP - 1) * (PrivateKeyQ - 1);

        // Выбор открытой экспоненты e (обычно 65537)
        PublicKeyE = FindE(phi);

        // Вычисление закрытой экспоненты d
        PrivateKeyD = ModInverse(PublicKeyE, phi);
    }

    /// <summary>
    /// Шифрует число с использованием открытого ключа (e, n).
    /// </summary>
    /// <param name="message">Число для шифрования (должно быть меньше n).</param>
    public BigInteger Encrypt(BigInteger message)
    {
        if (message >= PublicKeyN)
            throw new ArgumentException("Сообщение должно быть меньше n.", nameof(message));

        return ModExp(message, PublicKeyE, PublicKeyN);
    }

    /// <summary>
    /// Расшифровывает число с использованием закрытого ключа (d, p, q) и китайской теоремы об остатках.
    /// </summary>
    /// <param name="ciphertext">Зашифрованное число.</param>
    public BigInteger Decrypt(BigInteger ciphertext)
    {
        if (PrivateKeyP == 0 || PrivateKeyQ == 0 || PrivateKeyD == 0)
            throw new InvalidOperationException("Закрытый ключ не инициализирован. Сначала вызовите GenerateKeys().");

        // Оптимизация через китайскую теорему об остатках
        BigInteger dp = PrivateKeyD % (PrivateKeyP - 1);
        BigInteger dq = PrivateKeyD % (PrivateKeyQ - 1);
        BigInteger qInv = ModInverse(PrivateKeyQ, PrivateKeyP);

        BigInteger m1 = ModExp(ciphertext, dp, PrivateKeyP);
        BigInteger m2 = ModExp(ciphertext, dq, PrivateKeyQ);

        BigInteger h = (qInv * (m1 - m2)) % PrivateKeyP;
        if (h < 0)
            h += PrivateKeyP;

        BigInteger decrypted = m2 + h * PrivateKeyQ;
        return decrypted;
    }

    private BigInteger ModExp(BigInteger a, BigInteger exponent, BigInteger mod)
    {
        BigInteger result = 1;
        a %= mod;
        while (exponent > 0)
        {
            if ((exponent & 1) == 1)
                result = (result * a) % mod;
            a = (a * a) % mod;
            exponent >>= 1;
        }
        return result;
    }

    private BigInteger GCD(BigInteger a, BigInteger b)
    {
        while (b != 0)
        {
            BigInteger temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private BigInteger ModInverse(BigInteger a, BigInteger m)
    {
        BigInteger m0 = m;
        BigInteger y = 0, x = 1;

        if (m == 1)
            return 0;

        while (a > 1)
        {
            BigInteger q = a / m;
            BigInteger t = m;

            m = a % m;
            a = t;
            t = y;

            y = x - q * y;
            x = t;
        }

        return x < 0 ? x + m0 : x;
    }

    private BigInteger FindE(BigInteger phi)
    {
        BigInteger e = 65537;
        if (e < phi && GCD(e, phi) == 1)
            return e;

        while (true)
        {
            e = GenerateRandomBigInteger(2, phi - 1, _rng);
            if (GCD(e, phi) == 1)
                return e;
        }
    }

    private BigInteger GeneratePrime(int bitLength)
    {
        BigInteger prime;
        do
        {
            prime = GenerateRandomOddNumber(bitLength, _rng);
        } while (!IsPrime(prime, 10));
        return prime;
    }

    private BigInteger GenerateRandomOddNumber(int bitLength, RNGCryptoServiceProvider rng)
    {
        byte[] bytes = new byte[bitLength / 8 + 1];
        rng.GetBytes(bytes);
        bytes[bytes.Length - 1] &= 0x7F;
        BigInteger number = new BigInteger(bytes);
        return number | 1;
    }

    private bool IsPrime(BigInteger n, int k)
    {
        if (n <= 1) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0) return false;

        BigInteger d = n - 1;
        int s = 0;
        while (d % 2 == 0)
        {
            d /= 2;
            s++;
        }

        for (int i = 0; i < k; i++)
        {
            BigInteger a = GenerateRandomBigInteger(2, n - 2, _rng);
            BigInteger x = ModExp(a, d, n);
            if (x == 1 || x == n - 1)
                continue;

            bool composite = true;
            for (int j = 0; j < s - 1; j++)
            {
                x = ModExp(x, 2, n);
                if (x == n - 1)
                {
                    composite = false;
                    break;
                }
            }

            if (composite)
                return false;
        }
        return true;
    }

    private BigInteger GenerateRandomBigInteger(BigInteger min, BigInteger max, RNGCryptoServiceProvider rng)
    {
        BigInteger range = max - min;
        byte[] bytes = range.ToByteArray();
        BigInteger result;
        do
        {
            rng.GetBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F;
            result = new BigInteger(bytes);
        } while (result >= range);
        return result + min;
    }
}