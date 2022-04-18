using System;
class algoritma_3
{
    public static void Main()
    {
Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
int n = int.Parse(Console.ReadLine());
string[] kelimeDizisi = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i+1}. Kelimeyi Giriniz.");
    kelimeDizisi[i] = Convert.ToString(Console.ReadLine());
}
foreach (var kelime in kelimeDizisi)
{
    Console.WriteLine(kelime);
}
Console.WriteLine("------------");
Array.Reverse(kelimeDizisi);
foreach (var kelime in kelimeDizisi)
{
    Console.WriteLine(kelime);
}
    }
}