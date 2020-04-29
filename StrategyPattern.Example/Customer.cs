using System;
using System.Collections.Generic;
namespace StrategyPattern.Example
{
public class Customer
{
private IList<double> drinks;
    // Get/Set Strategy
    public IBillingStrategy Strategy { get; set; }
    public Customer(IBillingStrategy strategy)
    {
        this.drinks = new List<double>();
        this.Strategy = strategy;
    }
    public void Add(double price, int quantity)
    {
        this.drinks.Add(this.Strategy.GetActPrice(price * quantity));
    }
  // Payment of bill
     public void PrintBill()
    {
        double sum = 0;
        foreach (var drinkCost in this.drinks)
        {
            sum += drinkCost;
        }
        Console.WriteLine($"Total due: {sum}.");
        this.drinks.Clear();
    }
}
}