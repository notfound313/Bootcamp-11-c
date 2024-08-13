using System.Data.Entity;
using SqlLite;

class Program
{
	static void Main(string[] args)
	{
		using (var northwind = new Northwind())
		{
			//Connection Test
			bool status = northwind.Database.CanConnect();
			if (status == false)
			{
				return;
			}
			Console.WriteLine(status);
			//Read All Category
			// ReadAllCategory(northwind);
			
			List<Category> categories = northwind.Categories.Where(a => a.CategoryName.Contains("o")).Include(a => a.Products).ToList();
			foreach (var cat in categories) 
			{
				Console.WriteLine($"{cat.CategoryId} : {cat.CategoryName} = {cat.Description}");
				Console.WriteLine("\tTotal Product = " + cat.Products.Count());
				foreach(var pr in cat.Products) 
				{
					Console.WriteLine($"{pr.ProductId} : {pr.ProductName}");
				}
			}
		}
		
		
	}
	private static void ReadAllCategory(Northwind northwind)
	{
		List<Category> categories = northwind.Categories.ToList();
		foreach (Category cat in categories)
		{
			Console.WriteLine($"{cat.CategoryId} : {cat.CategoryName} = {cat.Description}");
		}
	}
	
}