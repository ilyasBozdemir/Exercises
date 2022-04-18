using System.Collections;
ArrayList arrayList = new ArrayList();
ArrayList primeNumberList = new ArrayList();
ArrayList nonPrimeNumberList = new ArrayList();
int index = 0, sayi, ortalama = 0, val = 20;
Console.WriteLine($"{val} adet pozitif sayı girişi yapın");
while (index < val)
{
    Console.Write($"{index + 1}. sayıyı girin:");
    bool state = 
        int.TryParse(Console.ReadLine(), out sayi);
    if (state && sayi > 0)//int ve pozitif sayi olursa 
    {
        bool isPrimeNumber = SayiAsalMi(sayi);
        if (isPrimeNumber)
            primeNumberList.Add(sayi);
        else
            nonPrimeNumberList.Add(sayi);
        arrayList.Add(sayi);
        index++;
    }
}
Console.Write($"\nGirilen sayılar: ");
foreach (var item in arrayList)
    Console.Write($"{item} ");

primeNumberList.Sort();//küçükten büyüge
primeNumberList.Reverse();//tam tersi büyükten küçüğe

Console.WriteLine($"\nAsal sayılar;");
foreach (var item in primeNumberList)
{ 
    Console.Write($"{item} ");
    ortalama += int.Parse(item + "");
}
ortalama = (ortalama / primeNumberList.Count);
Console.WriteLine($"dizi adedi:{primeNumberList.Count} ortalaması : {ortalama}");
nonPrimeNumberList.Sort();//küçükten büyüge
nonPrimeNumberList.Reverse();//tam tersi büyükten küçüğe
Console.WriteLine("------------------");
Console.WriteLine($"\nAsal olmayan sayılar;");
foreach (var item in nonPrimeNumberList)
{
    Console.Write($"{item} ");
    ortalama += int.Parse(item + "");
}
ortalama = (ortalama / nonPrimeNumberList.Count);
Console.WriteLine($"dizi adedi:{nonPrimeNumberList.Count} ortalaması : {ortalama}");

bool SayiAsalMi(int sayi)
{
    int kontrol = 0;
    for (int i = 2; i < sayi; i++)
        if (sayi % i == 0)
        {
            kontrol = 1;
            break;
        }
    if (kontrol != 1)
        return true;
    return false;
}

Console.Read();