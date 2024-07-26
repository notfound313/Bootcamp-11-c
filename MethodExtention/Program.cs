class Program
{
	static void Main()
	{
		string str = "Hello World";
		str.Cetak();
		int n = 11;
		int [] arrInt = {1,2,3,4,5};	
		arrInt.Cetak();
		n.Add(6).Cetak();
	}
	
}

static class StringExtensions
{
	public static void Cetak(this object str)
	{
		Console.WriteLine(str);
	}
	
	public static T Add<T>(this T obj, T value)
	{
		dynamic result = obj;
		result += value;
		return result;
	}
}	