using System;
using Xunit;
using Facade_Design_Pattern;
public class RestaurantServiceTesting
{
[Fact]
public void PatronNameShould__Return_Shashank(){
    Patron Patroonname=new Patron("Shashank");
    Assert.Equal("Shashank",Patroonname.Name);
}
[Fact]
public void DishId_ShouldReturn_10()
{
ColdPrep cold=new ColdPrep();
cold.PrepDish(10);
Assert.Equal(10,10);
 
}
[Fact]
public void DishId_For_ColdPrep(){
    HotPrep hotPrep=new HotPrep();
  hotPrep.PrepDish(20);
    Assert.Equal(10,20);
}
}

   

    
