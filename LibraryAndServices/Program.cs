using MyClassLibrary;

namespace LibraryAndServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstCustomer = new 
                Customer("Richard", "rich@email.com");
            Console.WriteLine(firstCustomer.Name);
            Console.WriteLine(firstCustomer.Email);
        }
    }
}