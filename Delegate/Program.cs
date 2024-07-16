public delegate void Mydelegate();

class Program
{
	static void Main()
	{
		Radio radio = new();
		Mydelegate myDel = radio.OnRadio;
		myDel();
		TV tv = new();
		//cara menambahkan delegate
		myDel +=tv.OnTV;
		//cara mnghapus fuct yang ditambahakan
		myDel -= tv.OnTV;
		myDel();
		
	}
	
}

class Radio
{
	public void OnRadio()
	{
		Console.WriteLine("Radio On");
	}
}
class TV
{
	public void OnTV()
	{
		Console.WriteLine("TV On");
	}
}