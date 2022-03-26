using System;
class karar_yapilari_05
{
    public static async void Main()
    {
        const string UserName = "ilyasB";//const kullanımı değişkenin değerini sabitlemek içindir. sonradan değer atanamaz.
        const string Password = "DmQZNbSe";//amaç u:p bilgilerinin veritabanından çekilirmiş gibi göstermek.

        Console.Write("UserName Giriniz : ");
        string U = Console.ReadLine();
        Console.Write("Password Giriniz : ");
        string P = Console.ReadLine();

        string BasariliMesaj = "Başarıyla Giriş Yapılmıştır.";
        string BasarisizMesaj = "UserName ve Password Yanlış. Lütfen Tekrar Deneyiniz.";
        string EksikMesaj = "UserName veya Password Yanlış. Lütfen Tekrar Deneyiniz.";


        if (U == UserName && P == Password)
        {
            Console.WriteLine(BasariliMesaj);
        }
        else if (U == UserName || P == Password)
        {
            Console.WriteLine(EksikMesaj);
        }
        else
        {
            Console.WriteLine(BasarisizMesaj);
        }
        Console.WriteLine("ternary ile");

        string Sonuc = (U == UserName && P == Password) ? BasariliMesaj : EksikMesaj;

        Console.WriteLine(Sonuc);




    }
}