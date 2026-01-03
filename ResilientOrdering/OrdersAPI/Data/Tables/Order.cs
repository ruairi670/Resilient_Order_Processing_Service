namespace OrdersAPI.Data.Tables
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public List<int> ProductIds { get; set; } = new List<int>();

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
        }

        public Order (int customerId, List<int> productIds, DateTime orderDate, DateTime dateToBeDelivered)
        {
            CustomerId = customerId;
            ProductIds = productIds;
            OrderDate = orderDate;
            DateToBeDelivered = dateToBeDelivered;

            Processed = false;
            OutForDelivery = false;
            Delivered = false;
        }

        public Order(int id, int customerId, List<int> productIds, DateTime orderDate, DateTime dateToBeDelivered) : this(id)
        {
            CustomerId = customerId;
            ProductIds = productIds;
            OrderDate = orderDate;
            DateToBeDelivered = dateToBeDelivered;

            Processed = false;
            OutForDelivery = false;
            Delivered = false;
        }


        /// <summary>
        /// Constructor for testing purposes, need to keep record of Ids for testing getter methods
        /// </summary>
        /// <param name="id"></param>
        public Order(int id)
        {
            Id = id;
        }
    }
}
