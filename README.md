# CSharp-Shashank
[![Build Status](https://dev.azure.com/shashank24448/shashank24448/_apis/build/status/EzDevPrac.CSharp-Shashank%20(1)?branchName=master)](https://dev.azure.com/shashank24448/shashank24448/_build/latest?definitionId=2&branchName=master)



Welcome to the CSharp-Shashank wiki!
                                                  
                                                  Design Patterns
                                     
**Factory Design Pattern**: The factory method is a creational design pattern that provides an interface for creating objects without specifying their concrete classes. So then what is design pattern ?

> The answer is it is "reusable and interactions of the object" . These are solutions to software design problems you find again and again in real world application development.
> Design patterns have two major benefits.
> They provide you with a way to solve issues related to software development using a proven solution.
> Design patterns make communication between designers more efficient. 

There are 3 classifications of design pattern :



**Structural Design Pattern** : This is concerned with how classes and objects can be composed, to form larger structures. It simplifies structure by identifying relationships. These patterns focus on, how the classes inherit from each other and how they are composed from other classes.

**Behavioral Design Pattern** :  Behavioral Design patterns are the patterns for .Net in which there is a way through which we can pass the request between the chain of objects, or we can say that it defines the manner to communicate between classes and object.Basically this pattern which helps to change the behavior of project, without changing the main structure of the project.

 **Creational Design Pattern** : The Creational Design Pattern deals with object creation mechanisms; trying to create objects in a manner suitable to the situation. It focuses on how the objects are created and utilized in an application. The Creational Design Pattern deals with object creation mechanisms, trying to create objects in a manner suitable to the situation
so that was the brief introduction about design patterns. Now we will look factory design pattern in depth.

Here is the UML Class diagram:

![Factoryfunctions](https://user-images.githubusercontent.com/49721667/79695172-e52d2a80-8292-11ea-9a43-0c915b2f39bd.PNG)


what is product, creator, concreteCreator and ConcreteProduct, lets look at it.
1. *Product* : an interface of objects that factory method creates.

2. *ConcreteProduct*  : a class that implements product interface.

3. *Creator* : Its an abstract class and declares the factory method, i.e it returns an product object. This can also return 
   conceteProduct object.
   
4. *ConcreteCreator* : This is also a class that implements creator class and overrides factory method of a concreteproduct.

It feels bit tricky we will look at an example that will give better idea about this.

![FactoryExample](https://user-images.githubusercontent.com/49721667/79695198-245b7b80-8293-11ea-9a06-2143c7da5516.PNG)



So from above figure, 
1.  *Ifactory* is an interface for creating objects

2. *Scooter and Bike* are concrete product classes that implements Ifactory

3. *VehicleFactory* is creator. This is the one which will return Vehicle

4. *ConcreteVehicleFactory* is concrete creator. This will implement VehicleFactory.

Now lets look at **code snippet: that defines Interface Ifactory**

` public interface IFactory
 {
 void Drive(int miles);
 }
`
so this is the Interface that defines drive methods that takes miles as parameters. 

**below code implements Ifactory** :


`public class Scooter : IFactory
 {
 public void Drive(int miles)
 {
 Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
 }
 }
 public class Bike : IFactory
 {
 public void Drive(int miles)
 {
 Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
 }
 }`

This is code for that defines **vehicle Factory** :

`public abstract class VehicleFactory
 {
 public abstract IFactory GetVehicle(string Vehicle);
 }`
 
above method returns the vehicle object.

Below snippets **implements the vehiclefactory** :

` public class ConcreteVehicleFactory : VehicleFactory
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
 Console.WriteLine("Invalid",Vehicle);
 }
 }
}`

Here comes the **main class** :

`class Program
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
}`


The output of the above code is shown below: 

![factoryOutPut](https://user-images.githubusercontent.com/49721667/79695231-4ead3900-8293-11ea-930b-20caec25f147.PNG)

sofar we saw the implementation of factory patterns. 
Now we will look at what are the cases in which we use this patters.
> 1.  A Factory Design Pattern is used when the entire object can be easily created and object
> is not very complex.
> 2. Sub-classes figure out what objects should be created. 
> 
> **Advantages are** : 1. Factory design pattern provides approach to code for interface rather than implementation.
> 2. Factory pattern removes the instantiation of actual implementation classes from client code.

The complete code can be found in:  
[Factory_Design_Pattern](https://github.com/shashanks4/Factory_Design_Patterns)

**Builder Design patterns :**
Builder design pattern falls under category of *creational design patterns*
>  This pattern is used to build complex object by a step by step approach and final step returns object.Builder interface defines the steps to build the final object. This builder is independent of the objects creation process. A class that is known as Director, controls the object creation process.
Moreover, builder pattern describes a way to separate an object from its construction. The same construction method can create a different representation of the object.

The UML class diagram is as follows:

![Builder Uml](https://user-images.githubusercontent.com/49721667/79696300-87e8a780-8299-11ea-961b-b0b539abb2ac.PNG)

Here is the description of above diagram:
So what does Director, Builder, ConcreteBuilder and Product mean?? Answer is basically
*Builder* is like template, what and all should a product have . It defines an interface to define all
the steps required to construct the product. This is independent of object creation process.
1.  *ConcreteBuilder* : A class makes use of builder interface to create a complex
product. What I mean here is this class implements the methods of builder interface.

2. *Product* : A class defines the parts of complex object which are to be generated by builder pattern.
We can say parts as attributes. Like for example if we take toy as an example, what should be
size of that toy etc…

3. *Director* : is a class used to construct an object using builder interface. This class controls object
creation process.

Lets look at an UML example :

![Builder implementation](https://user-images.githubusercontent.com/49721667/79697035-f0398800-829d-11ea-86ae-b5d7791251d4.PNG)

To say builder pattern describes a way to separate an object from its construction. The same
construction method can create a different representation of the object.
Lets look at the code: 



` public interface IVehicleBuilder
{
 void SetModel();
 void SetEngine();
 void SetTransmission();
 void SetBody();
 void SetAccessories();
Vehicle GetVehicle();
}
` 


The above code is the interface 


Implementation of **concreteclass** is shown below: 

`public class HeroBuilder : IVehicleBuilder
{
 Vehicle objVehicle = new Vehicle();
 public void SetModel()
 {
 objVehicle.Model = "Hero";
 }
 public void SetEngine()
 {
 objVehicle.Engine = "4 Stroke";
 }
 public void SetTransmission()
 {
 objVehicle.Transmission = "120 km/hr";
 }
 public void SetBody()
 {
 objVehicle.Body = "Plastic";
 }
 public void SetAccessories()
 {
 objVehicle.Accessories.Add("Seat Cover");
 objVehicle.Accessories.Add("Rear Mirror");
 }
public Vehicle GetVehicle()
 {
 return objVehicle;
 }
}
` 

The **concreteclass** snippet is shown below: 

` public class HondaBuilder : IVehicleBuilder
{
 Vehicle objVehicle = new Vehicle();
 public void SetModel()
 {
 objVehicle.Model = "Honda";
 }
 public void SetEngine()
 {
 objVehicle.Engine = "4 Stroke";
 }
 public void SetTransmission()
 {
 objVehicle.Transmission = "125 Km/hr";
 }
public void SetBody()
 {
 objVehicle.Body = "Plastic";
 }
 public void SetAccessories()
 {
 objVehicle.Accessories.Add("Seat Cover");
 objVehicle.Accessories.Add("Rear Mirror");
 objVehicle.Accessories.Add("Helmet");
 }
 public Vehicle GetVehicle()
 {
 return objVehicle;
 }
}
`

The **Product class** is shown below: ``

`public class Vehicle
{
 public string Model { get; set; }
 public string Engine { get; set; }
 public string Transmission { get; set; }
 public string Body { get; set; }
 public List<string> Accessories { get; set; }
 public Vehicle()
 {
 Accessories = new List<string>();
 }
public void ShowInfo()
 {
 Console.WriteLine("Model: {0}", Model);
 Console.WriteLine("Engine: {0}", Engine);
 Console.WriteLine("Body: {0}", Body);
 Console.WriteLine("Transmission: {0}", Transmission);
 Console.WriteLine("Accessories:");
 foreach (var accessory in Accessories)
 {
 Console.WriteLine("\t{0}", accessory);
 }
 }
}`

Here is **Director class**:

`public class VehicleCreator
{
 private readonly IVehicleBuilder objBuilder;
 public VehicleCreator(IVehicleBuilder builder)
 {
 objBuilder = builder;
 }
 public void CreateVehicle()
 {
 objBuilder.SetModel();
 objBuilder.SetEngine();
 objBuilder.SetBody();
 objBuilder.SetTransmission();
 objBuilder.SetAccessories();
 }
 public Vehicle GetVehicle()
 {
 return objBuilder.GetVehicle();
 }
}`

here comes the **main class**: 

`class Program
{
 static void Main(string[] args)
 {
 var vehicleCreator = new VehicleCreator(new HeroBuilder());
 vehicleCreator.CreateVehicle();
 var vehicle = vehicleCreator.GetVehicle();
 vehicle.ShowInfo();
 Console.WriteLine("---------------------------------------------");
 vehicleCreator = new VehicleCreator(new HondaBuilder());
 vehicleCreator.CreateVehicle();
 vehicle = vehicleCreator.GetVehicle();
 vehicle.ShowInfo();
Console.ReadKey();
 }
}`

The result of above code is shown below:

![Builder output new](https://user-images.githubusercontent.com/49721667/79696297-86b77a80-8299-11ea-8c91-0dd2b78d86d8.PNG)

> Lets look at the advantages of builder pattern: 
> 1.  It provides clear separation between the construction and representation of an object.
> 2.  It provides better control over construction process.
> 3.  It supports to change the internal representation of objects.
> 
> Which are the cases to use this pattern :
> 
> 1. Need to create an object in several steps (a step by step approach).
> 2. The creation of objects should be independent of the way the object's parts are assembled.

The complete code can be found in below link :

[Builder Design Pattern](https://github.com/shashanks4/Builder_Design_Pattern)


**Command Design Pattern** : This belongs to behavioural pattern, a request is wrapped under an object as a command and passed to invoker object. 

>  The main use is that when you want your requests as objects. This pattern consist of a invoker class, command class/interface, receiver class and command class.  
Here command class means it says the commands. Receiver is, command that runs receiver, invoker keeps track of commands and finally client who decides what command to schedule.  

Here is UML class diagram :
![Builder Uml](https://user-images.githubusercontent.com/49721667/79696300-87e8a780-8299-11ea-961b-b0b539abb2ac.PNG)
So from above diagram we have 

1. *Command* : an interface which will define the methods to implement.
2. *Concretecommand* : the one which implements the command interface 
3. *Invoker* : responsible for processing the request, so this is suited when we implement redo and undo operations. 
4. *Reciever* :This is a class that performs the Action associated with the request.
5. *Client* : This is the class that creates and executes the command object.

Lets look at an example :

![Commandp](https://user-images.githubusercontent.com/49721667/79695449-8c5e9180-8294-11ea-94e3-31cbf1205ce5.PNG)


So if we look at the above diagram,
1. *Switch* : Switch class is the one which will decide which command to execute that may turn off  and turn on.
2. *ICommand* : an interface which has some methods to Execute i e .FlipUpCommand and FlipDownCommand. These methods have FlipUpCommand       and FlipDownCommand to Execute.
3. *Reciever* : class is Light on which commands will be executed.
4. *FlipUpCommand and FlipDownCommand* : Concrete Command classes.

Lets look at a snippet in which we take Turning on and off of light bulb as an example.

Here is **Interface**:

`public interface ICommand
{
 void Execute();
}`
 
**Switch class** : this is invoker class
`public class Switch
{
 private List<ICommand> _commands = new List<ICommand>();
 public void StoreAndExecute(ICommand command)
 {
 _commands.Add(command);
 command.Execute();
 }
}`

**Reciever** : This is light

`public class Light
{
 public void TurnOn()
 {
 Console.WriteLine("The light is on");
 }
public void TurnOff()
 {
 Console.WriteLine("The light is off");
 }
}`

**Icommand implementation**: this will recieve the command, i.e, Turn on or Off


`public class FlipUpCommand : ICommand
{ 
 private Light _light;
 public FlipUpCommand(Light light)
 {
 _light = light;
 }
public void Execute()
 {
 _light.TurnOn();
 }
}
public class FlipDownCommand : ICommand
{
 private Light _light;
 public FlipDownCommand(Light light)
 {
 _light = light;
 }
public void Execute()
 {
 _light.TurnOff();
 }
}` 

**Main class** : which has client class that will decide which command to execute.

`class Program
{
 static void Main(string[] args)
 {
 Console.WriteLine("Enter Commands (ON/OFF) : ");
 string cmd = Console.ReadLine();
Light lamp = new Light();
 ICommand switchUp = new FlipUpCommand(lamp);
 ICommand switchDown = new FlipDownCommand(lamp);
 Switch s = new Switch();
if (cmd == "ON")
 {
 s.StoreAndExecute(switchUp);
 }
 else if (cmd == "OFF")
 {
 s.StoreAndExecute(switchDown);
 }
 else
 {
 Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
 }
Console.ReadKey();
 }
}`

The output is shown below:

![comaop](https://user-images.githubusercontent.com/49721667/79695454-8ff21880-8294-11ea-9ebc-3326076b7252.PNG)


So what are the advantages of command pattern :

> 1. It is useful when creating a structure, particulary when the creating of a request and executing.
> 2. Makes our code extensible as we can add new commands without changing existing code.
> 3. Reduces coupling the invoker and receiver of a command. 

when to use command pattern :

> 1. Need to implement callback functionalities.
> 2. Need to support Redo and Undo functionality for commands.
> 3. Sending requests to different receivers which can handle it in different ways.

The code can be found at :[Command Pattern](https://github.com/shashanks4/Command-Design-Pattern)
