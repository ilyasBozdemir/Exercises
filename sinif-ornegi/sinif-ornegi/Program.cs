Calisan calisan1 = new Calisan();
calisan1.Adi = "Adnan";
calisan1.Soyadi = "Kara";
calisan1.No = 45454531;
calisan1.Departman = "İnsan kaynakları";
calisan1.CalisanBilgileri();
Calisan calisan2 = new Calisan();
Console.WriteLine();
calisan1.Adi = "Deniz";
calisan1.Soyadi = "Altın";
calisan1.No = 12354896;
calisan1.Departman = "Yonetim";
calisan1.CalisanBilgileri();
class Calisan
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public int No { get; set; }
    public string Departman { get; set; }
    public void CalisanBilgileri()
    {
        Console.WriteLine($"Adi : {Adi}");
        Console.WriteLine($"Soyadi : {Soyadi}");
        Console.WriteLine($"No : {No}");
        Console.WriteLine($"Departman : {Departman}");
    }
}