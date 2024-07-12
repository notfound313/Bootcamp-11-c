class Car 
{
	public int price;
	public Car(int price)
	{
		this.price = price;
	}
	
}

class Program 
{
	static void Main()
	{
		Car car = new(4);
		Car car2 = car;
		car2.price +=4;
		//refrence type
		Console.WriteLine(car.price);//8
		Console.WriteLine(car2.price);//8
		
		
	}
}
