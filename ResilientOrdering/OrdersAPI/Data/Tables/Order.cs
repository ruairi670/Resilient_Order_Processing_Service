namespace OrdersAPI.Data.Tables
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public List<Guid> ProductIds { get; set; } = new List<Guid>();

        public DateTime OrderDate { get; set; }

        public DateTime DateToBeDelivered { get; set; }

        public bool Processed {  get; set; }

        public bool OutForDelivery { get; set; }

        public bool Delivered { get; set; }

        #region Navigation Properties

        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

        #endregion


        public Order()
        {
            Id = Guid.NewGuid();
        }

        public Order (Guid customerId, List<Guid> productIds, DateTime orderDate, DateTime dateToBeDelivered)
            : this()
        {
            CustomerId = customerId;
            ProductIds = productIds;
            OrderDate = orderDate;
            DateToBeDelivered = dateToBeDelivered;

            Processed = false;
            OutForDelivery = false;
            Delivered = false;
        }
    }
}
