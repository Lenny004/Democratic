using System;
using System.Security.Cryptography;

namespace Modelo
{
    /// <summary>Genera y valida hashes PBKDF2 compatibles con contraseñas heredadas.</summary>
    public static class PasswordHasher
    {
        private const string Prefix = "PBKDF2$";
        private const int Iterations = 100000;
        private const int SaltSize = 16;
        private const int HashSize = 32;

        public static string Hash(string password)
        {
            byte[] salt = new byte[SaltSize];
            using (var random = RandomNumberGenerator.Create()) random.GetBytes(salt);
            using (var derive = new Rfc2898DeriveBytes(password ?? string.Empty, salt, Iterations))
                return string.Format("{0}{1}${2}${3}", Prefix, Iterations,
                    Convert.ToBase64String(salt), Convert.ToBase64String(derive.GetBytes(HashSize)));
        }

        public static bool Verify(string password, string stored, out bool legacy)
        {
            legacy = false;
            if (string.IsNullOrEmpty(stored)) return false;
            if (!stored.StartsWith(Prefix, StringComparison.Ordinal))
            {
                legacy = true;
                return FixedEquals(password ?? string.Empty, stored);
            }
            string[] parts = stored.Split('$');
            int iterations;
            byte[] salt, expected;
            if (parts.Length != 4 || !int.TryParse(parts[1], out iterations)) return false;
            try { salt = Convert.FromBase64String(parts[2]); expected = Convert.FromBase64String(parts[3]); }
            catch (FormatException) { return false; }
            using (var derive = new Rfc2898DeriveBytes(password ?? string.Empty, salt, iterations))
                return FixedEquals(derive.GetBytes(expected.Length), expected);
        }

        private static bool FixedEquals(string left, string right)
        {
            return FixedEquals(System.Text.Encoding.UTF8.GetBytes(left), System.Text.Encoding.UTF8.GetBytes(right));
        }

        private static bool FixedEquals(byte[] left, byte[] right)
        {
            if (left.Length != right.Length) return false;
            int diff = 0;
            for (int i = 0; i < left.Length; i++) diff |= left[i] ^ right[i];
            return diff == 0;
        }
    }
}
