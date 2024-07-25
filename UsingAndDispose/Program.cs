class Program
{
	static void Main()
	{
		using(FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
		{
			byte[] buffer = new byte[1024];
			fs.Read(buffer, 0, buffer.Length);
		}
	}
	
}