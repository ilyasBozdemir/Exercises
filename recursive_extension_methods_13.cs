using System;
class recursive_extension_methods_13
{
    public static void Main()
    {
       
/*
Rekürsif fonksiyon kendi kendini çağırma yeteneğine sahip olduğu için kullanırken 
çok dikkatli olmak gerek. En büyük sorunlardan biri sonsuz döngüye neden olmalı.
Bu da System.StackOverflowException olarak bilinen hataya neden olur.
Yani belleğin stack bölgesinde bu fonksiyon çağrımı için ayrılan alan tükenmiştir.
 Yinelemeli olarak yaptığınız işe bağlı olarak risk de artar.
*/
Console.WriteLine(Faktoriyel(5));
/*c-extension-methods genişletebilir methoddur*/
int sayi = 23, sayi2 = 6;
Console.WriteLine(sayi.IsPrime());
Console.WriteLine(sayi2.IsPrime());

    }
   
   int Faktoriyel(int sayi)
{
    if (sayi == 0) return 1;
    else return sayi * Faktoriyel(sayi - 1);
}
static class MyExtensions
{
    public static bool IsPrime(this int sayi)
    {
        int sayac = 0;
        for (int i = 2; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                sayac++;
                break;
            }
        }
        if (sayac == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
    
}