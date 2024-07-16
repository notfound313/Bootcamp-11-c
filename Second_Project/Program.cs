using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		Stopwatch sw = new();
		sw.Start();
		int N = 1000_000; // Ubah sesuai kebutuhan

		for (int i = 1; i <= N; i++)
		{
			StringBuilder output = new StringBuilder();

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
