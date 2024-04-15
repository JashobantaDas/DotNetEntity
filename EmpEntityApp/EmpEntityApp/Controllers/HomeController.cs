using EmpEntityApp.Data;
using EmpEntityApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmpEntityApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetAllUser() { 
            var results = _appDbContext.User.ToList();

            return View();
        }

        public IActionResult AddRole()
        {
            ViewBag.Sucess = "";
            return View();
        }

        [HttpPost]
        public IActionResult AddRole(RoleModel roleModel)
        {
            var chk = ModelState.IsValid;
            if (chk)
            {
                Role role = new Role();
                role.UserRole = roleModel.RoleName.ToString();
                _appDbContext.Role.Add(role);
                int changes = _appDbContext.SaveChanges();
                if ( changes > 0)
                {
                    ViewBag.Success = "Inserted";

                }
                else
                {
                    ViewBag.Success = "NotInserted";
                }
                ModelState.Clear();
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
