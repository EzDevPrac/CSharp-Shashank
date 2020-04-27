using System;
namespace Observer_pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            Subject HTC = new Subject("HTC Mobile", 10000, "Out Of Stock");
            //User Anurag will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Shashank", HTC);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Abhi", HTC); 
          
            
            Console.WriteLine("Red MI Mobile current state : " + HTC.getAvailability());
            Console.WriteLine();
            // Now product is available
            HTC.setAvailability("Available");
            Console.Read();
        }
    }
}