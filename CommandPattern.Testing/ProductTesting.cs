using System;
using Xunit;
using CommandPattern.Testing;
public class productTesting{
   

    [Fact]
   public void ProductType_ShouldReturn_Phone()
   {
    Product product=new Product("Phone",500);

        Assert.Equal("Phone",product.Name);
   }
[Fact]

public void ProductPrice_ShouldReturn_5200(){
    Product product=new Product("Phone",5200);
    Assert.Equal(5200,product.Price);
}


}