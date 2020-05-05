using System;
namespace AbstractFactory.Example
{
    //ConcreteProduct Class
    public class Cat : IAnimal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }
    public class Lion : IAnimal
    {
        public string speak()
        {
            return "Roar";
        }
    }
    public class Dog : IAnimal
    {
        public string speak()
        {
            return "Bark bark";
        }
    }
    public class Octopus : IAnimal
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }
    public class Shark : IAnimal
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }
}