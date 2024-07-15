interface IAnimal 
{
	string Name {get; set;}
	int Age {get; set;}
	
	void Eat();
	void Poop();
	void MakeSound();
}

class Bird : IAnimal 
{
	public string Name {get; set;}
	public int Age {get; set;}
	
	public void MakeSound()
	{
		Console.WriteLine($"{Name} singing Kiwkiw");
	}
		public void Eat()
	{
		Console.WriteLine($"{Name} Makan ulet");
	}
	public void Poop()
	{
		Console.WriteLine($"{Name} proot");
	}
	
	
}

class Program 
{
	static void Main(){
		//explicit
		float a = 78.9999999f;
		int b = (int)Math.Ceiling(a);
		
		//implicit
		int d = 89;
		double f = d;
		
		
		Bird bird = new();
		bird.Name = "wahyu";
		Console.WriteLine(b);
	
	}
}