class Animal 
{
	public  string name ;
	public int age;
	
	public virtual void MakeSound()
	{
		Console.WriteLine("...");
	}
	
}

class Cat : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Meong");
	}
}

class Program 
{
	static void Main()
	{
		Animal animal = new();
		Cat cat = new();
		cat.MakeSound();
		animal.MakeSound();
		 
	}
}