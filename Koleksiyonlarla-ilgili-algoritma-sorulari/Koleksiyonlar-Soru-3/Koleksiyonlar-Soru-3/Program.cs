using System.Collections;

ArrayList vowelsArray = new ArrayList();
string vowels = "aeıioöuü";
Console.Write("Cümle girin : ");
var data = Console.ReadLine();

for (int i = 0; i < data.Length; i++)
    if (vowels.Contains(data[i]))
        vowelsArray.Add(data[i]);
Console.WriteLine("Sesli Harfler :");
foreach (var item in vowelsArray)
    Console.Write($"{item},");


