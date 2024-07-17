//Anonymous Delegate

class Program
{
	static void Main()
	{
		//parameter lesss and void return
		Action print = ()=> Console.WriteLine(5);
		print();

		//parameter and void return
		Action<int, int> print1 = (int a,int b) => Console.WriteLine(a+b);
		print1(1,4);
		//parametr less and not void
		Func<int> print2 = ()=> 6;
		int result = print2();

		//parametr  and not void
		Func<int, int, int> print3 = (int a, int b)=> a+b;
		int result1 = print3(1,3);
		
		//var combination
		var print6 = (int a, int b, int d)=>a+b+d;
		var r = print6(1,3,4);
		Console.WriteLine(r);
		
	}
	
}