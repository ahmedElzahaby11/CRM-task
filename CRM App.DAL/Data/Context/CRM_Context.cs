

using Microsoft.EntityFrameworkCore;

namespace CRM_App.DAL;

public class CRM_Context:DbContext
{
	public DbSet<Product> Products { get; set; }
	public DbSet<Customer> Customers { get; set; }
	public DbSet<CustomerAddress> customerAddresses { get; set; }
	public DbSet<OrderDetails> orderDetails { get; set; }
	public DbSet<OrderHeader> orderHeaders { get; set; }
	public DbSet<OrderShippingAddress> orderShippingAddresses { get; set; }
	public DbSet<OrderBillingAddress> orderBillingAddresses { get; set; }
	public CRM_Context(DbContextOptions<CRM_Context> options):base(options)
	{
		
	}
}
