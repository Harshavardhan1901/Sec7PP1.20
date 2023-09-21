using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BankWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
