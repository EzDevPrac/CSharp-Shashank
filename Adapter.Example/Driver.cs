using System;

using System.Collections.Generic;
namespace Adapter.Example
{
    class Program
    {
        static void Main(string[] args)
        {
        ITarget Itarget = new EmployeeAdapter();
 ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
 client.ShowEmployeeList();
        }

    }
}
