class Program
{
	static void Main()
	{
		string path = @".\myTest.txt";
		using(StreamReader sr = new(path) )
		{
			string text = sr.ReadLine();
			if(text is not null)
			{
				Console.WriteLine(text);
			}
		}
	}
	
}