using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Data;
namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("GetAllcontacts")]
        public List<Person> GetContact()
        {
          List<Person> contacts = ContactsData.GetContacts();
            return contacts;

        }

        [HttpGet("GetcontactById/{personId}")]
        public ActionResult<Person> GetContactById(string personId)
        {
            List<Person> contacts = ContactsData.GetContacts();
            Person contact = contacts.FirstOrDefault(c => c.PersonId == personId);
            if(contact == null)
                return NotFound();
            return Ok(contact);
        }
        [HttpPost("AddContact")]
        public ActionResult<Person> AddContact(Person newContact)
        {
            List<Person> contacts = ContactsData.GetContacts();
            if(newContact.FirstName == "string" || newContact.FirstName == string.Empty || newContact.Email == string.Empty  ||  newContact.Email == "string")
            {
                return BadRequest("The fields FirstName and Email are required.");
            }
            contacts.Add(newContact);
            return Ok(newContact);
        }
    }
}
