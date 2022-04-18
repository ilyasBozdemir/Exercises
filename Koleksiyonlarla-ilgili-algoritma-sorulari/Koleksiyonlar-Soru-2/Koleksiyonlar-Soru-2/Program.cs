int index = 0, sayi, val = 20, kucukSayiOrt = 0, buyukSayiOrt = 0;
int[] number = new int[val];
Console.WriteLine($"{val} adet pozitif sayı girişi yapın");
while (index < val)
{
    Console.Write($"{index + 1}. sayıyı girin:");
    int.TryParse(Console.ReadLine(), out sayi);
    number[index] = sayi;
    index++;
}
Console.Write("Tüm Sayılar : ");
foreach (var item in number)//tek satırlık döngülerde veya iflerde 
    Console.Write($"{item} ");//süslü parantez kalksa da sorun olmaz :>
Console.WriteLine();
int tempNum = 0;
//küçükten büyüğe sıralama.
for (int i = 0; i < number.Length; i++)
    for (int j = i + 1; j < number.Length; j++)
        if (number[j] < number[i])
        {
            tempNum = number[j];
            number[j] = number[i];
            number[i] = tempNum;
        }

Console.WriteLine("küçükten büyüğe sıralama");
foreach (var item in number)
    Console.Write($"{item} ");
Console.WriteLine();
Console.Write("En Küçük 3 Sayı :");

for (int i = 0; i < number.Length; i++)
    if (i < 3)
    {
        kucukSayiOrt += number[i];
        Console.Write($"{number[i]} "); 
    }
kucukSayiOrt = kucukSayiOrt / 3;
Console.Write($"Küçük sayı ortalaması : {kucukSayiOrt}");
Console.WriteLine();

Console.Write("En Büyük 3 Sayı :");
for (int i = 0; i < number.Length; i++)
    if (i > (number.Length - 4))
    {
        buyukSayiOrt += number[i];
        Console.Write($"{number[i]} ");
    }
buyukSayiOrt = buyukSayiOrt / 3;
Console.Write($"Büyük sayı ortalaması : {buyukSayiOrt }");
Console.WriteLine();
int sonucOrt = (kucukSayiOrt + buyukSayiOrt) / 2;
Console.WriteLine($"buyuk kucuk sayi ortalaması :{sonucOrt}");

Console.Read();