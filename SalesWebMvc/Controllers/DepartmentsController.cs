using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers {
    public class DepartmentsController : Controller {
        public IActionResult Index() {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Books" });
            list.Add(new Department { Id = 2, Name = "Computers" });
            list.Add(new Department { Id = 3, Name = "Electronics" });
            list.Add(new Department { Id = 4, Name = "Fashion" });

            return View(list);
        }

  
    }
}
