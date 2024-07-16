using Non_Delegate;

public class Youtuber
{
	public Email email;
	public Notification notification;
	public Subcriber subcriber;
	
	public void UploadVideo()
	{
		Console.WriteLine("upload Selesai");
		sentNotification("video baru");
	}
	public void sentNotification(string text)
	{
		email.ShowText(text);
		notification.SentNotification(text);
		subcriber.ShowNotification(text);
	}
}
