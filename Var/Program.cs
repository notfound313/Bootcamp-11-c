// Var itu felsibel bisa action/func

class Program 
{
	static void Main()
	{
		var del=  Add;
		del.Invoke(5,7);
		
	}
	
	static void Add(int a, int b)
	{
		Console.WriteLine(a+b);
	}
}