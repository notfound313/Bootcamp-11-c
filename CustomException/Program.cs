class Program
{
	static void Main()
	{
		
		try
		{
			CustomException();
		}
		catch (CustomException ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	static void CustomException()
	{
		throw new CustomException("Hayolohh");
	}
}

class CustomException : Exception
{
	public CustomException(string message) : base(message)
	{
	}
}