class Program
{
	static void Main()
	{
		Console.WriteLine(Animal.age3);
		Animal an = new(14);
		Console.WriteLine(an.age2);
	}
	
	
}

class Animal 
{
	public int age;
	public readonly int age2;
	public const int age3 = 12;
	
	public Animal(int age)
	{
		age2 = age;
		
	}
	
}