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
                string baslik = "Başlık      : " + item.Baslik;
                string icerik = "İçerik      : " + item.Icerik;
                string kisi = "Atanan Kişi : " + item.AtananKisi;
                string büyüklük = "Büyüklük    : " + item.Buyukluk;
                Board board = item.Board;
                string todo = $"{baslik}\n{icerik}\n{kisi}\n{büyüklük}\n-";
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

        }
        public void BoarddanKartSil()
        {

        }
        public void KartTasi()
        {

        }
    }

}
