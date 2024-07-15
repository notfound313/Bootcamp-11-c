//type checker
class Calculator 
{
	public object Add(object a , object b)
	{
		if(a is int && b is int)
		{
			return (int) a+(int)b;
		}
		if(a is string && b is string)
		{
			return (string) a+(string)b;
		}
		return null;
	}
}
//pattern checker
class CalculatorLib
{
	public object Add(object a , object b)
	{
		if(a is int d && b is int g)
		{
			return d+g;
		}
		if(a is string u && b is string y)
		{
			return u+y;
		}
		return null;
	}
}

class Program 
{
	static void Main()
	{
		Calculator cal = new Calculator();
		
		string resultString = (string)cal.Add("bsbahj","hbahbdha");
		int result = (int) cal.Add(2,9);
		
		Console.WriteLine(result);
		Console.WriteLine(resultString);
		
		
	}
}