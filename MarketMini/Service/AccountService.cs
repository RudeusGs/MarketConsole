using MarketMini.Entities;
using MarketMini.Interface;
using System.Text.Json;

namespace MarketMini.Service
{
    public class AccountService : IAccount
    {
        private readonly string filePath = @"D:\Project\LearningC#\MarketMini\MarketMini\MarketMini\Data\Account.json";

        public void ChangePassword(int id, string oldpassword, string newpassword)
        {
           var change = LoadDataJson.Load<Account>(filePath);
            var account = change.FirstOrDefault(x => x.Id == id);
            if (account == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Không tìm thấy tài khoản này!");
                Console.ResetColor();
                return;
            }
            if (account.Password != oldpassword) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mật khẩu cũ không chính xác");
                Console.ResetColor();
                return;
            }
            account.Password = newpassword;
            LoadDataJson.Save(filePath, change);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Đổi mật khẩu thành công!");
            Console.ResetColor();

        }

        public void ForgotPassword(string email)
        {
            var accounts = LoadDataJson.Load<Account>(filePath);
            var user = accounts.FirstOrDefault(x =>
                x.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            if (user == null)
            {
                Console.WriteLine("Không tìm thấy tài khoản với email này.");
                return;
            }
            string newPassword = GenerateRandomPassword.randomPassword();
            user.Password = newPassword;
            LoadDataJson.Save(filePath, accounts);
            Console.WriteLine($"Mật khẩu mới của bạn là: {newPassword}");
        }

        public void Login(string username, string password)
        {
            var login = LoadDataJson.Load<Account>(filePath);
            var accounts = login.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (accounts != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Đăng nhập thành công!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tài khoản hoặc mật khẩu không chính xác!");
                Console.ResetColor();
            }
        }

        public void Register(string username, string password, string name, string email)
        {
            var accounts = LoadDataJson.Load<Account>(filePath);
            if(accounts.Any(x => x.UserName == username))
            {
                Console.WriteLine("Tên tài khoản này đã tồn tại vui lòng sử dụng tên tài khoản khác");
                return;
            }
            if (accounts.Any(x => x.Email == email))
            {
                Console.WriteLine("Email này đã được sử dụng");
                return;
            }
            var newAccount = new Account(username, password, 0, name, email)
            {
                Id = accounts.Count > 0 ? accounts.Max(x => x.Id) + 1 : 1
            };
            accounts.Add(newAccount);
            LoadDataJson.Save(filePath, accounts);
            Console.WriteLine("Đăng ký thành công");
        }
    }
}
