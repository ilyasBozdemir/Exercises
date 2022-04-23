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
        public void BoardListele()
        {
            List<ToDo> toDoList = ToDos.toDoList;
            if (toDoList is not null)
            {
                foreach (var item in toDoList)
                {
                    string baslik = "Başlık      : " + item.Baslik;
                    string icerik = "İçerik      : " + item.Icerik;
                    string kisi = "Atanan Kişi : " + item.AtananKisi;
                    string büyüklük = "Büyüklük    : " + item.Buyukluk;
                    string todo = $"{baslik}\n{icerik}\n{kisi}\n{büyüklük}\n-";
                    ToDoWrite(todo,item.Board);
                }
            }
            else
            {
                foreach (var board in boards)
                {
                    Console.WriteLine($"{board} Line ");
                    Console.WriteLine("************************");
                    Console.WriteLine(" ~ BOŞ ~ ");
                    Console.WriteLine();
                }
            }
        }
        private void ToDoWrite(string todo, Board board)
        {
            //foreach (var brd in boards)
            //{
            //    Console.WriteLine($"{brd} Line ");
            //    Console.WriteLine("************************");
            //    Console.WriteLine(" ~ BOŞ ~ ");
            //    Console.WriteLine();
            //}
            StringBuilder sb = new StringBuilder();


            Console.WriteLine(sb.ToString());
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
