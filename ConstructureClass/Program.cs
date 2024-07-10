class Home
{
	public int door;
	public int window;
	public string colour;
	public string address;
	//constructor paramaterless
	public Home()
	{
		Console.WriteLine($"Home Created : {door} {window} {colour} {address}");

	}
	// constructor parameter
	public Home(int door,
				int window,
				string colour,
				string address
				)
	{
		this.door = door;
		this.window = window;
		this.colour = colour;
		this.address = address;
		Console.WriteLine($"Home Created : {door} {window} {colour} {address}");
	}

	public Home(int door, int window)
	{
		this.door = door;
		this.window = window;
		Console.WriteLine($"Home Created : {door} {window}");

	}



}

class Program
{
	static void Main()
	{
		Home home = new Home();
		Home home1 = new Home(2, 3, "black", "Bandung");
		Home home2 = new Home(2, 4);


	}

}