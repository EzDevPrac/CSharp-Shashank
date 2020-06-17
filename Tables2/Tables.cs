namespace Tables2
{
        public class Tables
    {
        public int width {set;get;}
        public int height{set;get;}
        public Tables()
        {
            
        }
        public Tables(int width,int height)
        {
            this.width=width;
            this.height=height;
        }
        public virtual void ShowData()
        {
            System.Console.WriteLine("Width is "+ width + " height is" + height);
        }

    }
    
}