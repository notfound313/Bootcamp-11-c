

partial class Program
{
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
	static int Fibonacci(int n)
	{
		
		return n<2? n:Fibonacci(n-1)+Fibonacci(n-2);
	}
}
