using MarketMini.Entities.Base;

namespace MarketMini.Entities
{
    public class ClothesProduct : Product
    {
        public string Size { get; set; }        // Kích cỡ: S, M, L, XL
        public string Color { get; set; }
        public string Material { get; set; }    // Chất liệu: cotton, jeans...
        public string Brand { get; set; }       // Thương hiệu
        public string Gender { get; set; }      // Nam / Nữ / Unisex

        public override string ToString()
        {
            return string.Format(
                "Id: {0,-5} | Ten: {1,-20} | Gia: {2,-12:C} | So luong: {3,-5} | Danh muc: {4,-15} | Size: {5,-5} | Mau: {6,-10} | Chat lieu: {7,-15} | Thuong hieu: {8,-15} | Gioi tinh: {9,-10}",
                Id,
                Name,
                Price,
                Quantity,
                Category,
                Size,
                Color,
                Material,
                Brand,
                Gender
            );
        }

    }
}
