using Course.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        
        public IActionResult Apply(){
            return View(); //For Get
        }

        [HttpPost]
        public IActionResult Apply(Candidate model)
        {
            return View(); //For Post
        }
    }
}