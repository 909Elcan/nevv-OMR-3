
using System.ComponentModel.DataAnnotations;

namespace CoreCodeFirst.E_commerce
{
   
   public class Product {
    
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

    public Category Category { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; }
   }


}