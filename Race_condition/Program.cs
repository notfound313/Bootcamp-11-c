class Program {
	static int Counter = 0;
	static object thisLock = new object();
	static async Task Main() 
	{
		Console.WriteLine("Main method started");
		Task task1 = Task.Run(Incrementer);
		Task task2 = Task.Run(Incrementer);
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Main method completed");
	}
	static async Task Incrementer() {
		
		for(int i = 0; i < 100; i++) {
			//menggunakan lock untuk menghindari race condition
			lock (thisLock)
		{
			Counter++;
			Console.WriteLine(Counter);
		}
			
			await Task.Delay(50);
			
		}
	}
}