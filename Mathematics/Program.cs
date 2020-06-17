using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
           ComplexNumber complexNumber = new ComplexNumber(4,42);
           System.Console.WriteLine(complexNumber.ToString());
           System.Console.WriteLine(complexNumber.GetImaginaryNo());
           System.Console.WriteLine(complexNumber.Magnitude());
           ComplexNumber complexNumber1 = new ComplexNumber(4,42);
           complexNumber.Add(complexNumber1);
          Console.WriteLine(complexNumber.ToString());
        }
    }
}
