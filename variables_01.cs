using System;
class variables_01
{
    public static void Main()
    {
        //tam sayı değişkenler
        Console.WriteLine("//tam sayı değişkenler");
        byte bSayi = 255;
        sbyte sbSayi = 127;
        Console.WriteLine(bSayi + sbSayi);

        Console.WriteLine("\n//tam sayı değişkenler");
        short sSayi = 32767; //max value
        ushort usSayi = 65535; //max value

        Console.WriteLine("\n//tam sayı değişkenler");
        Int16 i16 = 32767; //max value
        Int32 i32 = 2147483647; //max value
        Int64 i64 = 9223372036854775807L; //max value
        int iSayi = 2147483647; //max value (int = Int32)
        uint uSayi = 4294967295u;//max value = ( int * 2)
        long lSayi = 9223372036854775807L;  //Int64=long         
        ulong ulSayi = 4;

        Console.WriteLine("\n//ondalık değişkenler");
        //ondalık değişkenler
        float f = 3.40282347E+38F;
        double d = 1.7976931348623157E+308;
        decimal de = 5;

        Console.WriteLine("\n//char ve char dizisi(string)");
        //char ve char dizisi(string)

        //105 i, 108 l,  121 y, 97 a, 115 s

        char ch = (char)105; //output: 'i' (ascii karşılığı)
        Console.WriteLine("\n" + ch);

        char[] chars = { (char)105, (char)108, (char)121, (char)97, (char)115 };
        string str = "";

        foreach (var @char in chars)
        {
            str += @char.ToString();
            //str += @char + "";
        }
        Console.Write("\n(char[] chars = { (char)105, (char)108, (char)121, (char)97, (char)115 };) " + str);

        Console.WriteLine(" output : " + str);// \n => new line "Console.WriteLine();" aynı anlama gelir.

        bool b1 = true;
        bool b2 = false;

        Boolean bo1 = true;
        Boolean bo2 = false;

        DateTime dateTime = DateTime.Now;
        Console.WriteLine("\n " + dateTime.ToLongDateString());//1
        Console.WriteLine("\n {0}", dateTime.ToLongDateString());//2
        Console.WriteLine($"\n {dateTime.ToLongDateString()}");//3 kullanımları

        object o1 = "ilyas";
        object o2 = 'i';
        object o3 = 54;
        object o4 = 43.3;
        object o5 = 4.34f;
        object o6 = 4.3m;
        object o7 = 4.3d;
        object o8 = false;

        dynamic o9 = new { name = "ilyas", surname = "bozdemir" };
        //dynamic ile object arasındaki en temel fark, derleme zamanındaki tip uyumsuzluğu kontrolüdür.
        //Bildiğiniz üzere object tipini kullanabilmemiz için unboxing (kutudan çıkarma) yapmamız gerekiyor.
        //Yani bir tip object olarak tanımlanmışsa, karşı tarafta bunun tipinin ne olacağını belirtmeliyiz
        //Kısaca dynamic tipler bizi derleme hataları zahmetinden kurtarmaktadır.
        //ref:https://cemelma.wordpress.com/2019/07/25/c-var-dynamic-object-farki/
        Console.WriteLine("\n " + o9.name);

        var v1 = "var ile değişken bildirimi ";

        var v2 = 0;////dt int tipini temsil etti
        var v3 = 0.1;////dt double tipini temsil etti
        var dt = DateTime.Now;//dt DateTime tipini temsil etti
        var dt2 = DateTime.IsLeapYear(dt.Year);//dt2 bool tipini temsil etti "IsLeapYear()" artık yıl mı değil mi döndürür

        Console.WriteLine("\n " + dt);
        Console.WriteLine("\n " + dt2);

    }
}