namespace WebApplication1.Models
{
    public class Person
    {
        public Person(string name, string email)
        {
            Name = name;
            Email = email;
            IsActive = true;
        }

        public Person(string name, string phone, string email, bool isActive)
        {
            Name = name;
            Phone = phone;
            Email = email;
            IsActive = isActive;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

    }
}
