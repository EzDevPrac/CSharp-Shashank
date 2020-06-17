namespace RealWorldObject
{
    public class Point3D
    {
        protected double x,y,z;
        public Point3D()
        {

        } 

        public Point3D(double a,double b,double c)
        {
            MoveTo(a,b,c)  ;
        }
        public double GetX()
        {
            return x;
        }
        public void SetX(double X)
        {
            x= X;
        }
        public void SetY(double Y)
        {
            y=Y;
        }
          public double GetY()
        {
            return y;
        }
  
          public double GetZ()
        {
            return z;
        }
        public void SetZ(double value)
        { 
            z=value;
        }
        public void  MoveTo(double a, double b,double c )
        {
           
           x=a;
           y=b;z=c;
           System.Console.WriteLine("x  is " + x + "y is "+ y + "z is"+ z);
        }
        public double DistanceTo(Point3D p2)
        {
            return System.Math.Sqrt((x - p2.GetX()) * (x - p2.GetX() ) + (y-p2.GetY())*(y-p2.GetY()) + (z-p2.GetZ() * z- p2.GetZ() ));
        }
        public  string ToString() 
        {
            return " X Coordinate is" + x + " Y Coordinate is " + y + " z is " + z;
        }

    }
}