namespace MarketMini.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> products { get; set; }
        public int TotalPrice { get; set; }
        public DateTime dateTime { get; set; }
    }
}
