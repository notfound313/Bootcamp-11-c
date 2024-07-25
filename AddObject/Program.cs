class Program
{
	static void Main()
	{
		Animal animal = new Animal();
		animal.name = "Kucing";
		Console.WriteLine(animal);
	}
	
	
}

class Animal 
{
	public string name;

    public override string ToString() => name;
}