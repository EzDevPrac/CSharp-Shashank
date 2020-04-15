// using System;

// namespace factory_functions
// {
   
// abstract class Vehicle{
//     public abstract string VehicleType{get;}
//     public abstract Double speedLimit{get;set;}
//     public abstract double VehicleCost{get;set;}
// }

// class Bike : Vehicle{
//     private string _VehicleType;
//     private Double _speed;
//     private double _VehicleCost;

//         public Bike(double speed,double VehicleCost){
//         _VehicleType="Geared";_speed=100;
//         _VehicleCost=1000;
        
//     }
//     public override string VehicleType{
//         get {
//             return _VehicleType;
//         }
//     }
//     public override double speedLimit{
//         get {
//             return _speed;;
//         }
//         set{
//             _speed=value;
//         }
//     }
    


//         public override double VehicleCost { 
//              get {
//             return _VehicleCost;
//         } 
//         set{
//          _VehicleCost=value;
//         }  }
// }
// class Scooter : Vehicle{
//     private string _VehicleType;
//     private Double _speed;
//     private double _VehicleCost;
//     public Scooter(double speed,double VehicleCost){
//         _VehicleType="NonGeared Vehicle";
//         _VehicleCost=999;
//         _speed=100;
//     }
//     public override string VehicleType{
//         get {
//             return _VehicleType;
//         }
//     }
//     public override double speedLimit{
//         get {
//             return _speed;;
//         }
//         set{
//             _speed=value;
//         }
//     } 
//     public override double VehicleCost
//      { get 
//      { return _VehicleCost; }
//       set { _VehicleCost=VehicleCost;}
      
//     }
// abstract class VehicleFactory{
//     public abstract Vehicle GetVehicle();
// }

// class Geared : VehicleFactory 
// {
//     private double _VehicleCost;
//     private double _speed;
//     public Geared(double VehicleCost,double speed)
//     {
//         _VehicleCost=VehicleCost;
//         _speed=speed;
//     }
//     public override Vehicle GetVehicle(){
//         return new Bike(_VehicleCost,_speed);
//     }
// }

// class NonGeared : VehicleFactory 
// {
//     private double _VehicleCost;
//     private double _speed;
//     public NonGeared(double VehicleCost,double speed)
//     {
//         _VehicleCost=VehicleCost;
//         _speed=speed;
//     }
//     public override Vehicle GetVehicle(){
//         return new Bike(_VehicleCost,_speed);
//     }
// }

// public class client {
// public static void Main()
// {
//     VehicleFactory factory=null;
//     Console.Write("enter the Vehicle type");
//     string input=Console.ReadLine();
//     switch(input){
//         case "Bike" :
//         factory=new Geared(1500,200);
//         break;
//         case "Scooter":
//         factory=new NonGeared(1000,90);
//         break;
//         default: Console.Write("no vehicle manufactured");break;
//     }
//     Vehicle vehicle=factory.GetVehicle();
//      Console.WriteLine("\nYour Vehicle details are below : \n");  
//             Console.WriteLine("Vehicle Type -> {0}\nSpeed Limit -> {1}\nTop speed ->{2}",  
//   vehicle.VehicleType, vehicle.speedLimit,vehicle.VehicleCost);  
             
// }
// }
// }
// }
using System;

namespace factory_functions
{
   


 //  Product interface
 
 public interface IFactory
 {
 void Drive(int miles);
 }

 
 //  'ConcreteProduct' class
 
 public class Scooter : IFactory
 {
 public void Drive(int miles)
 {
 Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
 }
 }

 /// A 'ConcreteProduct' class
 
 public class Bike : IFactory
 {
 public void Drive(int miles)
 {
 Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
 }
 }

 
 //The Creator Abstract Class

 public abstract class VehicleFactory
 {
 public abstract IFactory GetVehicle(string Vehicle);

 }

 
 // A 'ConcreteCreator' class
 
 public class ConcreteVehicleFactory : VehicleFactory
 {
 public override IFactory GetVehicle(string Vehicle)
 {
 switch (Vehicle)
 {
 case "Scooter":
 return new Scooter();
 case "Bike":
 return new Bike();
 default:
 
 throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
 }
 }

 }
 
 
 class Program
 {
 static void Main(string[] args)
 {
 VehicleFactory factory = new ConcreteVehicleFactory();

 IFactory scooter = factory.GetVehicle("Scooter");
 scooter.Drive(10);

 IFactory bike = factory.GetVehicle("Bike");
 bike.Drive(20);

 Console.ReadKey();

 }
 }
}
