namespace MarketMini.Entities
{
    public class Staff
    {
        public int Id { get; set; }          // Mã nhân viên
        public string FullName { get; set; }      // Họ và tên
        public string Email { get; set; }         // Email đăng nhập
        public string PhoneNumber { get; set; }   // Số điện thoại
        public string Position { get; set; }      // Chức vụ (Thu ngân, Quản lý, Bán hàng...)
        public decimal Salary { get; set; }       // Lương cơ bản
        public DateTime StartDate { get; set; }   // Ngày bắt đầu làm việc
        public bool IsActive { get; set; }        // Trạng thái làm việc (đang làm / nghỉ)
        public override string ToString()
        {
            return string.Format(
                "Id: {0,-5} | Ten: {1,-20} | Email: {2,-25} | Phone: {3,-12} | Chuc vu: {4,-15} | Luong: {5,-10:C} | Bat dau: {6:dd/MM/yyyy} | Active: {7}",
                Id,
                FullName,
                Email,
                PhoneNumber,
                Position,
                Salary,
                StartDate,
                IsActive ? "Yes" : "No"
            );
        }
    }
}
