// action itu seperti delegete public delegete in MyDelegete(int a, int b)

class Program 
{
	static void Main()
	{
		Action<int, int> del=  Add;
		del.Invoke(5,7);
		
	}
	
	static void Add(int a, int b)
	{
		Console.WriteLine(a+b);
	}
}