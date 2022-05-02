
Gunler gun = Gunler.Pazar;
switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Monday:
        gun = Gunler.Pazar;
        break;
    case DayOfWeek.Tuesday:
        gun = Gunler.Sali;
        break;
    case DayOfWeek.Wednesday:
        gun = Gunler.Carsamba;
        break;
    case DayOfWeek.Thursday:
        gun = Gunler.Persembe;
        break;
    case DayOfWeek.Friday:
        gun = Gunler.Cuma;
        break;
    case DayOfWeek.Saturday:
        gun = Gunler.Cumartesi;
        break;
    case DayOfWeek.Sunday:
        gun = Gunler.Pazar;
        break;
}
Console.WriteLine($"Haftanın {((int)gun) + 1}.günü -> {gun}");
enum Gunler{ Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar};