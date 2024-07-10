namespace ComponentHP;

public class CPU
{
	public int countCore;
	public string version;
	public string brand;
	
	public CPU(int countCore, string version, string brand)
	{
		this.countCore= countCore;
		this.version = version;
		this.brand = brand;
	}
	
	public void PowerOn()
	{
		Console.WriteLine($"Power on.....by {brand}");
	}
}
