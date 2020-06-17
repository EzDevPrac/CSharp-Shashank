using System;
namespace Mathematics
{
    public class ComplexNumber
    {
      
    private double _RealNumber,_ImaginaryNumber;
    public ComplexNumber()
    {

    }
    public    ComplexNumber(double RealNumber,double ImaginaryNumber)
        {
            _RealNumber = RealNumber;
            _ImaginaryNumber = ImaginaryNumber;
        }
        public double GetRealNo()
        {
            return _RealNumber;
        
        }
        public double GetImaginaryNo()
        {
            return _ImaginaryNumber;
        }
        public double SetRealNo(double RealNumber)
        {
        return  _RealNumber = RealNumber;
        }
        public double SetImaginaryNo(double ImaginaryNumber)
        {
           return _ImaginaryNumber = ImaginaryNumber;
        }
        public override string ToString()
        {
            return "_Real part is " + _RealNumber + " Complex part is " + _ImaginaryNumber;
        }
        public double Magnitude()
        {
            return Math.Sqrt((_RealNumber * _RealNumber) + (_ImaginaryNumber * _ImaginaryNumber));
        }
        public void Add(ComplexNumber number)
        {
            _RealNumber += number.GetRealNo();
            _ImaginaryNumber += number.GetImaginaryNo();
        }
           public static ComplexNumber operator -(ComplexNumber a,ComplexNumber b) 
           {
               ComplexNumber complexNumber = new ComplexNumber();
                 complexNumber._RealNumber = -a._RealNumber - b._RealNumber;
              complexNumber._ImaginaryNumber = -a._ImaginaryNumber - b._ImaginaryNumber ;
               return complexNumber;
           }
        public static ComplexNumber operator +(ComplexNumber a,ComplexNumber b)
        {
             ComplexNumber complexNumber = new ComplexNumber();
                 complexNumber._RealNumber = +a._RealNumber + b._RealNumber;
              complexNumber._ImaginaryNumber = +a._ImaginaryNumber + b._ImaginaryNumber ;
               return complexNumber;   

        }
    }
}