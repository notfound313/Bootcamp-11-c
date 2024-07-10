namespace BuildCar;

using Component;

public class Car
{
	public Engine engine;
	
	public Car(Engine engine)
	{
		this.engine =engine;
	}
	
	public void ReplaceEngine(Engine eng)
	{
		engine = eng;
	}
	
	
}
