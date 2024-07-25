class Program
{
	static void Main()
	{

		FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);

		try
		{
			CreateFile(fs);
		}
		finally
		{
			fs.Dispose();
		}
	}
	static void CreateFile(FileStream fs)
	{

	}
}