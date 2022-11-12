
namespace CRM_App.DAL;

public class CustomerAddress
{
    public Guid CustomerAddressId { get; set; }
    public string AddressLine1 { get; set; } = "";
    public string AddressLine2 { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public bool ShippimgAddressFlag { get; set; }
    public bool BillingAddressFlag { get; set; }
    public Customer? customer { get; set; }
    public Guid? CustomerId { get; set; }
    
}
