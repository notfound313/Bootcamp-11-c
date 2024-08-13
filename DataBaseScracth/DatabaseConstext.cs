using Microsoft.EntityFrameworkCore;

namespace DataBaseScracth;

public class DatabaseConstext : DbContext
{
	public DbSet<Category> Categories {get; set;}
	public DbSet<Product> Products {get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=apapun;Username=postgres;Password=123");
	}



}
