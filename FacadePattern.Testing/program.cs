// using System;

// namespace Facade_Design_Pattern
// {
    
//     class CarModel
//     {
//         public void SetModel()
//         {
//             Console.WriteLine(" CarModel - SetModel");
//         }
//     }

  
//     class CarEngine
//     {
//         public void SetEngine()
//         {
//             Console.WriteLine(" CarEngine - SetEngine");
//         }
//     }


//     class CarBody
//     {
//         public void SetBody()
//         {
//             Console.WriteLine(" CarBody - SetBody");
//         }
//     }

//     class CarAccessories
//     {
//         public void SetAccessories()
//         {
//             Console.WriteLine(" CarAccessories - SetAccessories");
//         }
//     }

//     // The 'Facade' class
//     public class CarFacade
//     {
//         private readonly CarAccessories accessories;
//         private readonly CarBody body;
//         private readonly CarEngine engine;
//         private readonly CarModel model;

//         public CarFacade()
//         {
//             accessories = new CarAccessories();
//             body = new CarBody();
//             engine = new CarEngine();
//             model = new CarModel();
//         }

//         public void CreateCompleteCar()
//         {
//             Console.WriteLine("******** Creating a Car **********");
//             model.SetModel();
//             engine.SetEngine();
//             body.SetBody();
//             accessories.SetAccessories();

           
//         }
//     }

//     // Facade pattern demo
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var facade = new CarFacade();

//             facade.CreateCompleteCar();

//             Console.ReadKey();
//         }
//     }
// }
using System;
namespace Facade_Design_Pattern{
public class Patron
{
    private string _name;

    public Patron(string name)
    {
        this._name = name;
    }

    public string Name
    {
        get { return _name; }
    }
}
public class FoodItem { public int DishID; }


public interface KitchenSection
{
    FoodItem PrepDish(int DishID);
}

/// <summary>
/// Orders placed by Patrons.
/// </summary>
class Order
{
    public FoodItem Appetizer { get; set; }
    public FoodItem Entree { get; set; }
    public FoodItem Drink { get; set; }
}
class ColdPrep : KitchenSection
{
    public FoodItem PrepDish(int dishID)
    {
        //Go prep the cold item
        return new FoodItem()
        {
            DishID = dishID
        };
    }
}


// A division of the kitchen.

class HotPrep : KitchenSection
{
    public FoodItem PrepDish(int dishID)
    {
        //Go prep the hot entree
        return new FoodItem()
        {
            DishID = dishID
        };
    }

       
    }

class Bar : KitchenSection
{
    public FoodItem PrepDish(int dishID)
    {
     
        return new FoodItem()
        {
            DishID = dishID
        };
    }
}
class Server
{
    private ColdPrep _coldPrep = new ColdPrep();
    private Bar _bar = new Bar();
    private HotPrep _hotPrep = new HotPrep();

    public Order PlaceOrder(Patron patron, int coldAppID, int hotEntreeID, int drinkID)
    {
        Console.WriteLine("{0} places order for cold app #" + coldAppID.ToString()
                            + ", hot entree #" + hotEntreeID.ToString()
                            + ", and drink #" + drinkID.ToString() + ".");

        Order order = new Order();

        order.Appetizer = _coldPrep.PrepDish(coldAppID);
        order.Entree = _hotPrep.PrepDish(hotEntreeID);
        order.Drink = _bar.PrepDish(drinkID);

        return order;
    }
}
class Program{
 static void Main(string[] args)
{
    Server server = new Server();

    Console.WriteLine("Hello!  I'll be your server today. What is your name?");
    var name = Console.ReadLine();

    Patron patron = new Patron(name);

    Console.WriteLine("Hello " + patron.Name + ". What appetizer would you like? (1-15):");
    var appID = int.Parse(Console.ReadLine());

    Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
    var entreeID = int.Parse(Console.ReadLine());

    Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
    var drinkID = int.Parse(Console.ReadLine());

    Console.WriteLine("I'll get that order in right away.");

    server.PlaceOrder(patron, appID, entreeID, drinkID);  //Here's what the Facade simplifies

    Console.ReadKey();
}
}
}