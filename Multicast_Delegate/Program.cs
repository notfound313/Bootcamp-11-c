using D.Youtuber;

class Program
{
	static void Main()
	{
		Youtuber youtuber =new();
		Notification notification =new();
		Email email = new();
		
		youtuber.subcriber += notification.SentNotification;
		youtuber.subcriber += email.ShowText;
		
		youtuber.UploadVideo();
		
	}
	
}