using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

class Program
{
	static void Main(string[] args)
	{
		Animal kucing = new Animal("Kucing", 1, "Hitam", TypeLifeAnimal.Darat);
		Animal ikan = new Animal("Ikan", 1, "Hitam", TypeLifeAnimal.Air);
		Animal burung = new Animal("Burung", 1, "Putih", TypeLifeAnimal.Darat);
		
		List<Animal> list = new List<Animal>();
		list.Add(kucing);
		list.Add(ikan);
		list.Add(burung);
		
		
		using(FileStream fs = new FileStream("AnimalPublic.json", FileMode.Create))
		{
			string serializer = JsonSerializer.Serialize(list);
			byte[] bytes = Encoding.UTF8.GetBytes(serializer);
			fs.Write(bytes, 0, bytes.Length);
			
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