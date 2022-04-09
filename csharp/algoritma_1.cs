using System;
class algoritma_1
{
    public static void Main()
    {
Console.WriteLine("Pozitif bir sayı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
if (n <= 0)
    Console.WriteLine("Pozitif bir sayı giriniz: ");

Console.WriteLine($"{n} adet pozitif sayı giriniz: ");

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int item  in array)
{
    if (item%2==0)
    {
        Console.WriteLine($"{item} pozitif bir sayıdır.");
    }
}
    }
}