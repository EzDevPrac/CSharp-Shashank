using System;
namespace Proxy.Example
{
    public class ProxyClient : IClient
{
 RealClient client = new RealClient();
 public ProxyClient()
 {
 Console.WriteLine("ProxyClient: Initialized");
 }

 public string GetData()
 {
 return client.GetData();
 }
}
}