using System;
using System.Security.Cryptography;
using System.Text;

internal class PasswordHashService
{
    private const int SaltSize = 16; // Размер соли (16 байт = 128 бит)
    private const int HashSize = 64; // Размер хэша (64 байта = 512 бит)
    private const int Iterations = 100000; // Количество итераций (чем больше, тем сложнее взломать)

    public static string HashPassword(string password)
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt); // Генерируем случайную соль

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA512))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Комбинируем соль и хэш в одну строку (Base64)
                return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
            }
        }
    }

    public static bool VerifyPassword(string password, string storedHash)
    {
        try
        {
            string[] parts = storedHash.Split(':');
            if (parts.Length != 2) return false;

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedHashBytes = Convert.FromBase64String(parts[1]);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA512))
            {
                byte[] computedHash = pbkdf2.GetBytes(HashSize);

                return SlowEquals(computedHash, storedHashBytes);
            }
        }
        catch
        {
            return false; // В случае ошибки (например, некорректный формат хэша)
        }
    }

    private static bool SlowEquals(byte[] a, byte[] b)
    {
        if (a.Length != b.Length)
            return false;

        int diff = 0;
        for (int i = 0; i < a.Length; i++)
        {
            diff |= a[i] ^ b[i]; // XOR сравнение без раннего выхода
        }
        return diff == 0;
    }

}
