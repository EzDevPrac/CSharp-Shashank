namespace Tables2
{
    public class CoffeeTable : Tables
    {
        // public int width{set;get;}
        // public int height{set;get;}
        public CoffeeTable()
        {

        }
          public CoffeeTable(int width,int height)
        {
            this.width=width;
            this.height=height;
        }
        public  void Display()
        {
            System.Console.WriteLine("Coffee Table");
        }
    }
}