
class Program
{
	static void Main()
	{
		int a = 3;
		
		Car car = new();
		car.price = 3;
		
		//ref
		Adder add = new();
		// add.Add(ref a);
		Console.WriteLine(car.price);
		
		//out
		// add.Add(out a);
		
		//
		add.Add(in a);
	}
}

class Adder
{
	//ref
	// public int Add(ref int x)
	// {
	// 	return x++;
	// }
	
	//out 
	// public void Add(out int x)
	// {
	// 	x=6;
		
	// }
	public void Add(in int x)
	{
		
		
	}
	
}
	

class Car 
{
	public int price;
}