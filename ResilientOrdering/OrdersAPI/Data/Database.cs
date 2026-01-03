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
            Orders.Add(new Order(1)
            {
                CustomerId = Customers.ElementAt(0).Id,
                ProductIds = new List<int>() { Products.ElementAt(0).Id, Products.ElementAt(2).Id },
                DateToBeDelivered = DateTime.Now.AddDays(1)
            });

            Orders.Add(new Order(2)
            {
                CustomerId = Customers.ElementAt(1).Id,
                ProductIds = new List<int>() { Products.ElementAt(2).Id, Products.ElementAt(3).Id },
                DateToBeDelivered = DateTime.Now.AddDays(5)
            });

            Orders.Add(new Order(3)
            {
                CustomerId = Customers.ElementAt(2).Id,
                ProductIds = new List<int>() { Products.ElementAt(1).Id, Products.ElementAt(2).Id },
                DateToBeDelivered = DateTime.Now.AddDays(13)
            });

            Orders.Add(new Order(4)
            {
                CustomerId = Customers.ElementAt(3).Id,
                ProductIds = new List<int>() { Products.ElementAt(0).Id, Products.ElementAt(1).Id },
                DateToBeDelivered = DateTime.Now.AddDays(21)
            });
        }

        private void SetUpCustomers()
        {
            Customers.Add(new Customer(1)
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "JohnD@email.com",
                PrimaryAddress = "123 Test Street, CPU Vile"
            });

            Customers.Add(new Customer(2)
            {
                FirstName = "Jane",
                LastName = "Dun",
                Email = "JDun@email.com",
                PrimaryAddress = "12 Test Ave, CPU Vile"
            });

            Customers.Add(new Customer(3)
            {
                FirstName = "Frank",
                LastName = "Windows",
                Email = "FWin@email.com",
                PrimaryAddress = "43 RAM Drive, CPU Vile"
            });

            Customers.Add(new Customer(4)
            {
                FirstName = "John",
                LastName = "Billard",
                Email = "JB@email.com",
                PrimaryAddress = "2 In Out Boulevard, Testland"
            });

            Customers.Add(new Customer(5)
            {
                FirstName = "Sarah",
                LastName = "Bus",
                Email = "SBus@email.com",
                PrimaryAddress = "54 Terminal Street, lower DLS"
            });
        }

        private void SetUpProducts()
        {
            Products.Add(new Product(1)
            {
                Name = "Initilisor 5000x",
                Description = "Computer initilisor, wakey wakey machine",
                Price = Decimal.Parse("99.99"),
                QuantityInInventory = 100
            });

            Products.Add(new Product(2)
            {
                Name = "Quantum Entangler",
                Description = "Entangales quantum space into a custom sized cube - always wear goggles! (Goggles not included)",
                Price = Decimal.Parse("599.99"),
                QuantityInInventory = 10
            });

            Products.Add(new Product(3)
            {
                Name = "Flux Maxim",
                Description = "Black hole PSU, pulls power directly from Dark Space",
                Price = Decimal.Parse("1099.99"),
                QuantityInInventory = 25
            });

            Products.Add(new Product(4)
            {
                Name = "16K HDMI Cable",
                Description = "16 times the detail!",
                Price = Decimal.Parse("49.99"),
                QuantityInInventory = 250
            });

            Products.Add(new Product(5)
            {
                Name = "The 'Brain' Circuit",
                Description = "Definitely not a brain hooked up to a mother board",
                Price = Decimal.Parse("1599.99"),
                QuantityInInventory = 57
            });
        }
    }
}
