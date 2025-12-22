namespace OrdersAPI.Data.Tables
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PrimaryAddress { get; set; } = string.Empty;

        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public Customer (string firstName, string lastName,  string email, string primaryAddress)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PrimaryAddress = primaryAddress;
        }
    }
}
