namespace MarketMini.Service
{
    public static class GenerateRandomPassword
    {
        public static string randomPassword()
        {
            const string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?";
            Random random = new Random();         
            int i = 0;
            string res = "";
            while (i < 7)
            {
                int a = random.Next(validChars.Length);
                res += validChars[a];
                i++;
            }
            return res;
        }

    }
}
