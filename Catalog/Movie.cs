namespace Catalog
{
    public class Movie : Information
    {
        protected string ActorName;
        protected string ActressName;
        protected string Director;
    public Movie(string ActorName, string ActressName, string Director)
    {
        this.ActorName = ActorName;
       this.ActressName = ActressName;
        this.Director = Director;
    }

    public string actorName{
        get{return ActorName;}
        set{ ActorName= value;}
    }
    public string actressName
    {
        get{return ActressName;}
        set{ActressName= value;}
    }
    public string director
    {
        get{return Director;}
        set{Director= value;}
    }

    public void Play()
    {

    }
    public void RetriveInformation()
    {

    }
    }
}