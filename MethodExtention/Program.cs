class Program
{
	static void Main()
	{
		string str = "Hello World";
		str.Cetak();
		int [] arrInt = {1,2,3,4,5};	
		arrInt.Cetak();
	}
	
}

static class StringExtensions
{
	public static void Cetak(this object str)
	{
		Console.WriteLine(str);
	}
	
}