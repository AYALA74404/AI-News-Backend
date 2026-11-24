using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
   public enum Status
    {
        Inactive,
        Active
       
    }
    public class Person
    {
        public Person(string personId, string firstName, string lasttName, string phone, string email, Status state)
        {
            PersonId = personId;
            FirstName = firstName;
            LasttName = lasttName;
            Phone = phone;
            Email = email;
            State = state;
        }

        public string PersonId { get; set; } = string.Empty;
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = string.Empty;
        public string LasttName { get; set; }= string.Empty;
        public string Phone { get; set; }= string.Empty;

        [Required(ErrorMessage = "Email is required")]
        //[EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        public Status State { get; set; } = Status.Inactive;

    }
}
