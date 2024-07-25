class Program
{
	static void Main()
	{
		float [] myflat= new float[100*1024];
		Console.WriteLine(GC.GetGeneration(myflat));
	}
	
}