﻿class Program
{
	static void Main()
{
	string myString = "40v";
	bool status = int.TryParse(myString, out int value);
	if(status){
	
		Console.WriteLine(value);
	}else{
	Console.WriteLine($"{value} adalah value");
	}
}



	
}