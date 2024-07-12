abstract class Engine 
{
	public string brand;
	
	public Engine(string brand)
	{
		this.brand= brand;
		
	}
	public abstract void Start();
	public abstract void Stop();
	
	public virtual void GenerateRotation()
	{
		Console.WriteLine("Menyala Abangkuh");
	}
	
	
}
class Diesel : Engine
	{
		
		public Diesel(string brand):base(brand)
		{
			
		}
		public override void Start()
		{
			
		}
		public override void Stop()
		{
		   
		}

	public override void GenerateRotation()
	{
		base.GenerateRotation();
		Console.WriteLine("Siap Bapak");
	}


	
	}
	class Electric : Engine
	{
		public Electric(string brand):base(brand)
		{
			
		}
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
		Diesel electric = new("Toyota");
		Car car = new(electric);
		car.engine.GenerateRotation();
		Console.WriteLine(car.engine.brand);
		
	}
}