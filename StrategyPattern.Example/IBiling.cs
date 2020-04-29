using System;
namespace StrategyPattern.Example
{
 public interface IBillingStrategy
{
    double GetActPrice(double rawPrice);
}
// Normal billing strategy (unchanged price)
class NormalStrategy : IBillingStrategy
{
    public double GetActPrice(double rawPrice) => rawPrice;
}
// Strategy for Happy hour (50% discount)
class HappyHourStrategy : IBillingStrategy
{
    public double GetActPrice(double rawPrice) => rawPrice * 0.5;
}
}
