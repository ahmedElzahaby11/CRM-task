namespace CRM_App.DAL;

public class CustomerRebo:GenericRebo<Customer>,ICustomerRebo
{
	public CustomerRebo(CRM_Context context):base(context)
	{

	}

}
