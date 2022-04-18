Calisan calisan1 = new Calisan();
calisan1.Adi = "Adnan";
calisan1.Soyadi = "Kara";
calisan1.No = 45454531;
calisan1.Departman = "İnsan kaynakları";
calisan1.CalisanBilgileri();
Console.WriteLine();
Calisan calisan2 = new Calisan("Deniz", "Altın", 12354896, "Yonetim");
calisan1.CalisanBilgileri();
class Calisan
{
    public Calisan(){}
    public Calisan(string Adi, string Soyadi, int No, string Departman)
    {
        this.Adi = Adi;
        this.Soyadi = Soyadi;
        this.No = No;
        this.Departman = Departman;
    }
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