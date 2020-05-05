using System;
namespace Adapter.Example
{
    //Adaptee class
public class HRSystem
 {
  public string[][] GetEmployees()
    {
    string[][] employees = new string[4][];
 
     employees[0] = new string[] { "100", "Shashank", "Developer" };
     employees[1] = new string[] { "101", "Rohit", "Developer" };
     employees[2] = new string[] { "102", "Abhi", "Developer" };
     employees[3] = new string[] { "103", "Samarth", "Tester" };
 
    return employees;
 }
}
}