using System;
namespace Proxy.Example
{
public class RealClient : IClient
{
 string Data;
 public RealClient()
 {
 Console.WriteLine("Real Client: Initialized");
 Data = "Dot Net Tricks";
 }

 public string GetData()
 {
 return Data;
 }
} 
}