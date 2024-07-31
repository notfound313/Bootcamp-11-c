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
		XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>));
		
		using(FileStream fs = new FileStream("AnimalPublic.txt", FileMode.Create))
		{
			serializer.Serialize(fs, list);
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