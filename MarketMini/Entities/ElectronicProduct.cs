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
            return $"Id: {Id}, Ten san pham: {Name}, Gia: {Price}, So luong con lai: {Quantity}, Danh muc: {Category}, Thoi han bao hanh con lai: {WarrantyPeriod}";
        }
    }
}
