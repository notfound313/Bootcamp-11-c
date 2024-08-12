using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
		// int num = 6;
		// Home home = new Home();
		// // home.Replace(num);
		// Console.WriteLine(home.total);
		// string [,] halo = new [8,8];
		// string king = "king";
		// halo[1][3] = king//nama color player/
		
		// public List<string> GetAllList(Location)
		// {
		// 	List<string> list = new List<string>();
		// 	cordinate x = 1 y=2
		// 	cordinate X+1 y+1
		// 	list.Addcordinate
		// 	return list;
		// }
		List<string> list = new List<string>(){"hajaj","hajaj"};
		foreach (var item in list)
		{
			Console.WriteLine(item);
			
		}
		
		// Home home1 = new Home();
		// home1.Replace(num);
		// Console.WriteLine(home1.total);
		
	}
}