using System;

namespace Facade_Design_Pattern
{
    
    class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine(" CarModel - SetModel");
        }
    }

  
    class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(" CarEngine - SetEngine");
        }
    }


    class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine(" CarBody - SetBody");
        }
    }

    class CarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine(" CarAccessories - SetAccessories");
        }
    }

    // The 'Facade' class
    public class CarFacade
    {
        private readonly CarAccessories accessories;
        private readonly CarBody body;
        private readonly CarEngine engine;
        private readonly CarModel model;

        public CarFacade()
        {
            accessories = new CarAccessories();
            body = new CarBody();
            engine = new CarEngine();
            model = new CarModel();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

           
        }
    }

    // Facade pattern demo
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}
