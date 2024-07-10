namespace ComponentCar;

public class Engine
{
	public string engineType;
	public string engineBrand;
	public int engineSize;
	
	public Engine(string engineType, string engineBrand, int engineSize)
	{
		this.engineType = engineType;
		this.engineSize = engineSize;
		this.engineBrand = engineBrand;
	}
	
	public void Start()
	{
		Console.WriteLine($"Start {engineBrand}");
	}
}
