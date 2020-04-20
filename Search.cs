using System;
					
public class Program
{
	public static void Main()
	{
  }
}

public class SearchArray
{
	/* BinarySearch(int[] A, int x)
	 * Description: Search an element x in A[]	 	 
	 * Param1 (int[] A): sorted array
	 * Param2 (int x): value to search	
	 * Return: index of x in A[] if it is present; otherwise -1
	 */
	public int BinarySearch(int[] A, int x)
	{		
		int s = 0;
		int e = A.Length - 1;	
				
		while (s <= e)
		{
			int m = (s + e)/2;
			if (x == A[m])	return m;
			else if (x > A[m])	s = m + 1;			
			else e = m - 1;								
		}
		return -1;
	}
}
