using OrdersAPI.Data.DataTransferObjects.Base;

namespace OrdersAPI.Data.DataTransferObjects.CustomerDTOs
{
    public class NewCustomerDTO : BaseDTO
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PrimaryAddress { get; set; } = string.Empty;
    }
}
