using System.ComponentModel.DataAnnotations;

namespace Garments_Management_System.Models
{
    public class Admin
    {
        [Key]
        public  int A_Id { get; set; }
        public  string Name { get; set; }
        public  string Password { get; set; }
    }
}
