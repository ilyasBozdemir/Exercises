using System;
class algoritma_4
{
    public static void Main()
    {
Console.Write("Bir Cümle Giriniz: ");
string cumle = Convert.ToString(Console.ReadLine());

Console.WriteLine($"Verilen Cümlede {cumle.Split(" ").Length} Kelime Vardır.");
Console.WriteLine($"Verilen Cümlede {cumle.Replace(" ", "").Length} Harf Vardır." );
    }
}