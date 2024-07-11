class Parent
{
	// public void Greating()
	// {
	// 	Console.WriteLine("tidak boleh");
	// }
	public virtual void Greating()
	{
		Console.WriteLine("tidak boleh");
	}
}

class Child : Parent
{
	
	// Method Hiding ditandai dengan kata 'new'
	public new void Greating()
	{
		Console.WriteLine("Bapak hiding");
	} 
}

class Program 
{
	static void Main()
	{
		Parent p = new Child();
		Child c = new Child();
		
		p.Greating();
		c.Greating();
	}
}