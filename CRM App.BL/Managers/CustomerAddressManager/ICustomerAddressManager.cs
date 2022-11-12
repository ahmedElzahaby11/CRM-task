

namespace CRM_App.BL;

public interface ICustomerAddressManager
{
    List<CustomerAddressReadDTO> GetCustomerAddressByCustomerId(Guid id);
    CustomerAddressReadDTO AddAddressToCustomer(CustomerAddressWriteDTO customerAddressDTO);

}
