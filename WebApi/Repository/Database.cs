using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Repository;

public class Database : DbContext
{
	public Database(DbContextOptions<Database> options) : base(options) { }
	public DbSet<Models.Product> Products { get; set; }
	public DbSet<Models.Category> Categories { get; set; }
	
}
