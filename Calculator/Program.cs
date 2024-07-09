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
			Console.WriteLine("2. Add \n3. Divided \n4. Subtruction");
			int pilih = int.Parse(Console.ReadLine());
			int a, b;
			int result = 0;
			Console.WriteLine("Insert Number A");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Insert Number B");
			b = int.Parse(Console.ReadLine());
			switch (pilih)
			{
				case 1:
					result = calculator.Add(a, b);
					break;
				case 2:
					result = calculator.Multiple(a, b);
					break;
				case 3:
					result = calculator.Divided(a, b);
					break;
				case 4:
					result = calculator.Subtraction(a, b);
					break;

				default:
					Console.WriteLine("Masukan Salah");
					break;

			}

			Console.WriteLine("Result :" + result);

			Console.WriteLine("Apakah ingin mengulangi y/t");
			respon = Console.ReadLine();



		} while (respon.ToLower() == "y");




	}
}