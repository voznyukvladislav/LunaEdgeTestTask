namespace LunaEdgeTestTask.Data
{
    public static class Hashings
    {
        public static string GetBcryptHash(string str)
        {
            return BCrypt.Net.BCrypt.HashPassword(str);
        }

        public static bool VerifyBcrypt(string str, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(str, hash);
        }
    }
}
