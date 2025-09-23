using MarketMini.Entities.Base;

namespace MarketMini.Entities
{
    public class ElectronicProduct : Product
    {
        public TimeSpan WarrantyPeriod { get; set; }
        public ElectronicProduct() { }
        public ElectronicProduct(string name, decimal price, int quantity, string category, TimeSpan warrantyperiod)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Category = category;
            this.WarrantyPeriod = warrantyperiod;
        }
        public override string ToString()
        {
            return string.Format(
                "Id: {0,-5} | Ten san pham: {1,-20} | Gia: {2,-10:C} | So luong: {3,-5} | Danh muc: {4,-15} | Bao hanh: {5,-5} thang",
                Id,
                Name,
                Price,
                Quantity,
                Category,
                WarrantyPeriod
            );
        }

    }
}
