namespace OrdersAPI.Data.Tables
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int QuantityInInventory { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string description, decimal price, int quantityInInventory)
            : this(id)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInInventory = quantityInInventory;
        }

        public Product(int id)
        {
            Id = id;
        }
    }
}
