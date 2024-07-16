

//Ini class
public delegate void Subcriber(string text);
public delegate int Count(int nilai);
public class Youtuber

{
	public Subcriber subcriber;
	public Count count;
	
	
	public void UploadVideo()
	{
		Console.WriteLine("upload Selesai");
		sentNotification("video baru",1);
	}
	public void sentNotification(string text,int num)
	{
		subcriber(text);
		Console.WriteLine(count(num));
		
	}
}
