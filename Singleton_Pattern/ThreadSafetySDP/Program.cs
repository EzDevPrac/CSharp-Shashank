using System;

 namespace singleton_Pattern
{
     public class Singleton
{
private static Singleton instance = null;
 private string Name{get;set;}
 private string IP{get;set;}
  private Singleton()
 {
 Console.WriteLine("Singleton Intance");
 Name = "Server1";
 IP = "192.168.1.23";
 }
 // Lock synchronization object
private static object syncLock = new object(); 
public static Singleton Instance
 {
 get
 {
lock(syncLock){
 if (instance == null)
 instance = new Singleton();
 return instance;
 }
 }
 } public void Show()
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


