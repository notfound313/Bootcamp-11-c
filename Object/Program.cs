class Calculator 
{
	public object Add(object a , object b)
	{
		return (int) a+(int)b;
	}
}

class Program 
{
	static void Main()
	{
		Calculator cal = new Calculator();
		//error kareana tidak bia casting ke int
		cal.Add("bsbahj","hbahbdha");
		int result = (int) cal.Add(2,9);
		
		Console.WriteLine(result);
		
		
	}
}