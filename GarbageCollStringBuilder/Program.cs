using System.Text;

class Program
{
	static void Main()
	{
		StringBuilder sb = new StringBuilder("Hello");
		int b = 10_000;
		
		for(int i = 0; i < b; i++)
		{
			sb.Append("Hi");
			sb.Append("Hu");
			sb.Replace("i", "o");
			
		}
	}
	
}