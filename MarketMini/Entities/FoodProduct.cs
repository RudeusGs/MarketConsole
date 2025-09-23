using MarketMini.Entities.Base;

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
            return string.Format(
                "Id: {0,-5} | Ten san pham: {1,-20} | Gia: {2,-12:C} | So luong: {3,-5} | Danh muc: {4,-15} | Ngay het han: {5:dd/MM/yyyy}",
                Id,
                Name,
                Price,
                Quantity,
                Category,
                ExpiryDate
            );
        }

    }
}
