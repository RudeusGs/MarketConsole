namespace MarketMini.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }       // Ngày lập báo cáo
        public decimal TotalRevenue { get; set; }      // Tổng doanh thu
        public int TotalProductsSold { get; set; }     // Tổng số lượng sản phẩm đã bán
        public int TotalOrders { get; set; }           // Tổng số đơn hàng
        public int TotalCustomers { get; set; }        // Tổng số khách hàng
        public Dictionary<string, decimal> RevenueByCategory { get; set; }
            = new Dictionary<string, decimal>();
        public override string ToString()
        {
            return string.Format(
                "ReportId: {0,-5} | Date: {1:dd/MM/yyyy} | Revenue: {2,-15:C} | Sold: {3,-5} | Orders: {4,-5} | Customers: {5,-5}",
                Id,
                ReportDate,
                TotalRevenue,
                TotalProductsSold,
                TotalOrders,
                TotalCustomers
            );
        }
    }
}
