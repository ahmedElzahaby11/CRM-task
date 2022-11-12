using System.ComponentModel.DataAnnotations;

namespace CRM_App.DAL;
public class Customer
{
    public Guid CustomerId { get; set; }
    public string CustomerCode { get; set; } = "";
    [Required]
    public string CustomerFirstName { get; set; } = "";
    [Required]
    public string CustomerLastName { get; set; } = "";
    [Required]
    public string CustomerEmail { get; set; } = "";
    public string CustomerPhone { get; set; } = "";
    public ICollection<CustomerAddress> Addresses { get; set; } = new HashSet<CustomerAddress>();
    public ICollection<OrderHeader> OrderHeaders { get; set; } = new HashSet<OrderHeader>();
}
