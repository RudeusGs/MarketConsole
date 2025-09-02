namespace MarketMini.Entities
{
    public class FoodProduct : Product
    {
        public DateTime ExpiryDate { get; set; }
        public FoodProduct() { }
        public FoodProduct(string name, decimal price, int quantity, string category, DateTime expirydate) {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Category = category;
            this.ExpiryDate = expirydate;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Ten san pham: {Name}, Gia: {Price}, So luong con lai: {Quantity}, Danh muc: {Category}, Ngay het han: {ExpiryDate}";
        }
    }
}
