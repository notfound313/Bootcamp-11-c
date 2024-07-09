using System.Net;
using Calculator;

class Program
{
	static void Main()
	{
		CalculatorLib calculator = new CalculatorLib();
		string respon;
		
		do 
		{
			Console.WriteLine("Choose Menu on below");
			Console.WriteLine("1. Multiple");
			Console.WriteLine("2. Add \n3. Diveded \n4. Subtruction");
			int pilih = int.Parse(Console.ReadLine());
			int a,b, result;
			if (pilih == 1)
			{
				Console.WriteLine("Masukan Angka A");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("Masukan Angka B");
				b = int.Parse(Console.ReadLine());
				result = calculator.Multiple(a, b);
				Console.WriteLine(result);
				
				
			}else if(pilih == 2)
			{
				Console.WriteLine("Masukan Angka A");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("Masukan Angka B");
				b = int.Parse(Console.ReadLine());
				result = calculator.Add(a, b);
				Console.WriteLine("Result :"+ result);
				
			}
			else if(pilih == 3)
			{
				Console.WriteLine("Masukan Angka A");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("Masukan Angka B");
				b = int.Parse(Console.ReadLine());
				result = calculator.Divided(a, b);
				Console.WriteLine("Result :"+ result);
				
			}else if(pilih == 4)
			{
				Console.WriteLine("Masukan Angka A");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("Masukan Angka B");
				b = int.Parse(Console.ReadLine());
				result = calculator.Subtraction(a, b);
				Console.WriteLine("Result :"+ result);
				
			}else
			{
				Console.WriteLine("Masukan tidak dibenarkan");
				
			}
			Console.WriteLine("Apakah ingin melanjutkan y/t");
			respon = Console.ReadLine();
			
			
			
		}while(respon == "y");
		
		
		
		
	}
}