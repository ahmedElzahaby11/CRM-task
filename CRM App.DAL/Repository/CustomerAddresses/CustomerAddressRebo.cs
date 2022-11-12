

namespace CRM_App.DAL;

public class CustomerAddressRebo:GenericRebo<CustomerAddress>,ICustomerAddressRebo
{
	private readonly CRM_Context _context;
	public CustomerAddressRebo(CRM_Context context):base(context)
	{
		_context = context;
	}

	public List<CustomerAddress> GetCustomerAddressesById(Guid? customerId)
	{
		var dbcustomer = _context.customerAddresses.Where(x => x.CustomerId == customerId).ToList();
		return dbcustomer;
    }
}
