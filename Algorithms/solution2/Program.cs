using System; 
using System.Collections.Generic; 

class FindPair{ 
	static void printpairs(int[] arr, 
						int sum) 
	{ 
		HashSet<int> s = new HashSet<int>(); 
		for (int i = 0; i < arr.Length; ++i) { 
			int temp = sum - arr[i]; 

			
			if (s.Contains(temp)) { 
				Console.Write("Pair with given sum " + sum + " is (" + arr[i] + ", " + temp + ")\n"); 
			} 
			
			s.Add(arr[i]); 
		} 
	} 

	
	static void Main() 
	{ 
		int[] A = new int[] { 8,7,2,5,3,1 }; 
		int n = 10; 
		printpairs(A, n); 
	} 
} 

