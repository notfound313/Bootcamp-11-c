using ParentClass;

namespace ChildClass;

public class Cat : Animal
{
	public string mostache;
	public Cat(string name, string race, int age, string gender,string mostache) : 
	base(name, race, age, gender)
	{
		this.mostache = mostache;
	}
	
	public void Meow()
	{
		Console.WriteLine("Meoow");
	}
}
