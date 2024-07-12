interface IActionAnimal 
{
	void MakeSound();
	void Eat();
	void Poop();
}

 abstract class Animal  
{
	public string name;
	public int age;
	public string race;
	public string gender;
	
	public Animal(string name, int age)
	{
		this.name = name;
		this.age = age;
		
	}
	public Animal()
	{
		
		
	}
	
}

class Bird : Animal, IActionAnimal
{
	public string wing;
	public Bird(string name, int age, string wing):base(name, age)
	{
		this.wing = wing;
	}
	public void MakeSound()
	{
		Console.WriteLine($"{name} singing Kiwkiw");
	}
		public void Eat()
	{
		Console.WriteLine($"{name} Makan ulet");
	}
	public void Poop()
	{
		Console.WriteLine($"{name}proot");
	}
	
	
}

class Cat : Animal, IActionAnimal
{
	public string mostache;
	public Cat(string name, int age, string mostache):base(name, age)
	{
		this.mostache = mostache;
	}
	public void MakeSound()
	{
		Console.WriteLine($"{name} say Meonngggrrrrr");
	}
	public void Eat()
	{
		Console.WriteLine($"{name} eatng Rats");
	}
	public void Poop()
	{
		Console.WriteLine($"{name} Poooop");
	}
	
}


class Program 
{
	static void Main()
	{
		Bird bird = new Bird("joni",15,"bulu");
		bird.MakeSound();
		Cat cat = new Cat("Chika",15,"bulu");
		bird.Eat();
		
		cat.MakeSound();
		cat.Eat();
		
		
	}
}