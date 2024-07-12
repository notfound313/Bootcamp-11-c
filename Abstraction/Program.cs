abstract class Engine 
{
	public string brand;
	public abstract void Start();
	public abstract void Stop();
	
	public void GenerateRotation()
	{
		Console.WriteLine("Menyala Abangkuh");
	}
	
	
}
class Diesel : Engine
	{
		public override void Start()
		{
			
		}
		public override void Stop()
		{
		   
		}

		
	}
	class Electric : Engine
	{
		public override void Start()
		{
			
		}
		public override void Stop()
		{
		   
		}

		
	}
class Car 
{
	public Engine engine;
	public Car(Engine engine)
	{
		this.engine = engine;
	}
	
	
}

class Program 
{
	static void Main()
	{
		Diesel electric = new();
		Car car = new(electric);
		car.engine.GenerateRotation();
		
	}
}