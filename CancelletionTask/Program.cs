class Program
{
	static void Main(string[] args)
	{
		PlayMusicAndVideo();

	}

	private static void PlayMusicAndVideo()
	{

		Console.WriteLine("Playing Video Starting");
		Console.WriteLine("Playing Music Starting");
		
		TaskVideoAndMusic();

		Console.WriteLine("Video Finished");
		Console.WriteLine("Music Finished");
	}

	private static void TaskVideoAndMusic()
	{
		CancellationTokenSource cancellationToken = new CancellationTokenSource();
		Task taskVideo = Task.Run(() => PlayVideo(cancellationToken.Token));
		Task taskMusic = Task.Run(() => PlayMusic(cancellationToken.Token));
		Task cancellationTask = Task.Run(() => InputUserCancel(cancellationToken));
		Task.WaitAll(taskVideo, taskMusic, cancellationTask);
	}

	private static void InputUserCancel(CancellationTokenSource cancellationToken)
	{
		Console.ReadLine();
		cancellationToken.Cancel();
	}

	static void PlayVideo(CancellationToken ct)
	{
		int count = 0;
		string chunk = "";
		while (!ct.IsCancellationRequested && count <= 100)
		{
			
			Console.WriteLine($"Playing Video {chunk} {count}%");
			Thread.Sleep(100);
			chunk += "-";
			count++;
			
		}
	}
	
	static void PlayMusic(CancellationToken ct)
	{
		int count = 0;
		string chunk = "";
		while (!ct.IsCancellationRequested && count <= 100)
		{
			
			Console.WriteLine($"Playing Music {chunk} {count}%");
			Thread.Sleep(100);
			chunk += "-";
			
					
			count++;
		}
		
	}
	
}