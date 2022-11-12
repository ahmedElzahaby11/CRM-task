

using CRM_App.DAL;
using System.ComponentModel.DataAnnotations;

namespace CRM_App.BL;
public class CustomerReadDTO
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
}
