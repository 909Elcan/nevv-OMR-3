
using System.ComponentModel.DataAnnotations;

namespace CoreCodeFirst.E_commerce
{
   
   public class Order {
    public int Id { get; set; }
    public int CustomerId { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    public Customer Customer { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; }
   }


}