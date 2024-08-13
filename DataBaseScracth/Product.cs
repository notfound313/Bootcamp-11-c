using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseScracth;

public class Product
{
	public int ProductId { get; set; }
	[Column(TypeName = "varchar"), MaxLength(40)]
	public string ProductName { get; set; }	
	[Column(TypeName ="int")]
	public int CategoryId { get; set; }
	
	[Column(TypeName ="varchar"), MaxLength(20)]
	public string QuantityPerUnit { get; set; }
	[Column(TypeName ="money"), DefaultValue(100)]
	public decimal UnitPrice { get; set; }
	[Column(TypeName ="smallint"), DefaultValue(1)]
	public short UnitsInStock { get; set; }
	[Column(TypeName ="smallint"), DefaultValue(0)]
	public short UnitsOnOrder { get; set; }
	[Column(TypeName ="smallint"), DefaultValue(1)]
	public short ReorderLevel { get; set;}

	public bool DisContinued { get; set;}
	
	
}
