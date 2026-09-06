
using System.ComponentModel.DataAnnotations;

namespace CoreCodeFirst.E_commerce
{
  
   public class Customer {
   public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    public CustomerAddress CustomerAddress { get; set; }
    public ICollection<Order> Orders { get; set; }

   }


}