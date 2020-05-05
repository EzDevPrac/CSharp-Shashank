using System;
namespace Prototype.Example
{
    public interface IEmployee
 {
    IEmployee Clone();
    string GetDetails();
 }
}