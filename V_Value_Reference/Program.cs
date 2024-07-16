//value type
// reference type

class Program
{
	static void Main()
	{
		int a = 3;
		//reference type
		Car car = new();
		car.price = 3;
		
		//value type
		Adder add = new();
		add.Add(car);
		Console.WriteLine(car.price);
		
	}
}

class Adder
{
	//value type
	// public int Add(int x)
	
	// {
	// 	return x++;
	// }
	
	//reference type
	public int Add(Car x)
	{
		return x.price++;
	}
}

class Car 
{
	public int price;
}