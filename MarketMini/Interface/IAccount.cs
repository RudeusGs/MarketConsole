namespace MarketMini.Interface
{
    public interface IAccount
    {
        void Register(string username, string password, string name, string email);
        void Login(string username, string password);
        void ForgotPassword(string email);
        void ChangePassword(int id, string oldpassword, string newpassword);
    }
}
