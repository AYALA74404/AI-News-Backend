using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ContactsData
    {
        static Person p1 = new Person("1",
              "John",
            "Doe",
             "123-456-7890",
              "l88555@gmail.com",
              Status.Active);

        static Person p2 = new Person("2",
            "Jane",
             "Smith",
            "987-654-3210",
             "a855174@gmail.com",
             Status.Active);

        static Person p3 = new Person("3",
            "Alice",
            "Johnson",
           "555-123-4567",
          "s05823174@gmail.com",
             Status.Active);
        static Person p4 = new Person(
            "1",
            "John",
            "Doe",
            "123-456-7890", "n05823174@gmail.com",
             Status.Active);
     

        public static List<Person> contactsList = new List<Person>() { p1, p2, p3,p4 };

        public static List<Person> GetContacts()
        {
            return contactsList;

        }
    }

}
