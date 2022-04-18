using System;
class generic_koleksiyonlar_16
{
    public static void Main()
    {

        List<string> renkler = new List<string>();
        renkler.Add("Mavi");
        renkler.Add("Kırmızı");
        renkler.Add("Turuncu");
        renkler.Add("Yeşil");
        renkler.Add("Mor");
        renkler.Add("Sarı");

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(34);
        sayiListesi.Add(12);
        sayiListesi.Add(4);
        sayiListesi.Add(90);
        sayiListesi.Add(54);

        //Count
        Console.WriteLine("renkler.Count: " + renkler.Count);
        Console.WriteLine("sayiListesi.Count: " + sayiListesi.Count);

        //foreach
        foreach (var renk in renkler)
        {
            Console.Write($"{renk} ");
        }
        Console.Write($"\n");
        foreach (var sayi in sayiListesi)
        {
            Console.Write($"{sayi} ");
        }
        //listeden elemen cıkarma
        renkler.Remove("Sarı");
        sayiListesi.RemoveAt(0);
        foreach (var renk in renkler)
        {
            Console.Write($"{renk} ");
        }
        Console.Write($"\n");
        foreach (var sayi in sayiListesi)
        {
            Console.Write($"{sayi} ");
        }
        Console.WriteLine();
        //liste içinde aramaa
        string arananRenk = "Yeşil";
        if (renkler.Contains(arananRenk))
        {
            Console.WriteLine($"{arananRenk} Liste içinde yer alıyor.");
        }
        Console.WriteLine($"{renkler.BinarySearch(arananRenk)}");
        //diziyi list'e çevirme
        string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Ceylan" };

        List<string> hayvanListesi = new List<string>(hayvanlar);
        hayvanListesi.Clear();//listeyi temizle

        List<Kullanicilar> kullanicilar = new List<Kullanicilar>();

        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "ilyas";
        kullanici1.Soyisim = "bozdemir";
        kullanici1.Yas = 26;
        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "namık";
        kullanici2.Soyisim = "kemal";
        kullanici2.Yas = 20;
        kullanicilar.Add(kullanici1);
        kullanicilar.Add(kullanici2);
        kullanicilar.Add(new Kullanicilar()
        {
            Isim = "Deniz",
            Soyisim = "Tekir",
            Yas = 30
        });
    }

}
public class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}