
namespace CRM_App.BL;

public interface ICustomerManager
{
    public List<CustomerReadDTO> GetAllCustomer();
    CustomerReadDTO GetCustomerById(Guid id);
    CustomerReadDTO AddCustomer(CustomerWriteDTO customer);
    bool UpdateCustomer(CustomerWriteDTO customer);

}
