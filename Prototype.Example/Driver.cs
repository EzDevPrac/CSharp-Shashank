using System;

namespace Prototype.Example
{
    class Program
    {
        static void Main(string[] args)
        {
          Developer dev = new Developer();
                dev.Name = "John Cena";
                dev.Role = "Team Leader";
                dev.PreferredLanguage = "C#";

                Developer devCopy = (Developer)dev.Clone();
                devCopy.Name = "Abhi"; //Not mention Role and PreferredLanguage, it will copy above

                Console.WriteLine(dev.GetDetails());
                Console.WriteLine(devCopy.GetDetails());

                Typist typist = new Typist();
                typist.Name = "UnderTaker";
                typist.Role = "Typist";
                typist.WordsPerMinute = 120;

                Typist typistCopy = (Typist)typist.Clone();
                typistCopy.Name = "John";
                typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

                Console.WriteLine(typist.GetDetails());
                Console.WriteLine(typistCopy.GetDetails());
        }
    }
}                                          
