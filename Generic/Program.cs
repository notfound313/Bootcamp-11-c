//Generic bisa mengubah ke fleksibelan data dengan tanda <T>

//contoh non generic
class ArrayCollection 
{
	public int [] arrCollection = new int[5];
	public int count = 0;
	
	public void Add(int input)
	{
		if(count == arrCollection.Length)
		{
			return;
		}
		
		arrCollection[count] = input;
		count++;
		
	}
	
	public int Get(int index)
	{
		return arrCollection[index];
	}
	
	public void Remove(int index)
	{
		arrCollection[index]=default;
	}
}
class ArrayCollection<T>
{
	public T [] arrCollection = new T[5];
	public int count = 0;
	
	public void Add(T input)
	{
		if(count == arrCollection.Length)
		{
			return;
		}
		
		arrCollection[count] = input;
		count++;
		
	}
	
	public T Get(int index)
	{
		return arrCollection[index];
	}
	
	public void Remove(int index)
	{
		arrCollection[index]=default;
	}
}

class Program
{
	static void Main()
	{
		ArrayCollection<string> arrString = new ArrayCollection<string>();
		arrString.Add("satu");
		ArrayCollection<int> arrInt = new ArrayCollection<int>();
		arrInt.Add(5);
		Console.WriteLine(arrString.Get(0));
		Console.WriteLine(arrInt.Get(0));
		arrString.Add("tiga");
		Console.WriteLine(arrString.Get(1));
		
		
		
		
	}
}