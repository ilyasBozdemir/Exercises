Console.WriteLine($"Öğrenci sayısı: {Ogrenci.OgrenciSayisi}");

Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Isim = "Deniz";
ogrenci1.Soyisim = "Arda";

Ogrenci ogrenci2 = new Ogrenci();
ogrenci2.Isim = "Ayşe";
ogrenci2.Soyisim = "Yılmaz";

Console.WriteLine($"Öğrenci sayısı: {Ogrenci.OgrenciSayisi}");

class Ogrenci
{
    public static int OgrenciSayisi = 0;
    public string Isim;
    public string Soyisim;
    public Ogrenci()
    {
        OgrenciSayisi += 1;
    }
}
