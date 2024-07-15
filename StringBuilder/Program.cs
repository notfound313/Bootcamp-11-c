using System.Diagnostics;
using System.Text;

class Program
{
	static void Main()
	{
		Stopwatch sw = new();
		sw.Start();
		int iteration = 10_000;
		StringBuilder sb = new("Hello");
		for(int i = 0; i < iteration;i++)
		{
			sb.Append("World");
			sb.Append("! ! !");
			sb.Replace("o","i");
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
		
		
	}
	
}