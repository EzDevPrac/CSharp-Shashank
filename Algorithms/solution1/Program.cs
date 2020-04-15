using System; 

class NoOfPairs { 
	
	static void printPairs(int[] arr, 
						int n, int sum) 
	{ 
		// int count = 0; 


		for (int i = 0; i < n; i++) 
			for (int j = i + 1; j < n; j++) 
				if (arr[i] + arr[j] == sum) 
					Console.Write("(" + arr[i] + ", " + arr[j] + ")"
								+ "\n"); 
								else {
									 return ;
								}
				
	} 


	public static void Main() 
	{ 
        int i,n;
		int[] arr = new int[100];
        Console.Write("Input the number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());
          Console.Write("Input {0} number of elements in the array :\n",n);
          
   for( i=0;i<n;i++)
      {
	  Console.Write("element - {0} : ",i);
	  arr[i] = Convert.ToInt32(Console.ReadLine()); 
	  } 
		 n = arr.Length; 
		int sum = 10; 
		printPairs(arr, n, sum); 
	} 
} 