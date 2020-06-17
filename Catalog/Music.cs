namespace Catalog
{
    public class Music 
    {
        protected string SingerName;
        protected double LengthInSeconds;
     
   
        // public string GetSName()
        // {
        //     return SingerName;
        // }
        // public string SetSName()
        // {
        //     SingerName = Value;
        // }
        // public double GetLength()
        // {
        //     return LengthInSeconds;
        // }
        // public double SetLength()
        // {
        //     LengthInSeconds = Value;
        // }
        public Music(string SingerName, double LengthInSeconds)
        {
            this.SingerName = SingerName;
            this.LengthInSeconds = LengthInSeconds;
        }

        public string Singer
        {
            get { return SingerName; }
            set { SingerName = value; }
        }
        public double Length
        {
            get { return LengthInSeconds ; }
            set { LengthInSeconds = value; }
        }
          public void Play()
            {

            }
        public void RetriveInformation()
        {

        }

    }
}