using System;
namespace EdgeConditions{
class program
{
 

    static void Main(string[] args)
{
    int right,left,top,bottom,m,n,i,j,count=0,anothercount;
    int[] array=new int[100];

   
        Console.WriteLine("Enter the Number of Rows and Columns : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] anotherArray = new int[m, n];
 System.Console.WriteLine("Enter the elements of array");
  for(i=0;i<m;i++)
  {
      for(j=0;j<n;j++)
      {
	      Console.Write("element - [{0},{1}] : ",i,j);
		  anotherArray[i,j] = Convert.ToInt32(Console.ReadLine()); 
      }
  } 
  top=0;
  bottom=m-1;
  left=0;
  right=n-1;
    for(anothercount=1;anothercount<=m/2 && anothercount<=n/2;anothercount++)
    {
    for(i=left;i<=right;i++)
    {
        array[count++]=anotherArray[top,i];
    }
    for(i=top+1;i<=bottom;i++)
    {
        array[count++]=anotherArray[i,right];
    }
    for(i=right-1;i>=left;i--)
    {
        array[count++]=anotherArray[bottom,i];
    }
    for(i=bottom-1;i>=top+1;i--)
    {
        array[count++]=anotherArray[i,left];
    }
    top++;
    left++;
    right--;
    bottom--;
    }
    if(top==bottom && left==right)
    {   
    array[count++]=anotherArray[top,left];
    }
    else if(top<bottom)
    {
    for(i=top;i<=bottom;i++)
    {
        array[count++]=anotherArray[i,left];
    }
    }
    else if(left<right)
    {
    for(i=left;i<=right;i++)
    {
        array[count++]=anotherArray[top,i];
    }
    }
    for(i=0;i<m*n;i++)
    {
    System.Console.WriteLine("{0}",array[i]);
    }
}
}
}