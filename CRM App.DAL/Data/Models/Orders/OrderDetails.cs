


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_App.DAL;

public class OrderDetails
{
    [Key]
    public Guid LineOrderNo { get; set; }
    [Required]
    public decimal LinePrice { get; set; }
    [Required]
    public decimal LineOrderQty { get; set; }
    [Required]
    public decimal LineTaxAmount { get; set; }
    [ForeignKey("Product")]
    public Guid ProductId { get; set; }
    [ForeignKey("OrderHeader")]
    public Guid OrderId { get; set; }
    public Product? Product { get; set; }
    public OrderHeader? OrderHeader { get; set; }
}
