using DoAnCN_WebsiteKDTD.Models;

namespace DoAnCN_WebsiteKDTD.ViewModel
{
    public class AdminDashboardViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
