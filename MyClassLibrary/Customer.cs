namespace MyClassLibrary
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public int? PostNumber { get; set; }
        public string? City { get; set; }
        public bool? IsVIP { get; set; }

        public Customer(string name, string email)
        {
            CustomerId = Guid.NewGuid();
            Name = name;
            Email = email;
        }
    }
}