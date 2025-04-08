using System.Numerics;
using System.Security.Cryptography;

public class DiffieHellman
{
    public BigInteger PrimeP { get; set; }
    public BigInteger BaseG { get; set; }
    public BigInteger PrivateKeyX { get; private set; }
    public BigInteger PublicKeyY { get; private set; }

    private readonly RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();

    /// <summary>
    /// Генерирует параметры p (простое число) и g (первообразный корень).
    /// </summary>
    /// <param name="bitLength">Длина p в битах (рекомендуется ≥ 512).</param>
    public void GenerateParameters(int bitLength = 512)
    {
        // Генерация безопасного простого числа p = 2*q + 1
        PrimeP = GenerateSafePrime(bitLength);
        BaseG = FindPrimitiveRoot(PrimeP);
    }

    /// <summary>
    /// Генерирует секретный (x) и открытый (y = g^x mod p) ключи.
    /// </summary>
    public void GenerateKeys()
    {
        if (PrimeP == 0 || BaseG == 0)
            throw new InvalidOperationException("Сначала вызовите GenerateParameters().");

        // Генерация секретного ключа x (1 < x < p-1)
        PrivateKeyX = GenerateRandomBigInteger(2, PrimeP - 2, _rng);
        PublicKeyY = ModExp(BaseG, PrivateKeyX, PrimeP);
    }

    /// <summary>
    /// Вычисляет общий секрет на основе открытого ключа другого участника.
    /// </summary>
    public BigInteger ComputeSharedSecret(BigInteger otherPublicKey)
    {
        return ModExp(otherPublicKey, PrivateKeyX, PrimeP);
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

    private BigInteger GenerateSafePrime(int bitLength)
    {
        BigInteger q;
        BigInteger p;
        do
        {
            q = GeneratePrime(bitLength - 1);
            p = 2 * q + 1;
        } while (!IsPrime(p, 10));
        return p;
    }

    private BigInteger FindPrimitiveRoot(BigInteger p)
    {
        // Для безопасного простого числа p=2q+1 первообразный корень можно выбрать как 2 или (p-1)/2
        BigInteger testRoot = 2;
        if (ModExp(testRoot, 2, p) != 1 && ModExp(testRoot, (p - 1) / 2, p) != 1)
            return testRoot;
        return p - 1; // Альтернативный вариант
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

    private BigInteger GenerateRandomOddNumber(int bitLength, RNGCryptoServiceProvider rng)
    {
        byte[] bytes = new byte[bitLength / 8 + 1];
        rng.GetBytes(bytes);
        bytes[bytes.Length - 1] &= 0x7F;
        BigInteger number = new BigInteger(bytes);
        return number | 1;
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


