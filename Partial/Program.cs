partial class Program
{
	static void Main()
	{
		//partial hanya bisa di namespace yang sama
		int n = 4;
		int faktorial = Faktorial(n);
		int  randomAja= RandomAja(n);
		int  fibonacci = Fibonacci(n);
		Console.WriteLine(faktorial);
		Console.WriteLine(randomAja);
		Console.WriteLine(fibonacci);

	}
	
	
}