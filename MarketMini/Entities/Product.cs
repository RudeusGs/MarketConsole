namespace MarketMini.Entities
{
    public class Product
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal Price { get; set; }
        protected int Quantity { get; set; }
        protected string Category { get; set; }
    }
}
