class Program 
{
	static void Main()
	{
		//dilarang dipakai di C#
		dynamic value = 3;
		value= true;
		value ="Strong";
		value = new Car();
		value.Add();
		
	}
}
class Car
{
	public string Add()
	{
		return "haha";
	}
}