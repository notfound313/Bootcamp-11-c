using System.Xml.Serialization;

class Program
{
	static void Main(string[] args)
	{
		Animal kucing = new Animal("Kucing", 1, "Hitam", TypeLifeAnimal.Darat);
		XmlSerializer serializer = new XmlSerializer(typeof(Animal));
		
		using(FileStream fs = new FileStream("AnimalPublic.txt", FileMode.Create))
		{
			serializer.Serialize(fs, kucing);
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