# CSharp-Shashank
[![Build Status](https://dev.azure.com/shashank24448/shashank24448/_apis/build/status/EzDevPrac.CSharp-Shashank%20(1)?branchName=master)](https://dev.azure.com/shashank24448/shashank24448/_build/latest?definitionId=2&branchName=master)



Welcome to the CSharp-Shashank wiki!
                                                  
                                                  Design Patterns
                                     
**Observer Design Pattern**: This pattern falls under **Behavioural Pattern** of Gang of Four(GOF).

>1. The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.
2. This pattern is used when there is one to many relationships between objects such as if one object is modified, its dependent objects are to be notified automatically.
3. Observer Design Pattern is allowed a single object, known as the subject, to publish changes to its state and other observer objects that depend upon the subject are automatically notified of any changes to the subject's state.

>So one good example we can take is youtube. When a particular channel uploads a video, that will be notified for thier viewers, if they are subscibed for that channel. Here channel is subject and the number of subscribers are object. Here there is 1 to many relationship exists.

Lets look at the UML class diagram:

![observer-design-pattern](https://user-images.githubusercontent.com/49721667/80371697-ed4b2280-88af-11ea-900f-b24fd299bb16.png)


what can be understood from above class diagram is that:

1. *Subject*: This is a class that contains a private collection of the observers that are subscribed to a subject for notification by using Notify operation.

2. *ConcreteSubject*: This is a class that maintains its own state. When a change is made to its state, the object calls the base class's Notify operation to indicate this to all of its observers.

3. *Observer*: This is an interface which defines an operation Update, which is to be called when the subject's state changes.

4.*ConcreteObserver*: This is a class that implements the Observer interface and examines the subject to determine which information has changed.

Lets look at the real world example:

Here **Subject** is Amazon, defined as an Interface:
```
  public interface ISubject
    {
         void RegisterObserver(IObserver observer);
         void RemoveObserver(IObserver observer);
         void NotifyObservers();
    }
```

**Concrete Subject** Code snippet is shown below, which notifies when there is change in state:
```
public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }
        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }
        
        public string getAvailability()
        {
            return Availability;
        }
        public void setAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName );
            observers.Add(observer);
        }
        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.update(Availability);
            }
        }
    }
```

**Observer** implemented as Interface goes like this, in which objects that should be notified of changes in a Subject.
```
public interface IObserver
    {
        void update(string availability);
    }
```

**Observer** code is shown below, that implements Observer:
```
public class Observer : IObserver
    {
        public string UserName { get; set; }
        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }
        public void update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
```

**Driver class**:
```

static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            Subject HTC = new Subject("HTC Mobile", 10000, "Out Of Stock");
            
            Observer user1 = new Observer("Shashank", HTC);
            //User Abhi will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Abhi", HTC); 
            Console.WriteLine("Red MI Mobile current state : " + HTC.getAvailability());
            Console.WriteLine();
            // Now product is available
            HTC.setAvailability("Available");
            Console.Read();
        }
```

Output is shown:

![observer op](https://user-images.githubusercontent.com/49721667/80373478-c0e4d580-88b2-11ea-97e9-cac762672ea7.PNG)


Sofar we saw how to implement observer pattern, now lets look at when should we use this pattern:

>1. Changes in the state of an object need to be notified to a set of dependent objects.
>2. Notification capability is required.

>Advantages are:
1. It supports the principle of loose coupling between objects that interact with each other.
2. It allows sending data to other objects effectively without any change in the Subject or Observer classes.
3. Observers can be added/removed at any point in time

The complete code can be found at :
[Observer Pattern](https://github.com/shashanks4/ObserverPattern-CSharp)


**Decorator Design Pattern**: Decorator design pattern falls under **Structural Pattern** of Gang of Four (GOF) Design Patterns in .Net.

>Decorator pattern is used to add new functionality to an existing object without changing its structure. Hence Decorator pattern provides an alternative way to inheritance for modifying the behavior of an object. The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern.The decorator pattern is structurally nearly identical to the chain of responsibility pattern, the difference being that in a chain of responsibility, exactly one of the classes handles the request, while for the decorator, all classes handle the request.

Lets look at the UML class diagram:
![Decorartor UML Imple](https://user-images.githubusercontent.com/49721667/80310492-a2220880-87f8-11ea-81e6-18048525bc7c.PNG)

So what can be understood from above diagram, lets see.
1. *Component* : This is an interface containing members that will be implemented by ConcreteClass and Decorator.

2. *ConcreteComponent*: This is a class which implements the Component interface.

3. *Decorator*: This is an abstract class which implements the Component interface and contains the reference to a Component instance. This class also acts as base class for all decorators for components.

4. *ConcreteDecorator*: This is a class which inherits from Decorator class and provides a decorator for components.

Okie now, lets look at an example so that we have clear idea about this.

![UML imple Example](https://user-images.githubusercontent.com/49721667/80311154-9ab02e80-87fb-11ea-9c38-e60372472534.PNG)

Here is the explaination:
1. *Vehicle*: Component Interface.

2. *HondaCity*: ConcreteComponent class.

3. *VehicleDecorator*: Decorator Class.

4. *Special Offer*: ConcreteDecorator class.

lets look at **interface Vehicle**:
```
 public interface IVehicle
{
 string Make { get; }
 string Model { get; }
 double Price { get; }
}
```

here is **concrete implementation** of vehicle interface,i.e is **HondaCity**:
```
public class HondaCity : Vehicle
{
 public string Make
 {
 get { return "HondaCity"; }
 }
public string Model
 {
 get { return "CNG"; }
 }
public double Price
 {
 get { return 1000000; }
 }
}
```

**Decorator Abstract** class:

```
public abstract class VehicleDecorator : Vehicle
{
 private Vehicle _vehicle;
 public VehicleDecorator(Vehicle vehicle)
 {
 _vehicle = vehicle;
 }
 public string Make
 {
 get { return _vehicle.Make; }
 }
 public string Model
 {
 get { return _vehicle.Model; }
 }
 public double Price
 {
 get { return _vehicle.Price; }
 }
}

```

**ConcreteDecorator**

```
public class SpecialOffer : VehicleDecorator
{
 public SpecialOffer(Vehicle vehicle) : base(vehicle) { }
 public int DiscountPercentage { get; set; }
 public string Offer { get; set; }
 public double Price
 {
 get
 {
 double price = base.Price;
 int percentage = 100 - DiscountPercentage;
 return Math.Round((price * percentage) / 100, 2);
 }
 }
}
```

Here is Decorator Pattern Demo class:

```
class Program
{
 static void Main(string[] args)
 {
HondaCity car = new HondaCity();
Console.WriteLine("Honda City base price are : {0}", car.Price);
SpecialOffer offer = new SpecialOffer(car);
 offer.DiscountPercentage = 25;
 offer.Offer = "25 % discount";
 Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);
 Console.ReadKey();
 }
}

```

Output is here:

![deco op](https://user-images.githubusercontent.com/49721667/80313658-e2d64d80-8809-11ea-978c-07309c8fe53a.PNG)

When this pattern should be is used:
>Add additional state or behavior to an object dynamically.
Make changes to some objects in a class without affecting others.

>Advantages are: 
1. Adds functionality to existing objects dynamically.
2. Alternative to sub classing.
3. Flexible design.
4. Supports Open Closed Principle.

The complete code can be found at:
[Design Pattern](https://github.com/shashanks4/DecoratorPattern_c-)

**Singleton Design Pattern**: This pattern falls under the category of creational pattern. This is one of the simplest patterns.

>This pattern ensures that a class has only one instance and provides a global point of access to it.
>Singletons don't allow any parameters to be specified when creating the instance since the second request of an instance with a different parameter could be problematic! 

There are various ways to implement the Singleton Pattern in C#. The following are the common characteristics of a Singleton Pattern.
A single constructor, that is private and parameterless.
The class is sealed.
A static variable that holds a reference to the single created instance, if any.
A public static means of getting the reference to the single created instance, creating one if necessary.

There are various ways to implement Singleton pattern. 
1.No Thread Safe Singleton.
2. Thread-Safety Singleton.
3. Thread-Safety Singleton using Double-Check Locking.
4. Thread-Safe Singleton without using locks and no lazy instantiation.
5. Fully lazy instantiation.
6. Using .NET 4's Lazy<T> type.

Lets look aT UML class diagram:

![singleton_UML](https://user-images.githubusercontent.com/49721667/80308936-54ed6900-87ef-11ea-8a3c-1a63ea5ed799.png)



*Singleton* : This is a class responsible for creating and maintaining its instance. Here instance refers to object


Let us look at implemnetation of these one by one :

1. **No Thread safe Sinyleton**: Two different threads could both have evaluated the test (if instance == null) and found it to be true, then both create instances, which violates the singleton pattern.
Note that in fact the instance may already have been created before the expression is evaluated.

It looks bit confusing, so we will look at the code and understand in deep.

Code snippet goes like this:

```
public sealed class Singleton
{

 private string Name{get;set;}
 private string IP{get;set;}
 private Singleton()
 {
 Console.WriteLine("Singleton Intance");
    Name = "Server1";
    IP = "192.168.1.23";
 }
public static Singleton Instance
 {
 get
 {
if (Singleton.instance == null)
 Singleton.instance = new Singleton();
return Singleton.instance;
 }
 }
public void Show()
 {
 Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
 }
}
```

So here we are creating a singleton instance and we are checking whether multiple instance are created for the same object or not. If we look at above code in if statement initially if instance is equal to null then we are creating the instanceand we are returning the object. But we can create multiple instance for same object which voilates the Singleton's objective.

we will go to second method,  which is thread safety singleton.

2. **Thread-Safety Singleton**: the thread is locked on a shared object and checks whether an instance has been created or not.
This takes care of the memory barrier issue and ensures that only one thread will create an instance.
This takes care of the memory barrier issue and ensures that only one thread will create an instance.
For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate to false.
The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.



Lets look at the code snippet:
```
 public class Singleton
{
private static Singleton instance = null;
 private string Name{get;set;}
 private string IP{get;set;}
  private Singleton()
 {
 Console.WriteLine("Singleton Intance");
 Name = "Server1";
 IP = "192.168.1.23";
 }
 // Lock synchronization object
private static object syncLock = new object(); 
public static Singleton Instance
 {
 get
 {
lock(syncLock){
 if (instance == null)
 instance = new Singleton();
 return instance;
 }
 }
 } public void Show()
 {
 Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
 }
}

```
So here we are creatinga lock, so that if there are many threads which wants to create an object and run,  locks will not allow, only one thread can complete the execution and hence even though there are multiple threads and it wants to create an instance it wont work using Locks.

3. **Thread-Safety Singleton using Double-Check Locking**: the thread is locked on a shared object and checks whether an instance has been created or not with double checking.

Lets look at the code snippet:
```
public class Singleton
{
    private static Singleton instance = null;
 private string Name{get;set;}
 private string IP{get;set;}
 private Singleton()
 {
Console.WriteLine("Singleton Intance");
Name = "Server1";
 IP = "192.168.1.23";
 }
 // Lock synchronization object
  private static object syncLock = new object();
public static Singleton Instance
 {
 get
 {
     if(instance==null){
lock(syncLock){
  if (Singleton.instance == null)
 {
 Singleton.instance = new Singleton();
 } 
}
     } 
 return Singleton.instance;
}
} public void Show()
 {
 Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
 }
}
```
Here in the above code we have double locking which ensures more safety.

4. **Thread-Safe Singleton without using locks and no lazy instantiation** : Here we are creating the static constructor and we are avoinding multiple instances to be created.It is simple.

Lets look at code snippet:
```
  public class Singleton
{

 private static Singleton instance = new Singleton();
 private string Name{get;set;}
 private string IP{get;set;}
 static Singleton()
 {

 }
 private Singleton()
 {
Console.WriteLine("Singleton Intance");
 Name = "Server1";
 IP = "192.168.1.23";
 }
public static Singleton Instance
 {
 get
 {
    return Singleton.instance;
}
 }
 public void Show()
 {
 Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
 }
}
```
Sofar we have seen the implementation of this pattern, now lets look at in what scenarios we can use singletonpattern.
>Exactly one instance of a class is required.
>Controlled access to a single object is necessary.

>Advantages are:
1. It can be extended into a factory pattern.
2. It helps to hide dependencies.
3. It provides a single point of access to a particular instance, so it is easy to maintain.
4. It has static initialisation.

The code can be found at:
[Singleton Pattern](https://github.com/shashanks4/SingletonPattern_c-)

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

```
public interface IFactory
 {
 void Drive(int miles);
 }
```
so this is the Interface that defines drive methods that takes miles as parameters. 

**below code implements Ifactory** :


```
public class Scooter : IFactory
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
 }
 ```

This is code for that defines **vehicle Factory** :

```
public abstract class VehicleFactory
 {
 public abstract IFactory GetVehicle(string Vehicle);
 }
 ```
 
above method returns the vehicle object.

Below snippets **implements the vehiclefactory** :

```
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
 Console.WriteLine("Invalid",Vehicle);
 }
 }
}
```

Here comes the **main class** :

```
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
```


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

![Builder Uml](https://user-images.githubusercontent.com/49721667/79697207-11e73f00-829f-11ea-8f29-495fa59e5c55.png)

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



```
public interface IVehicleBuilder
{
 void SetModel();
 void SetEngine();
 void SetTransmission();
 void SetBody();
 void SetAccessories();
Vehicle GetVehicle();
}
```


The above code is the interface 


Implementation of **concreteclass** is shown below: 

```
public class HeroBuilder : IVehicleBuilder
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
``` 

The **concreteclass** snippet is shown below: 

```
public class HondaBuilder : IVehicleBuilder
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
```

The **Product class** is shown below: ``

```
public class Vehicle
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
}
```

Here is **Director class**:

```
public class VehicleCreator
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
}
```

here comes the **main class**: 

```
class Program
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
}
```

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

```
public interface ICommand
{
 void Execute();
}
```
 
**Switch class** : this is invoker class

```
public class Switch
{
 private List<ICommand> _commands = new List<ICommand>();
 public void StoreAndExecute(ICommand command)
 {
 _commands.Add(command);
 command.Execute();
 }
}
```

**Reciever** : This is light

```
public class Light
{
 public void TurnOn()
 {
 Console.WriteLine("The light is on");
 }
public void TurnOff()
 {
 Console.WriteLine("The light is off");
 }
}
```

**Icommand implementation**: this will recieve the command, i.e, Turn on or Off


```
public class FlipUpCommand : ICommand
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
}
``` 

**Main class** : which has client class that will decide which command to execute.

```
class Program
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
}
```

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

Facade Design Pattern : This design pattern falls under Structural pattern. Facade pattern hides the complexities of system and provides an interface to the client, using which the client can access the system.(Here client refers the small piece of code nothing else).

 >The Facade design pattern is particularly used when a system is very complex or difficult to understand because the system has a large >number of interdependent classes or its source code is unavailable.This pattern involves a single wrapper class which contains a set of >members which are required by the client. These members access the system on behalf of the facade client and hide the implementation >details.

Lets look at the UML class diagram:

![W3sDesign_Facade_Design_Pattern_UML](https://user-images.githubusercontent.com/49721667/79768881-018b9e80-8349-11ea-947a-3bac8e350030.jpg)

So from the above UML diagram we can say that Client class doesn't access the subsystem classess directly, instead it will ask Facade class. What that means is Facade is the one that will interact with all the sub-classes whcih has the various methods or functionalities. Client only depends on Facade not on entire system.

Here, *Facade* : Is an Interface we can say or abstract class.
*Client* : It is the one which requires something to be done.
*Sub-classes* : These are some interdependent classes. This classes actually has all the methods. 

lets take car as example and UML class diagram is shown below:

![Facade implementation](https://user-images.githubusercontent.com/49721667/79769027-3ac40e80-8349-11ea-9ca2-ac2de78f5943.PNG)

So what can we understand from above diagram ? the answer is 
1. *CarFacade* : This is the facade class.
2. *CarMethods, CarAccessories, CarModel and CarEngine* : These are the concrete class we can say that implements CarFacade.

Lets look at the code,
So if we look at the below code, these are all the **sub-classes** that implements Facade.

```
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
  class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(" CarEngine - SetEngine");
        }
    }
  class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine(" CarModel - SetModel");
        }
    }
```
 
Now lets look at **Facade class** : 

```
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
```
what can we understand from above code is Facade has control over the methods that its concrete class implements.

Here is the **client** snippet:

```
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
```

here we are calling the facade object and getting the car.

The output is here :

![facade op](https://user-images.githubusercontent.com/49721667/79769191-6e069d80-8349-11ea-8aa6-d3c939ea7a97.PNG)

sofar we went through the facade design pattern, now lets look at when to use this pattern,

> 1. The facade design pattern is particularly used when a system is very complex or difficult to understand because the system has a large number of interdependent classes or its source code is unavailable.
> 2. A simple interface is required to access to a complex system.
> 3. The abstractions and implementations of a subsystem are tightly coupled. 
> 
> Advantages are :
> 1. It basically reduces the dependencies between libraries or other packages.
> 2. It makes easier to use and maintain creating a more structured environment.

The code can be found at :
[Facade_Pattern](https://github.com/shashanks4/Facade_Design_Pattern)
