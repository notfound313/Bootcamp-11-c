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
		
		hashArrA.UnionWith(hashArrB);
		hashArrA.IntersectWith(hashArrB);
		hashArrA.ExceptWith(hashArrB);
		
		HashSet<int> A = new() {1,2,3,4};
		HashSet<int> B = new() {1,2};
		
		bool status = A.IsSupersetOf(B);
		status= B.IsSubsetOf(A);
		
		Console.WriteLine(arr);
		
	
		
	}
	
}