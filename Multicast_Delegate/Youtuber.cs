using System.Security.Cryptography.X509Certificates;
using D.Youtuber;


public delegate void Subcriber(string text);
public class Youtuber

{
	public Subcriber subcriber;
	
	
	public void UploadVideo()
	{
		Console.WriteLine("upload Selesai");
		sentNotification("video baru");
	}
	public void sentNotification(string text)
	{
		subcriber(text);
	}
}
