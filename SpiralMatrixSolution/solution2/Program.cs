using System;

namespace solution2
{
   class SolveTheMatrix { 
	
	static void spiralPrint(int ending_Row_Index, int ending_Column_Index, int[, ] a) 
	{ 
		int i, Starting_Row_Index = 0, l = 0; 
	

		while (Starting_Row_Index < ending_Row_Index && l < ending_Column_Index) { 
			
			for (i = l; i < ending_Column_Index; ++i) { 
				Console.Write(a[Starting_Row_Index, i] + " "); 
			} 
			Starting_Row_Index++; 

		
			for (i = Starting_Row_Index; i < ending_Row_Index; ++i) { 
				Console.Write(a[i, ending_Column_Index - 1] + " "); 
			} 
			ending_Column_Index--; 

		
			if (Starting_Row_Index < ending_Row_Index) { 
				for (i = ending_Column_Index- 1; i >= l; --i) { 
					Console.Write(a[ending_Row_Index - 1, i] + " "); 
				} 
				ending_Row_Index--; 
			} 

		
			if (l < ending_Column_Index) { 
				for (i = ending_Row_Index - 1; i >= Starting_Row_Index; --i) { 
					Console.Write(a[i, l] + " "); 
				} 
				l++; 
			} 
		} 
	} 

	// Driver prograending_Row_Index 
	public static void Main(string[] args) 
	{ 
		int Row = 4; 
		int Column = 4; 
		int[, ] array = { { 1, 2, 3, 4 }, 
					{ 5,6,7,8 },
                    {9,10,11,12},
					{ 13, 14, 15, 16} }; 
		spiralPrint(Row, Column, array); 
	} 
} 
}
