using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class AddCustomerForm
    {
        
        [Required] 
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
