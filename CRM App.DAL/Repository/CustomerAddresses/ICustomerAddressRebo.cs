
namespace CRM_App.DAL;

public interface ICustomerAddressRebo:IGenericRebo<CustomerAddress>
{
  List<CustomerAddress>GetCustomerAddressesById(Guid? customerId);
}
