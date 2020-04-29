using System;

namespace StrategyPattern.Example
{
    class DriverClass
    {
        static void Main(string[] args)
        {
            var normalStrategy    = new NormalStrategy();
        var happyHourStrategy = new HappyHourStrategy();
        var firstCustomer = new Customer(normalStrategy);

        // Normal billing
        firstCustomer.Add(2,2);

        // Start Happy Hour
        firstCustomer.Strategy = happyHourStrategy;
        firstCustomer.Add(1.0, 2);

        // New Customer
        Customer secondCustomer = new Customer(happyHourStrategy);
        secondCustomer.Add(0.8, 1);
        // The Customer pays
        firstCustomer.PrintBill();

        // End Happy Hour
        secondCustomer.Strategy = normalStrategy;
        secondCustomer.Add(1.3, 2);
        secondCustomer.Add(2.5, 1);
        secondCustomer.PrintBill();
        }
    }
}
