namespace MarketMini.UI
{
    public static class UILoading
    {
        public static void Loading(string msg, int delayMs = 2000)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\n{msg}");
            Console.ResetColor();

            int dotCount = delayMs / 500;
            for (int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}