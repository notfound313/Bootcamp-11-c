namespace ParentClass;

public class Animal
{
	public string name;
	public string race;
	public int age;
	public string gender;
	
	public Animal(string name, string race, int age, string gender)
	{
		this.name = name;
		this.race = race;
		this.age = age;
		this.gender = gender;
		
	}
	public Animal(string name, string race)
	{
		this.name = name;
		this.race = race;
		
		
	}
	
	public void Eat()
	{
		Console.WriteLine("Im Eating");
	}
	
	public void Poop()
	{
		Console.WriteLine("Im Poop");
		
	}
	
}
