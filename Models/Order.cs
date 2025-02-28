using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Order details are required")]
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}