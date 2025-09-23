using System.Text;
using MarketMini.Service;

namespace MarketMini.UI
{
    public static class AuthUI
    {
        private static AccountService accountService = new AccountService();

        public static void ShowAuthMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║        🔑 ĐĂNG NHẬP / ĐĂNG KÝ        ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  [1] Đăng nhập");
                Console.WriteLine("  [2] Đăng ký");
                Console.WriteLine("  [3] Quên mật khẩu");
                Console.WriteLine("  [4] Quay lại");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n👉 Chọn chức năng (1-4): ");
                Console.ResetColor();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        LoginForm();
                        break;
                    case "2":
                        RegisterForm();
                        break;
                    case "3":
                        ForgotPasswordForm();
                        break;
                    case "4":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Lựa chọn không hợp lệ!");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void LoginForm()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║            🔑 LOGIN FORM           ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ResetColor();

            Console.Write("👤 Username: ");
            string username = Console.ReadLine();

            Console.Write("🔒 Password: ");
            string password = GetHiddenInput();

            Console.WriteLine();
            accountService.Login(username, password);

            Console.WriteLine("\n(Ấn phím bất kỳ để quay lại...)");
            Console.ReadKey();
        }

        static void RegisterForm()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║           📝 REGISTER FORM         ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ResetColor();

            Console.Write("👤 Username: ");
            string username = Console.ReadLine();

            Console.Write("📧 Email: ");
            string email = Console.ReadLine();

            Console.Write("👨 Họ và tên: ");
            string name = Console.ReadLine();

            Console.Write("🔒 Password: ");
            string password = GetHiddenInput();

            Console.Write("🔒 Confirm Password: ");
            string confirm = GetHiddenInput();

            if (password != confirm)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ Password không trùng khớp!");
                Console.ResetColor();
            }
            else
            {
                accountService.Register(username, password, name, email);
            }

            Console.WriteLine("\n(Ấn phím bất kỳ để quay lại...)");
            Console.ReadKey();
        }

        static void ForgotPasswordForm()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║          🔒 FORGOT PASSWORD        ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ResetColor();

            Console.Write("👤 Email: ");
            string email = Console.ReadLine();

            accountService.ForgotPassword(email);

            Console.WriteLine("\n(Ấn phím bất kỳ để quay lại...)");
            Console.ReadKey();
        }

        static string GetHiddenInput()
        {
            var input = new StringBuilder();
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    input.Append(key.KeyChar);
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            return input.ToString();
        }
    }
}
