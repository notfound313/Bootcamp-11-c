using System.Numerics;
using System.Runtime.CompilerServices;

class Home
{
	public static int count = 0;
	public  int total = 1;
	public Home()
	{
		total+=count++;
	}
	
	public void Replace(int door){
		total += door+count;
	}
	public static int GetCount()
	{
		return count;
	}
}

class Program
{
	static void Main()
	{
		int num = 6;
		Home home = new Home();
		Console.WriteLine(home.total);
		Home home1 = new Home();
		home1.Replace(num);
		home.Replace(num);
		Console.WriteLine(home1.total);
	
		Console.WriteLine(home.total);
		Console.WriteLine(Home.GetCount());
		
	}
}