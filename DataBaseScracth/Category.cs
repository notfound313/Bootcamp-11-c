using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseScracth;

public class Category
{
	public int CategoryId { get; set; }
	
	[Column(TypeName = "varchar"), MaxLength(15)]
	public string CategoryName { get; set; }
	
	[Column(TypeName = "text")]
	public string Description { get; set; }
	
	public string Picture { get; set; }
	public IEnumerable<Product> Products {get; set;}
	public Category() 
	{
		Products = new HashSet<Product>();
	}
}
