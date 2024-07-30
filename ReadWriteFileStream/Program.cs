using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string path = @".\myTest.txt";
		using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
		{
			
			byte[] bytes = new byte[fs.Length];
			fs.Read(bytes,0,bytes.Length);
			string text = Encoding.UTF8.GetString(bytes);
			Console.WriteLine(text);
		}
	}
}