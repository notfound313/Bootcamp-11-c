using Microsoft.EntityFrameworkCore; // DbContext, DbContextOptionsBuilder 
namespace SqlLite; // this manages the connection to the database 
public class Northwind : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=./Northwind.db");
	}


	// string path = Path.Combine( Environment.CurrentDirectory, "Northwind.db"); 
	// string connection = $"Filename={path}"; 
	// optionsBuilder.UseSqlite(connection); 
}

