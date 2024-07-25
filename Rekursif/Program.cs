class Program
{
	static void Main()
	{
		int n = 11;
		Console.WriteLine(Faktorial(n));
		Console.WriteLine(RandomAja(n));
		// OverStack();
	}
	static int Faktorial(int n)
	{
		if(n == 1)
		{
			return 1;
		}
		return n * Faktorial(n - 1);
	}
	static int RandomAja(int n)
	{
		return n%2==0?n:RandomAja(n-1);	
		
	}
	static void OverStack()
	{
		OverStack();
	}
}