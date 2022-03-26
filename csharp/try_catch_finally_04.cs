using System;
class try_catch_finally_04 {
  public static async void Main() 
  {
   //try => { Hataya sebebiyet verme ihtimali olan kod }
//catch => { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
//finally => { Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }

//senaryo bir sayı giricez arasına sayı dısında karakter katıcaaz
//hatayı yakalamak adına
//kullanııcı sayı giricek ama harfe de bastı mesela..
Console.WriteLine("Ornek 1");
bool BasariDurumu = true;
string DurumMesaji = "";
try
{
    string ReadLineText = "14523x";
    int sayi = int.Parse(ReadLineText);
    Console.WriteLine(sayi);
}
catch (Exception e) 
{
    BasariDurumu = false;
    Console.WriteLine("Hata Oluştu :" + e.Message);
}
finally
{
    DurumMesaji = (BasariDurumu) ? "Başarıyla" : "Hata İle";
    Console.WriteLine("Program {0} Çalıştı..", DurumMesaji);
}
Console.WriteLine();
Console.WriteLine("Ornek 2");
BasariDurumu = false;
try
{
    string ReadLineText = "53";
    byte sayi = byte.Parse(ReadLineText);
    Console.WriteLine(sayi);
}
catch (Exception e)
{
    BasariDurumu = false;
    Console.WriteLine("Hata Oluştu :" + e.Message);
}
finally
{
    DurumMesaji = (!BasariDurumu) ? "Başarıyla" : "Hata İle";
    Console.WriteLine("Program {0} Çalıştı..", DurumMesaji);
}

  }
  
}