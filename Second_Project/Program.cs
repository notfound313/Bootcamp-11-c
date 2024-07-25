using System.Diagnostics;

using System.Text;

class Program
{

	static void Main(string[] args)
	{
		Stopwatch sw = new();
		sw.Start();
		int N = 15_015;
		StringBuilder output = new StringBuilder();
		//buat dict untuk foobar
		Dictionary<int, string> foobarDict = new Dictionary<int, string>
			{
				{3, "Foo"},
				{5, "Bar"},
				{7, "Qix"},
				{11, "Hup"},
				{13, "Baz"},


			};
		for (int i = 1; i <= N; i++)
		{
			for (int j = 0; j < foobarDict.Count; j++)
			{
				if (i % foobarDict.ElementAt(j).Key == 0)
				{
					output.Append(foobarDict.ElementAt(j).Value);
				}

			}



			// Cetak hasil
			Console.WriteLine(output.Length > 0 ? output.ToString() : i.ToString());
			// output.Length = 0;
			output.Remove(0, output.Length);
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
	}
}
