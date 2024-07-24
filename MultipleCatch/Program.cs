class Program
{
	static void Main()
	{
		try
		{
			// string angka= "9k";
			// int value = int.Parse(angka);
			
			int[] arr = null;
			Console.WriteLine(arr[8]);
			
			int[] arr2 = {1,2,3,4,5};
			Console.WriteLine(arr2[8]);
		}
		catch (NullReferenceException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (IndexOutOfRangeException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
			
		}
	}
	
}