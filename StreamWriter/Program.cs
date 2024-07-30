class Program
{
	static void Main()
	{
		string path = @".\myTest.txt";
		using(StreamWriter sw = new StreamWriter(path))
		{
			sw.WriteLine("Hello Uhuuuuiiii");
			
		}
	}
	
}