
string[] ozellikler = { "Board Listelemek", "Board'a Kart Eklemek", "Board'dan Kart Silmek", "Kart Taşımak" };
anaSecim: 
byte sayac = 0;
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
Console.WriteLine("*******************************************");
foreach (var ozellik in ozellikler)
{
    sayac++;
    Console.WriteLine($"({sayac}) {ozellik}");
}
int secim;
int.TryParse(Console.ReadLine(), out secim);
todo_app.TodoOperations todo = new todo_app.TodoOperations();
switch (secim)
{
    case 1:
        Console.Clear();
        todo.BoardListele();
        break;
    case 2:
        Console.Clear();
        todo.BoardaKartEkle();
        break;
    case 3:
        Console.Clear();
        todo.BoarddanKartSil();
        break; 
    case 4:
        Console.Clear();
        todo.KartTasi();
        break;
    default:Console.Clear();
        Console.WriteLine("Menüden Seçim Yapınız.");
        goto anaSecim;
        break;
}
