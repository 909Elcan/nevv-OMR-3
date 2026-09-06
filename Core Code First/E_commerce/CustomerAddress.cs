
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCodeFirst.E_commerce
{
   
   public class CustomerAddress 
   {
      public int Id { get; set; }
      public int CustomerId { get; set; }

      [Required]
      public string Address { get; set; }

      [Required]
      public string City { get; set; }

      public Customer Customer { get; set; }
   }


}