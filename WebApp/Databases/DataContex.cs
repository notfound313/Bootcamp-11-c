using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;

public class DataContex : DbContext
{
	public DataContex(DbContextOptions<DataContex> options) : base(options)
	{
		
	}
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
}
