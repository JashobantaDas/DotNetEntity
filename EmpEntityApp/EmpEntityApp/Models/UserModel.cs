using System.ComponentModel.DataAnnotations;

namespace EmpEntityApp.Models
{
    public class UserModel
    {
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Display(Name ="Password")]
        public string Password { get; set; }

        [Display(Name = "User Role")]
        public String UserRole { get; set; }
    }
}
