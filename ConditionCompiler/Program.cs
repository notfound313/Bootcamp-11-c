
class Program
{
	static void Main()
	{
		Console.WriteLine("Program Running");
		#if DEVELOP
		
		Console.WriteLine("Program Develop Running");
	
		#elif PRODUCTION
		#region production
		
		Console.WriteLine("Program Production Running");
		#endregion
		#elif TESTING
		
		Console.WriteLine("Program Testing Running");
		#endif
		
		Console.WriteLine("Program Stoped");
	}
	
}