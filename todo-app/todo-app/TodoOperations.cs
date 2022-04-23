using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo_app
{

    public class TodoOperations
    {
        ToDos toDos = new ToDos();
        string[] boards = { "TODO", "IN PROGRESS", "DONE" };
        string bosText = " ~ BOŞ ~ ";
        public void BoardListele()
        {
            List<ToDo> toDoList = ToDos.toDoList;
            if (toDoList is not null)
            {
                ToDoWrite(toDoList);
            }
            else
            {
                foreach (var board in boards)
                {
                    Console.WriteLine($"{board} Line ");
                    Console.WriteLine("************************");
                    Console.WriteLine(bosText + "\n");
                }
            }
        }
        private void ToDoWrite(List<ToDo> toDoList)
        {
            StringBuilder sbToDo = new StringBuilder();
            StringBuilder sbInProgress = new StringBuilder();
            StringBuilder sbDone = new StringBuilder();

            sbToDo.AppendLine($"{boards[0]} Line");
            sbToDo.AppendLine("************************");

            sbInProgress.AppendLine($"{boards[1]} Line");
            sbInProgress.AppendLine("************************");

            sbDone.AppendLine($"{boards[2]} Line");
            sbDone.AppendLine("************************");

            int sToDo = 0, sInProgress = 0, sDone = 0;//sayaclar

            foreach (var item in toDoList)
            {
                string baslik = $"Başlık      : {item.Baslik}";
                string icerik = $"İçerik      : {item.Icerik}";
                string kisi = $"Atanan Kişi : {item.AtananKisi.Ad}";
                string buyukluk = $"Büyüklük    : {item.Buyukluk}";
                Board board = item.Board;
                string todo = $"{baslik}\n{icerik}\n{kisi}\n{buyukluk}\n-";
                switch (board)
                {
                    case Board.TODO:
                        sbToDo.AppendLine($"{todo}");
                        sToDo++;
                        break;
                    case Board.IN_PROGRESS:
                        sbInProgress.AppendLine($"{todo}");
                        sInProgress++;
                        break;
                    case Board.DONE:
                        sbDone.AppendLine($"{todo}");
                        sDone++;
                        break;
                }
            }

            if (sToDo == 0)
                sbToDo.AppendLine(bosText);

            if (sInProgress == 0)
                sbInProgress.AppendLine(bosText);

            if (sDone == 0)
                sbDone.AppendLine(bosText);


            Console.WriteLine(sbToDo + "\n\n");
            Console.WriteLine(sbInProgress + "\n\n");
            Console.WriteLine(sbDone + "\n\n");
        }

        public void BoardaKartEkle()
        {
            ToDo toDo = new ToDo();
            Console.Write("Başlık Giriniz                                  : ");
            string baslik = Console.ReadLine();

            Console.Write("İçerik Giriniz                                  : ");
            string icerik = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            string buyukluk = Console.ReadLine();
            Buyukluk buyuklukEnum = Buyukluk.XS;
            switch (int.Parse(buyukluk))
            {
                case 1:
                    buyuklukEnum = Buyukluk.XS;
                    break;
                case 2:
                    buyuklukEnum = Buyukluk.S;
                    break;
                case 3:
                    buyuklukEnum = Buyukluk.M;
                    break;
                case 4:
                    buyuklukEnum = Buyukluk.L;
                    break;
                case 5:
                    buyuklukEnum = Buyukluk.XL;
                    break;
            }
            Console.Write("Kişi Seçiniz                                    : ");
            string kisi = Console.ReadLine();
            var takimUyesi = ToDos.kisiList.Where(k => k.Ad == kisi).FirstOrDefault();
            if (takimUyesi == null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                Console.Clear();
                BoardListele();
            }
            else
            {
                toDo.Baslik = baslik;
                toDo.Icerik = icerik;
                toDo.AtananKisi = takimUyesi;
                toDo.Board = Board.TODO;
                toDo.Buyukluk = buyuklukEnum;
                toDos.AddTodo(toDo);
            }
        }
        public void KartTasi()
        {
            basaDon:
            Console.Clear();
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();
            var _toDo = ToDos.toDoList.Where(b => b.Baslik == baslik).FirstOrDefault();
            if (_toDo is null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int sec;
                int.TryParse(Console.ReadLine(), out sec);
                switch (sec)
                {
                    case 1:
                        Console.Clear();
                        BoardListele();
                        break;
                    case 2:
                        goto basaDon;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Hatalı seçim");
                        Thread.Sleep(2000);
                        goto basaDon;
                        break;
                }
            }
            else
            {
basla:
                Console.WriteLine("\nBulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");

                string _baslik = $"Başlık      : {_toDo.Baslik}";
                string _icerik = $"İçerik      : {_toDo.Icerik}";
                string _kisi = $"Atanan Kişi : {_toDo.AtananKisi.Ad}";
                string _buyukluk = $"Büyüklük    : {_toDo.Buyukluk}";
                string _line = $"Line        : {_toDo.Board}";

                string todo = $"{baslik}\n{_icerik}\n{_kisi}\n{_buyukluk}\n{_line}\n-";
                Console.WriteLine($"{todo}\n");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO\n(2) IN PROGRESS\n(3) DONE\n");
                int sec;
                int.TryParse(Console.ReadLine(), out sec);
                switch (sec)
                {
                    case 1:
                        _toDo.Board = Board.TODO;
                        break;
                    case 2:
                        _toDo.Board = Board.IN_PROGRESS;
                        break;
                    case 3:
                        _toDo.Board = Board.DONE;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Hatalı seçim");
                        goto basla;
                }
                Console.WriteLine("Taşıma İşlemi Başarılı");
                Thread.Sleep(3000);
                Console.Clear();
                BoardListele();

            }
        }
        public void BoarddanKartSil()
        {
            basaDon:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();
            var _toDo = ToDos.toDoList.Where(b => b.Baslik == baslik).FirstOrDefault();
            if (_toDo is null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int sec;
                int.TryParse(Console.ReadLine(), out sec);
                switch (sec)
                {
                    case 1:
                        Console.Clear();
                        BoardListele();
                        break;
                    case 2:
                        goto basaDon;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Hatalı seçim");
                        goto basaDon;
                        break;
                }
            }
            else
            {
                ToDos.toDoList.Remove(_toDo);
                Console.WriteLine("todo basarıyla silindi.");
                Thread.Sleep(3000);
                Console.Clear();
                BoardListele();
            }
        }
    }
}
