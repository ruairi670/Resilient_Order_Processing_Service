using DataModels.Data.DataTransferObjects.Base;

namespace DataModels.Data.DataTransferObjects.CustomerDTOs
{
    public class EditCustomerDTO : BaseDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PrimaryAddress { get; set; } = string.Empty;
    }
}
