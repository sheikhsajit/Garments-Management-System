using System.ComponentModel.DataAnnotations;

namespace Garments_Management_System.Models
{
    public class Manager
    {
        [Key]
        public static int M_Id { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
    }
}
