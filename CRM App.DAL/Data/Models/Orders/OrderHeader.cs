

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_App.DAL;
public class OrderHeader
{
    [Key]
    public Guid OrderId { get; set; }
    [Required]
    public string SalesOrderStatus { get; set; } = "";
    [Required]
    public DateTime OrderDate { get; set; }
    [NotMapped]
    public decimal OrderTax { get; set; }
    [Required]
    public decimal OrderSubTotal { get; set; }
    [NotMapped]
    public decimal OrderGrandTotal { get; set; }

    public Customer? Customer { get; set; }
    public Guid CustomerId { get; set; }
}
