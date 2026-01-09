using DataModels.Data.DataTransferObjects.CustomerDTOs;
using DataModels.Data.Tables;

namespace OrdersAPI.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerDTO ToCustomerDTO(Customer customer)
        {
            CustomerDTO dto = new CustomerDTO();

            dto.Id = customer.Id;
            dto.FirstName = customer.FirstName;
            dto.LastName = customer.LastName;
            dto.Email = customer.Email;
            dto.PrimaryAddress = customer.PrimaryAddress;

            return dto;
        }
    }
}
