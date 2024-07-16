using Non_Delegate;

class Program
{
	static void Main()
	{
		Subcriber subcriber = new();
		Notification notification =new();
		Email email = new();
		
		Youtuber youtuber = new();
		youtuber.subcriber = subcriber;
		youtuber.notification = notification;
		youtuber.email = email;
		
		youtuber.UploadVideo();
	}
	
}