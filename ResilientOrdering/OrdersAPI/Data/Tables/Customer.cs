namespace OrdersAPI.Data.Tables
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PrimaryAddress { get; set; } = string.Empty;

        public Customer()
        {
        }

        public Customer (string firstName, string lastName,  string email, string primaryAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PrimaryAddress = primaryAddress;
        }

        public Customer(int id, string firstName, string lastName, string email, string primaryAddress)
            : this(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PrimaryAddress = primaryAddress;
        }

        public Customer(int id)
        {
            Id = id;
        }
    }
}
