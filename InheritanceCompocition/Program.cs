using BuildCar;
using ChildEngine;
using Component;
class Program
{
	
	static void Main()
	{
		Engine engine = new Engine();
		Car car = new Car(engine);
		DieselEngine diesel = new DieselEngine();
		
		car.ReplaceEngine(diesel);
		
		
	}
	
}