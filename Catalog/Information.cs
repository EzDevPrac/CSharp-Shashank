namespace Catalog
{
    public class Information
    {
        protected string Name;
        protected string Code;
        protected string Category;
        protected double Size;
        public Information()
        {
            
        }
        public Information(string Name,string Code,string Category, double Size)
        {
         this.Name = Name;
          this.Code = Code;
            this.Category = Category;
            this.Size = Size;
        }
        public string name
        {
            get { return Name;}
            set { Name= value;}
        }
        public string code{
            get{ return Code;}
            set{
                Code = value;}
        }
            public string category
            {
                get{return Category;}
                set{ Category= value;}
            }
            public double size{
                get{ return Size;}
                set{Size= value;}
            }
        }
    }
