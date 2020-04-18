using System;

namespace solution3
{
    


public class SumOfPairs 
{ 

	public void pairedElements(int []arr, int sum) 
	{ 
		int low = 0; 
		int high = arr.Length - 1; 

		while (low < high) 
		{ 
			if (arr[low] + arr[high] == sum) 
			{ 
				Console.WriteLine("The pair is : ("
								+ arr[low] + ", " + arr[high] + ")"); 
			} 
			if (arr[low] + arr[high] > sum) 
			{ 
				high--; 
			} 
			else
			{ 
				low++; 
			} 
		} 
	} 

	// Driver code 
	public static void Main(String[] args) 
	{ 
		int []arr = {  8,7,2,5,3,1 }; 
		Array.Sort(arr); 

		SumOfPairs sp = new SumOfPairs(); 
		sp.pairedElements(arr, 10); 
	} 
} 


}
