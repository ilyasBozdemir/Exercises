using System;
class algoritma_2
{
    public static void Main()
    {
        Console.WriteLine("2 pozitif sayı giriniz: ");
int m, n;
Console.Write("m: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("n: ");
int.TryParse(Console.ReadLine(), out n);
//n adet pozitif sayı girmesini isteyin.
Console.WriteLine($"{n} adet pozitif sayı girin: ");

int[] nSayiDizisi = new int[n];
for (int i = 0; i < nSayiDizisi.Length; i++)
{
    Console.Write($"{i+1}. Sayıyı Girin: ");
    int.TryParse(Console.ReadLine(), out nSayiDizisi[i]);
}
for (int i = 0; i < nSayiDizisi.Length; i++)
{
    if (nSayiDizisi[i] % m == 0)
        Console.WriteLine($"{nSayiDizisi[i]} m sayısına tam bölünmektedir.");
    if (nSayiDizisi[i] == m)
        Console.WriteLine($"{nSayiDizisi[i]} m sayısına eşittir.");
}

    }
}