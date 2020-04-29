using System;
using Xunit;
using CustomerStrategy.test;

namespace CustomerStrategy.test
{
    public class customerStrategy
    {
[Fact]
public void PriceShouldReturn_10()
{
HappyHourStrategy happyHourStrategy=new HappyHourStrategy();
Assert.Equal(5,happyHourStrategy.GetActPrice(10));
}
[Fact]
public void NormalCustomerShouldGetActualPrice(){
    NormalStrategy normalStrategy=new NormalStrategy();
   Assert.Equal(10,normalStrategy.GetActPrice(10));
}
}
}