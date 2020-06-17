using System;

namespace RealWorldObject
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            Point3D point3D = new Point3D(2,4,6);
            System.Console.WriteLine(point3D.ToString());
            Point3D point3D1 = new Point3D();
      
          System.Console.WriteLine(  point3D.DistanceTo(point3D1));
        
          
         
        }
    }
}
