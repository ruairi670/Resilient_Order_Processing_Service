using OrdersAPI.Data.Tables;

namespace OrdersAPI.Data
{
    public class Database
    {
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public Database()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
            Customers = new HashSet<Customer>();

            SetUpProducts();
            SetUpCustomers();
            SetUpOrders();
        }

        private void SetUpOrders()
        {
            Orders.Add(new Order(Guid.Parse("146fd72c-b81c-4c45-b4d5-aece715313cf"))
            {
                CustomerId = Customers.ElementAt(0).Id,
                ProductIds = new List<Guid>() { Products.ElementAt(0).Id, Products.ElementAt(2).Id }
            });

            Orders.Add(new Order(Guid.Parse("958b482f-6552-4924-a9f8-74aefe104216"))
            {
                CustomerId = Customers.ElementAt(1).Id,
                ProductIds = new List<Guid>() { Products.ElementAt(2).Id, Products.ElementAt(3).Id }
            });

            Orders.Add(new Order(Guid.Parse("8f32d954-dd18-4a7e-92d7-2259feb66b10"))
            {
                CustomerId = Customers.ElementAt(2).Id,
                ProductIds = new List<Guid>() { Products.ElementAt(1).Id, Products.ElementAt(2).Id }
            });

            Orders.Add(new Order(Guid.Parse("170480b0-f3f3-4c70-b2cc-acd449b8bff1"))
            {
                CustomerId = Customers.ElementAt(3).Id,
                ProductIds = new List<Guid>() { Products.ElementAt(0).Id, Products.ElementAt(1).Id }
            });
        }

        private void SetUpCustomers()
        {
            Customers.Add(new Customer()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "JohnD@email.com",
                PrimaryAddress = "123 Test Street, CPU Vile"
            });

            Customers.Add(new Customer()
            {
                FirstName = "Jane",
                LastName = "Dun",
                Email = "JDun@email.com",
                PrimaryAddress = "12 Test Ave, CPU Vile"
            });

            Customers.Add(new Customer()
            {
                FirstName = "Frank",
                LastName = "Windows",
                Email = "FWin@email.com",
                PrimaryAddress = "43 RAM Drive, CPU Vile"
            });

            Customers.Add(new Customer()
            {
                FirstName = "John",
                LastName = "Billard",
                Email = "JB@email.com",
                PrimaryAddress = "2 In Out Boulevard, Testland"
            });

            Customers.Add(new Customer()
            {
                FirstName = "Sarah",
                LastName = "Bus",
                Email = "SBus@email.com",
                PrimaryAddress = "54 Terminal Street, lower DLS"
            });
        }

        private void SetUpProducts()
        {
            Products.Add(new Product()
            {
                Name = "Initilisor 5000x",
                Description = "Computer initilisor, wakey wakey machine",
                Price = Decimal.Parse("99.99"),
                QuantityInInventory = 100
            });

            Products.Add(new Product()
            {
                Name = "Quantum Entangler",
                Description = "Entangales quantum space into a custom sized cube - always wear goggles! (Goggles not included)",
                Price = Decimal.Parse("599.99"),
                QuantityInInventory = 10
            });

            Products.Add(new Product()
            {
                Name = "Flux Maxim",
                Description = "Black hole PSU, pulls power directly from Dark Space",
                Price = Decimal.Parse("1099.99"),
                QuantityInInventory = 25
            });

            Products.Add(new Product()
            {
                Name = "16K HDMI Cable",
                Description = "16 times the detail!",
                Price = Decimal.Parse("49.99"),
                QuantityInInventory = 250
            });

            Products.Add(new Product()
            {
                Name = "The 'Brain' Circuit",
                Description = "Definitely not a brain hooked up to a mother board",
                Price = Decimal.Parse("1599.99"),
                QuantityInInventory = 57
            });
        }
    }
}
