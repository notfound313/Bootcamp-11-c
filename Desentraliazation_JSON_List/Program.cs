using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

class Program
{
	static void Main(string[] args)
	{
		List<Animal> list = new List<Animal>();
		string json;
		
		using(FileStream fs = new FileStream("AnimalPublic.json", FileMode.Open))
		{
			byte[] bytes = new byte[fs.Length];
			fs.Read(bytes,0,bytes.Length);
			json = Encoding.UTF8.GetString(bytes);
			
		}
		list = JsonSerializer.Deserialize<List<Animal>>(json);
		
		foreach (var item in list)
		{
			Console.WriteLine($"Nama: {item.Name} Type: {item.Type} Color: {item._Color} Age: {item.Age}");
			
		}
		
		
		
	}
	
}
public class Animal 
{
	public string Name { get; set; }
	public int Age { get; set; }
	public string _Color { get; set; }
	public TypeLifeAnimal Type { get; set; }
	public Animal(string name, int age, string color, TypeLifeAnimal type)
	{
		Name = name;
		Age = age;
		_Color = color;	
		Type = type;
	}
	public Animal(){}
}

public enum TypeLifeAnimal
{
	Darat,
	Air,
	DaratAir
}