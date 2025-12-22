namespace OrdersAPI.Data.Tables
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int QuantityInInventory { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public Product(string name, string description, decimal price, int quantityInInventory)
            : this()
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInInventory = quantityInInventory;
        }
    }
}
