//operator overloading
class Program
{
	static void Main()
	{
		Person mantu = new();
		Person mertua = new();
		mantu.name="jono";
		mertua.name="januari";
		mertua.saldo=100;
		mantu.saldo= 100;
		Person resultName = mertua-mantu;
		Person resulSaldoMantu = mantu+mertua;
		Console.WriteLine(resultName.name);
		Console.WriteLine(resulSaldoMantu.saldo);
		
	}
	
}

class Person 
{
	public string name;
	public int saldo;
	
	public static Person operator-(Person a , Person b)
	{
		Person c = new();
		c.name = a.name+b.name;
		return c;
	}
	public static Person operator+(Person a , Person b)
	{
		Person c = new();
		c.saldo = a.saldo-b.saldo;
		return c;
	}
	
}