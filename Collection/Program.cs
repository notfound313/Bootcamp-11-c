using System.Collections;

class Program
{
	static void Main()
	{
		//colcction Array
		int[] arr = new int[5];
		int[] arrY = [2,4,5,6,7];
		arr.Append(1);
		arr[1] = 2;
		arrY.Contains(2);
		
		//ArrayList
		ArrayList arrayList = new ArrayList();
		arrayList.Add(5);
		arrayList.Add(true);
		
		//List
		List<string> arrString = new();
		arrString.Add("halololo");
		arrString.Add("jwaaahahaha"); 
		
		//Hashnet
		HashSet<int> hashArrA = new() {1,2,3,4,5,6};
		HashSet<int> hashArrB = new() {3,6,7,8,9};
		
		// hashArrA.UnionWith(hashArrB);
		// hashArrA.IntersectWith(hashArrB);
		hashArrA.ExceptWith(hashArrB);
		
		HashSet<int> A = new() {1,2,3,4};
		HashSet<int> B = new() {1,2};
		
		bool status = A.IsSupersetOf(B);
		status= B.IsSubsetOf(A);
		
		// foreach(int i in hashArrA)
		// {
		// 	Console.WriteLine(i);
		// }
		
		Queue<int> ints = new Queue<int>();
		ints.Enqueue(3);
		ints.Enqueue(2);
		ints.Enqueue(1);
		ints.Enqueue(9);
		int rest = ints.Dequeue();//3
		int pek = ints.Peek();//2
		int resti = ints.Dequeue();//2
		
		Stack<int> stack =new();
		stack.Push(2);
		stack.Push(3);
		stack.Push(5);
		stack.Pop();
		stack.Pop();
		
		
		
		//Dicttionaray
		
		Dictionary<int,string> dict = new();
		
		dict.Add(1,"jaja");
		dict.Add(3,"juju");
		dict.Add(2,"lalal");
		
		bool stats = dict.TryGetValue(3,out string resy);
		if(stats)
		{
			Console.WriteLine(resy);
		}
		dict[3] = "lllknk";
		
		Console.WriteLine(dict[3]);
		Console.WriteLine(stats);
		Console.WriteLine(dict.Keys);

		
		
		
		
		
		
	
		
	}
	
}