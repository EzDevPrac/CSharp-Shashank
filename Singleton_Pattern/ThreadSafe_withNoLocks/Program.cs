using System;

 namespace singleton_Pattern
{
    
    public class Singleton
{

 private static Singleton instance = new Singleton();
 private string Name{get;set;}
 private string IP{get;set;}
 static Singleton()
 {

 }
 private Singleton()
 {
Console.WriteLine("Singleton Intance");
 Name = "Server1";
 IP = "192.168.1.23";
 }
public static Singleton Instance
 {
 get
 {
    return Singleton.instance;
}
 }
 public void Show()
 {
 Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
 }
}


class Program
{
 static void Main(string[] args)
 {
 Singleton.Instance.Show();
 Singleton.Instance.Show();

 Console.ReadKey();
 }
}
}


