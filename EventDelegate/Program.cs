public delegate void Delegate();
class Subcriber 
{
	public event Delegate del;
}
public class Email
{
	public void ShowText()
	{
		Console.WriteLine("jk");
	}
}

class Program
{
	static void Main()
	{
		Subcriber sub = new();
		Email email = new();
		//error karena tidak bisa =
		sub.del = email.ShowText;
		
		sub.del += email.ShowText;
		
		
	}
	
}