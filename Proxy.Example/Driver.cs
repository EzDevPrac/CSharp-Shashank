using System;

namespace Proxy.Example
{
    class Program
    {
        static void Main(string[] args)
        {
        ProxyClient proxy = new ProxyClient();
        Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());
        }
    }
}
