using Garments_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Garments_Management_System.Controllers
{
    public class AdminController : Controller
    {
        private static List<Admin> admins = new()
        {
            new Admin { A_Id = 101, Name = "Sajid", Password = "1234" }
        };
        
        [HttpGet("Admin/Index")]
        public IActionResult Index()
        {
            return View(admins);
        }
    }
}
