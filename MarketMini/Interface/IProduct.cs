using MarketMini.Entities;

namespace MarketMini.Interface
{
    public interface IProduct
    {
        public void AddElectronicProduct(ElectronicProduct electronicProduct);
        public void AddFoodProduct(FoodProduct foodProduct);
        public void Delete(int id);
        public void Update(int id);
        public void Print();

    }
}
