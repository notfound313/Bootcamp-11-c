public delegate void Subcriber(String txt);
class CallClass
{
	Subcriber subcriber;
	public void ShowMessage()
	{
		//nuul Oparation
		subcriber?.Invoke("text");
	}
}

class Customer
{
	public void SentData(string msg)
	{
		Console.WriteLine(msg);
	}
}
class Program
{
	static void Main()
	{
		CallClass cal = new();
		Customer cust = new();
		//tidak akan error
		cal.ShowMessage();
		
	}
}