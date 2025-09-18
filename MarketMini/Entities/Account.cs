namespace MarketMini.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MembershipLevel { get; set; }
        public Account(string userName, string password, decimal balance, string name, string email)
        {
            UserName = userName;
            Password = password;
            Balance = balance;
            Name = name;
            Email = email;
            MembershipLevel = "Normal";
        }
    }
}
