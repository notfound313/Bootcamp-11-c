using ComponentCar;
class Car 
{
	public Engine engine;
	public Tire tire;
	
	public Car(Engine engine, Tire tire)
	{
		this.engine = engine;
		this.tire = tire;
		
	}
	
}

class Program 
{
	static void Main()
	{
		Engine engine = new Engine("V2","Gh",1);
		Tire tire = new Tire("GH", 89);
		Engine engine1 = new Engine("V2","Toyota",1);
		
		Car car = new Car(engine1,tire);
		car.engine.Start();
		
		
	}
}
