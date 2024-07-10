using ParentClass;

namespace ChildClass;

public class Bird : Animal
{
	public string wing;

	public Bird(string name, string race, int age, string gender,string wing) : 
	base(name, race, age, gender)
	{
		this.wing = wing;

	}
	public void Fly()
	{
		Console.WriteLine("Flay to the moon");
	}
}
