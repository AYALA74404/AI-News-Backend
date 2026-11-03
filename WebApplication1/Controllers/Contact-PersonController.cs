using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        Person p1 = new Person("John Doe", "123-456-7890", "hlhj@.dljdklj", true);
        Person p2 = new Person("Jane Smith", "123-456-7890", "hlhj@.dljdklj", true);
        Person p3 = new Person("Bob Johnson", "123-456-7890", "hlhj@.dljdklj", true);




        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contacts")]
        public Person[] GetContact()
        {
            Person[] contacts = new Person[] { p1, p2, p3 };
            return contacts;
        }
    }
}
