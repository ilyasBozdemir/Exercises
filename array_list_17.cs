using System;
using System.Collections;
class array_list_17
{
    public static void Main()
    {
        ArrayList dizi = new ArrayList();
        dizi.Add("Kedi");
        dizi.Add(99);
        dizi.Add(true);
        dizi.Add('A');
        Console.WriteLine(dizi[1] + "\n");
        foreach (var item in dizi)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("AddRange() ile ekleme");
        dizi.AddRange(new string[] { "Sarı", "Kırmızı" });

        foreach (var item in dizi)
        {
            Console.WriteLine(item);
        }
        dizi.Clear();
        Console.WriteLine("Sort() ile sıralama");
        dizi.AddRange(new int[] { 12, 1, 23, 96, 78, 5, 4, 2, 3, 6, 5, 78, 25 });
        dizi.Sort();
        foreach (var item in dizi)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Reverse() ile sıralama ,diziyi ters çevirme");
        dizi.Reverse();
        foreach (var item in dizi)
        {
            Console.WriteLine(item);
        }

    }
}