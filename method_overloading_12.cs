using System;
class method_overloading_12
{
    public static  void Main()
    {
        //aynı zamanda  Console.WriteLine methodu da aşırı yüklenmiştir.
        EkranaYazdir("ilyas");
        EkranaYazdir(67);
        EkranaYazdir(5.5);
    }
  static  void EkranaYazdir(string data)
  {
    Console.WriteLine(data);
  }  
   static  void EkranaYazdir(float data)
  {
    Console.WriteLine(data);
  }  
  static  void EkranaYazdir(int data)
  {
    Console.WriteLine(data);
  } 
   static  void EkranaYazdir(float data)
  {
    Console.WriteLine(data);
  } 
}