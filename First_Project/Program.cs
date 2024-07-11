class Home
{
	public static int count = 0;
	public  int total = 5;
	public Home()
	{
		total += count++;
	}
	
	public void Replace(int door){
		total += door;
	}
}

class Program
{
	static void Main()
	{
		int num = 6;
		Home home = new Home();
		// home.Replace(num);
		Console.WriteLine(home.total);
		
		
		// Home home1 = new Home();
		// home1.Replace(num);
		// Console.WriteLine(home1.total);
		
	}
}