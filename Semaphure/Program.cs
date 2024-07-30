class Program
{
	static SemaphoreSlim sem = new (2);
	static async Task Main(string[] args)
	{
		Task[] tasks = new Task[10];
		for(int i = 0; i < tasks.Length; i++)
		{
			int idx = i;
			tasks[i] = Task.Run(()=> DoSomething(idx));
		}
		await Task.WhenAll(tasks);
		
	}
	
	static async Task DoSomething(int idx)
	{
		Console.WriteLine($"Doing Something Thread {idx}");
		await sem.WaitAsync();
		Console.WriteLine($"Doing Process Thread {idx}");
		await Task.Delay(1000);
		sem.Release();
		Console.WriteLine($"Done Process Thread {idx}");
	}
	
}