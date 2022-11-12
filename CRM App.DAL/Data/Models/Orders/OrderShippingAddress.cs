

using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_App.DAL;

public class OrderShippingAddress
{
    public Guid OrderShippingAddressId { get; set; }
    public string AddressLine1 { get; set; } = "";
    public string AddressLine2 { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string Country { get; set; } = "";
    [ForeignKey("OrderHeader")]
    public Guid OrderId { get; set; }
    public OrderHeader? orderHeader { get; set; }
}
