using System.Reflection;
using System.Runtime.CompilerServices;

class Person
{
	//variable
	public string name;
	public int age;
	public string address;
	public string gender;
	
	
	//function
	public void Walk(int distance)
	{
		Console.WriteLine("Walk Distance " + distance.ToString());
	}
	public void Talk()
	{
		Console.WriteLine("talk");
	}
	
	public void Eat(string jenisMakanan)
	{
		Console.WriteLine("Eat " + jenisMakanan );
	}
	
}

class Program 
{
	static void Main()
	{
		Person dika = new Person();
		dika.name = "dika";
		dika.age = 10;
		dika.address= "Bandung";
		dika.gender="Male";
		string makanan = Console.ReadLine();
		int distance = int.Parse(Console.ReadLine());
		dika.Eat(makanan);
		dika.Walk(distance);
		
		
		
		dika.Talk();
		
		
		Person tari = new Person();
		tari.name= "Tari";
		tari.address="Solo";
		tari.age= 12;
		tari.gender = "Female";
		
		
		Console.WriteLine(dika.name);
		Console.WriteLine(dika.address);
		Console.WriteLine(dika.age);		
		
		
		
		
		
		
		
	}
}