using Xunit;
using System.Collections.Generic;
using BuilderPattern.Testing;

public class vehcileTesting{
   
 [Fact]
  public void VehicleModel_ShouldReturn_Hero()
  {
  
     Vehicle vehicle=new Vehicle();
        vehicle.Model="Hero";
        Assert.Equal("Hero","Hero");
 }
[Fact]
 public void VehicleModel_ShouldReturn_Honda()
 {
     Vehicle vehicle=new Vehicle();
     vehicle.Model="Honda";
     Assert.Equal("Honda","Honda");
 }
 [Fact]
 public void VehicleEngine_ShouldReturn_4_Stroke()
 {
        Vehicle vehicle=new Vehicle();
        vehicle.Engine="4 Stroke";
        Assert.Equal("4 Stroke","4 Stroke");
 }
 [Fact]
 public void VehicleTransmission_ShouldReturn_125KmPerHr()
 {
 Vehicle vehicle=new Vehicle();
 vehicle.Transmission="125 km/hr";
 Assert.Equal("125 km/hr","125 km/hr");
 }

  [Fact]
 public void VehicleAccessories_ShouldReturn_Helmet()
 {
 Vehicle vehicle=new Vehicle();

        var expected =new List<string>();
        expected.Add("Helmet");
        var actual =new List<string>();
        actual.Add("Helmet");
         Assert.Equal(expected,actual);
 }
 [Fact]
  public void VehicleAccessories_ShouldReturn_Seat()
 {
         Vehicle vehicle=new Vehicle();
        var expected =new List<string>();
        expected.Add("Seat Cover");
        var actual =new List<string>();
        actual.Add("Seat Cover");
        Assert.Equal(expected,actual);
 }
}
 
