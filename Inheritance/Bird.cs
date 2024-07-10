using ParentClass;

namespace ChildClass;

public class Bird : Animal
{
	public string wing;

	public Bird(string name, string race,string wing) : 
	base(name, race)
	{
		this.wing = wing;

	}
	public void Fly()
	{
		Console.WriteLine("Flay to the moon");
	}
}
