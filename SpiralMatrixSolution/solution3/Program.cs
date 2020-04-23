using System;

namespace solution3
{
    class Program
    {   
         static void SpiralMatrix(int[,] array,int Row,int Column)
        {
               int i,top=0,bottom=Row-1,Left=0,right=Column-1,direction=0;
               while(top<=bottom && Left<=right)
               {
                   if(direction==0)
                   {
                       for( i=Left;i<=right;i++)
                       
                           System.Console.WriteLine("{0}",array[top,i]);
                           top++;      
                       
                   }
                   else if(direction==1)
                     {
                       for(i=top;i<=bottom;i++)
                    
                             System.Console.WriteLine("{0}",array[i,right]);
                            right--;
                        
                     }
                    else if(direction==2)
                    {
                        for(i=right;i>=Left;i--)
                        
                            System.Console.WriteLine("{0}",array[bottom,i]);
                            bottom--;
                        
                    }
                    else if(direction==3)
                    {
                        for(i=bottom;i>=top;i--)
                        
                            System.Console.WriteLine("{0}",array[i,Left]);
                            Left++;
                        
                    }
                   direction=(direction+1)%4;
               }
              
        }
    

  public  static void Main(string[] args)
    {
       int Row=4;
       int Column=4;
       int[,] array={ 
           { 1, 2, 3, 4 }, 
					{ 5,6,7,8 },
                    {9,10,11,12},
					{ 13, 14, 15, 16}
       };
        SpiralMatrix(array,Row,Column);
    }
}
}