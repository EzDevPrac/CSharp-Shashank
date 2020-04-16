using System;

namespace factory_functions
{
   
abstract class Vehicle{
    public abstract string VehicleType{get;}
    public abstract double speedLimit{get;set;}
    public abstract double VehicleCost{get;set;}
}

class Bike : Vehicle{
    private string _VehicleType;
    private Double _speed;
    private double _VehicleCost;

        public Bike()
        {
        }

        public Bike(double VehicleCost,double speed)
        {
        _VehicleType="Bike";
        _speed=speed;
        _VehicleCost=VehicleCost;
        }
    public override string VehicleType{
        get {
            return _VehicleType;
        }
    }
    public override double speedLimit{
        get {
            return _speed;
        }
        set{
            _speed=value;
        }
    }

        public override double VehicleCost { get
        {
            return _VehicleCost;
        }
        
         set{
             _VehicleCost=value;
         }
    }
}
class Scooter : Vehicle{
    private string _VehicleType;
    private Double _speed;
    private double _VehicleCost;
    public Scooter(double VehicleCost,double speed){
        _VehicleType="Scooter";
        _VehicleCost=VehicleCost;
        _speed=speed;
    }
    public override string VehicleType{
        get {
            return _VehicleType;
        }
    }
    public override double speedLimit{
        get {
            return _speed;
        }
        set{
            _speed=value;
        }
    }

        public override double VehicleCost { 
            get {
                return _VehicleCost;
            }
            set{
                _VehicleCost=value;
            }
    }
}
abstract class VehicleFactory{
    public abstract Vehicle GetVehicle();
}

class Geared : VehicleFactory 
{
    private double _VehicleCost;
    private double _speed;
    public Geared(double VehicleCost,double speed)
    {
        _VehicleCost=VehicleCost;
        _speed=speed;
    }
    public override Vehicle GetVehicle(){
        return new Bike(_VehicleCost,_speed);
    }
}

class NonGeared : VehicleFactory 
{
    private double _VehicleCost;
    private double _speed;
    public NonGeared(double VehicleCost,double speed)
    {
        _VehicleCost=VehicleCost;
        _speed=speed;
    }
    public override Vehicle GetVehicle(){
        return new Scooter(_VehicleCost,_speed);
    }
}

public class client {
public static void Main()
{
    VehicleFactory factory=null;
    Console.Write("enter the vehicle type\n");
    string input=Console.ReadLine();
    switch(input.ToLower()){
        case "bike" :
        factory=new Geared(1500,200);
        break;
        case "scooter":
        factory=new NonGeared(1000,90);
        break;
        default: Console.Write("no vehicle manufactured");break;
    }
    Vehicle vehicle=factory.GetVehicle();
     Console.WriteLine("\nYour Vehicle details are below : \n");  
            Console.WriteLine("Vehicle Type -> {0}\nSpeed Limit -> {1}\nTop speed ->{2}",  
  vehicle.VehicleType, vehicle.speedLimit,vehicle.VehicleCost);  
             
}
}
}