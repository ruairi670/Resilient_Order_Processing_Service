using DataModels.Data.DataTransferObjects.Base;

namespace DataModels.Data.DataTransferObjects.CustomerDTOs
{
    public class CustomerDTO : BaseDTO
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PrimaryAddress { get; set; } = string.Empty;
    }
}
