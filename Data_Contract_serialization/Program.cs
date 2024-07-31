using System.Runtime.Serialization;
using System.Xml.Serialization;

class Program
{
	static void Main(string[] args)
	{
		Animal kucing = new Animal("Kucing", 1, "Hitam", TypeLifeAnimal.Darat);
		
		DataContractSerializer serializer = new DataContractSerializer(typeof(Animal));
		
		using(FileStream fs = new FileStream("Animal.json", FileMode.Create))
		{
			serializer.WriteObject(fs, kucing);
		}
		
		Animal kucing2 ;
		using(FileStream fs = new FileStream("Animal.xml", FileMode.Open))
		{
			kucing2 = (Animal) serializer.ReadObject(fs);			
		
		}
		
		Console.WriteLine(kucing2?.getName());
		Console.WriteLine(kucing2?.getAge());
		Console.WriteLine(kucing2?.getColor());
	}
	
}

[DataContract]
public class Animal 
{
	[DataMember]
	private string _name { get; set; }
	[DataMember]
	private int _age { get; set; }
	
	[DataMember]
	private string _color { get; set; }
	public TypeLifeAnimal Type { get; set; }
	public Animal(string name, int age, string color, TypeLifeAnimal type)
	{
		_name = name;
		_age = age;
		_color = color;	
		Type = type;
	}
	public string getName() => _name;
	public int getAge() => _age;
	public string getColor() => _color;
}

public enum TypeLifeAnimal
{
	Darat,
	Air,
	DaratAir
}