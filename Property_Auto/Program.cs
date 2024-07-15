interface IPrint
{
	void Print();
}
interface IScan
{
	void Scan();
}

interface IFax
{
	void Fax();
}

class PrinterKasir : IPrint, IScan
{
	public void Scan()
	{
		Console.WriteLine("Scan");

	}
	public void Print()
	{
		Console.WriteLine("Print");

	}

}

interface ICar
{
	public int Price

	{
		get { return Price; }
		set
		{
			if (value < 0)
			{
				Price = 0;
			}
			Price = value;
		}

	}
}

class Program 
{
	static void Main()
	{
		PrinterKasir print = new();
		print.Print();
		
	}
}
