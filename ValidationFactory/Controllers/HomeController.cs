using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationFactory.Models;
using ValidationFactory.Validators;

namespace ValidationFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string httpMethod = HttpContext.Request.Method;
            User user = new User()
            {
                Name = "Berkan",
                LastName = "Çelik",
                UserName = "bC",
                //Password = "vbt123456",
                Password = "hasßm+KKpEl/qgGDrqHZOi6RCQ9Wlj48vYzDnDdm6ctFGO4=æ1rN9gprpjCRDlkINl+ybHw==",
                //Email = "bora.kasmer78",
                Email = "encßnkLseH+tsLd1JH6dMzAB9giK5uX/YjqrczLWwVPrT/M=",
                Email2 = "berkan.celik@gmail.com",
                BirthDate = new DateTime(1881, 6, 3),
                //Gsm = "5426781944",
                Gsm = "encßGWXGzj2SGYu70PzzMYVaFfWwl0wzS6Lc",
            };
            List<(bool, Exception)> errorList = new();
            errorList = ValidateClassProperties.GetValidatoResult(user);
            ResultModel model = new() { Exception = errorList.Select(li => li.Item2).ToList(), User = user };
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(User model)
        {
            User user = new User()
            {
                Name = "Berkan",
                LastName = "Celik",
                UserName = "berkancelik",
                Password = "vbt123456",
                Email = "berkan.celik",
                Email2 = "berkan.celik@gmail.com",
                BirthDate = new DateTime(1881, 6, 3),
                Gsm = "05312365478",
            };
            List<(bool, Exception)> errorList = new();
            errorList = ValidateClassProperties.GetValidatoResult(user);
            ResultModel resultModel = new() { Exception = errorList.Select(li => li.Item2).ToList(), User = user };
            return View(resultModel);
        }
    }
}