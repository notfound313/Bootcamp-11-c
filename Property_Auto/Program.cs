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
			if (value < 6)
			{
				Price = 0;
			}
			Price = value;
		}

	}
}
class Car : ICar
{
	public int Price { get; set; }
	
}

class Program 
{
	static void Main()
	{
		Car car = new();
		car.Price = 4;
		PrinterKasir print = new();
		print.Print();
		Console.WriteLine(car.Price);
		
	}
}
