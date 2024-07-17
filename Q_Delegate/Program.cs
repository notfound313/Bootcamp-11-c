using System.Security.Cryptography.X509Certificates;

public delegate void DelegateKu();

class Subcriber
{
	public void SentNotification()
	{
		Console.WriteLine("Subscriber");
	}
	public void ShowText()
	{
		Console.WriteLine("ShowText");
	}
}
class Publiser
{
	private event DelegateKu _del;
	private Delegate[] _invocationList;
	private List<DelegateKu> _methodRegistered = new List<DelegateKu>();
	public void AddSubscriber(DelegateKu method)
	{
		if (!CheckDelegate(method))
		{
			_del += method;
			_methodRegistered.Add(method);

		}


	}



	public void RemoveSubscriber(DelegateKu method)
	{
		if (CheckDelegate(method))
		{
			_del -= method;

		}

	}

	public void GetAllDelegete()
	{
		_invocationList = _del.GetInvocationList();

		if (_invocationList != null)
		{
			foreach (DelegateKu m in _invocationList)
			{
				Console.WriteLine(m.Method.Name);

			}
		}

	}
	private bool CheckDelegate(DelegateKu method)
	{
		if (_del is not null)
		{
			_invocationList = _del.GetInvocationList();

			if (_invocationList.Contains(method))
			{
				return true;

			}

		}
		return false;

	}
	public void GetAllHistory()
	{

		if (_methodRegistered != null)
		{
			foreach (var m in _methodRegistered)
			{
				Console.WriteLine(m.Method);

			}
		}

	}

}

class Program
{
	static void Main()
	{
		Publiser pub = new();
		Subcriber sub = new();
		Subcriber sub2 = new();
		pub.AddSubscriber(sub.SentNotification);
		pub.AddSubscriber(sub.ShowText);
		pub.RemoveSubscriber(sub.SentNotification);
		pub.RemoveSubscriber(sub.SentNotification);

		pub.GetAllDelegete();
		// pub.GetAllHistory();

	}

}