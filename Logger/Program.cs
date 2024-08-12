using log4net;
using log4net.Config;


class Robot
{
	private ILog _log;
	public Robot(ILog log)
	{
		_log = log;
	}

	public void Run()
	{
		_log.Info("Robot Run");
		Console.WriteLine("Robot Run");

	}
	public void Stop()
	{
		_log.Info("Robot Stop");
		Console.WriteLine("Robot Stop");


	}
	public void Start()
	{
		_log.Info("Robot Start");
		Console.WriteLine("Robot Start");
	}
	public void Add()
	{
		_log.Fatal("Robot Add");
		Console.WriteLine("Robot Add");

	}

}

class Program
{
	static void Main()
	{
		ILog ilog = LogManager.GetLogger(typeof(Robot));
		XmlConfigurator.Configure(new FileInfo("log4net.config"));
		Robot robot = new Robot(ilog);
		while (true)
		{
			robot.Run();
			robot.Stop();
			robot.Start();
			robot.Add();
		}
	}

}