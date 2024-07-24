class Program
{
	static void Main()
	{
		int b = 100000;
		string s = "Hello";
		
		for(int i = 0; i < b; i++)
		{
			s += "Hi";
			s += "Hu";
			s.Replace("i", "o");
			Thread.Sleep(2);
		}
	}
	
}