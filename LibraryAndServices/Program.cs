using MyClassLibrary;

namespace LibraryAndServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer("Richard", "rich@email.com"),
                new Customer("Stefan", "stefan@email.com"),
                new Customer("Linda", "linda@email.com"),
                new Customer("Alicia", "alicia@email.com"),

            };

            foreach (var c in customers)
            {
                Console.WriteLine($"Name: {c.Name}, Email: {c.Email}");
            }

        }
    }
}