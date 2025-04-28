using System.ComponentModel.DataAnnotations;

namespace Garments_Management_System.Models
{
    public class Supplier
    {
        [Key]
        public static int S_Id { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
    }
}
