using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string path = @".\myTest.txt";
		using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
		{
			string text = "Hello World";
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			fs.Write(bytes, 0, bytes.Length);
		}
	}
}