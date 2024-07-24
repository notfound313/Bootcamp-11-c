using System.Diagnostics;

using System.Text;

class Program
{
/// <summary>
 /// The Main method of the Program class. This method generates a sequence of numbers from 1 to 15, and for each number:
 /// - If the number is divisible by 3, it prints "Foo"
 /// - If the number is divisible by 5, it prints "Bar"
 /// - If the number is divisible by both 3 and 5, it prints "FooBar"
 /// - Otherwise, it prints the number itself
 /// The method also measures the time it takes to execute the loop and prints the elapsed time in milliseconds.
 /// </summary>
 	static void Main(string[] args)
	{
		Stopwatch sw = new();
		sw.Start();
		int N = 15_000;
		StringBuilder output = new StringBuilder();
		//buat dict untuk foobar
		Dictionary<int, string> foobarDict = new Dictionary<int, string>
			{
				{3, "Foo"},
				{5, "Bar"},
				{15, "FooBar"}

			};
		for (int i = 1; i <= N; i++)
		{


			if (i % 3 == 0)
				output.Append("Foo");
			if (i % 5 == 0)
				output.Append("Bar");

			// Cetak hasil
			Console.WriteLine(output.Length > 0 ? output.ToString() : i.ToString());
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
	}
}
