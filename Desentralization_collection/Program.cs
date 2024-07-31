using System.Xml.Serialization;

class Program
{
	static void Main(string[] args)
	{
	
		List<Animal> list = new List<Animal>();
	
		XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>));
		
		using(FileStream fs = new FileStream("AnimalPublic.txt", FileMode.Open))
		{
			list = (List<Animal>)serializer.Deserialize(fs);
		}
		
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