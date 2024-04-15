using System.ComponentModel.DataAnnotations;

namespace EmpEntityApp.Data
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string UserRole { get; set; }

        public ICollection<Role> Roles { get; set;}
    }
}
