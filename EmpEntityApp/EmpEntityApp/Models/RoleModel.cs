using System.ComponentModel.DataAnnotations;

namespace EmpEntityApp.Models
{
    public class RoleModel
    {
        [Display(Name ="Role Id")]
        public int Id { get; set; }

        [Display(Name="Role")]
        public string RoleName { get; set; }
    }
}
