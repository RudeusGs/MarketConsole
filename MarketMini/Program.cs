using System;
using System.Text;
using MarketMini.UI;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🛒 Mini Supermarket System";

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║   ███╗   ███╗ █████╗ ██████╗ ██╗  ██╗███████╗████████╗       ║");
            Console.WriteLine("║   ████╗ ████║██╔══██╗██╔══██╗██║ ██╔╝██╔════╝╚══██╔══╝       ║");
            Console.WriteLine("║   ██╔████╔██║███████║██████╔╝█████╔╝ █████╗     ██║          ║");
            Console.WriteLine("║   ██║╚██╔╝██║██╔══██║██╔═█═╝ ██╔═██╗ ██╔══╝     ██║          ║");
            Console.WriteLine("║   ██║ ╚═╝ ██║██║  ██║██║  █  ██║  ██╗███████╗   ██║          ║");
            Console.WriteLine("║   ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝  ╚═╝╚══════╝   ╚═╝          ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n                ✨ WELCOME TO MINI SUPERMARKET ✨\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("  ║  [1] 🔑 Tài khoản                                      ║");
            Console.WriteLine("  ║  [2] 🛍️ Mua hàng(User)                                 ║");
            Console.WriteLine("  ║  [3] ⚙️ Quản lý hệ thống(Admin)                        ║");
            Console.WriteLine("  ║  [4] 🚪 Thoát                                          ║");
            Console.WriteLine("  ╚════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n👉 Chọn chức năng (1-5): ");
            Console.ResetColor();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UILoading.Loading("Loading", 3000);
                    System.Threading.Thread.Sleep(1000);
                    AuthUI.ShowAuthMenu();
                    break;
                case "2":
                    UILoading.Loading("Loading", 3000);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "3":
                    UILoading.Loading("Loading", 3000);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "4":
                    UILoading.Loading("Loading", 3000);
                    System.Threading.Thread.Sleep(1000);
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n❌ Lựa chọn không hợp lệ, thử lại!");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
