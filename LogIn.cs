using System.ComponentModel.DataAnnotations;

namespace Garments_Management_System.Models
{
    public class LogIn
    {
        [Key]
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
    }
}
