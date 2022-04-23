using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo_app
{
    public class ToDo
    {
        public static int sayac = 0;
        public int Id
        {
            get { return sayac; }
            private  set { sayac = value;}
        }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyukluk Buyukluk { get; set; }
        public Board Board { get; set; }

        public ToDo()
        {
            sayac += 1;
            Id = sayac;
        }
    }
    public  class ToDos
    {
        public static List<ToDo> toDoList;
        public List<ToDo> ToDoList
        {
            get { return toDoList; }
            private set { toDoList = value; }
        }
        public ToDos()
        {
            ToDoList = new List<ToDo>();
            ToDoList.Add(new ToDo()
            {
                Baslik = "Baslik 1",
                AtananKisi = "Kisi 1",
                Icerik = "icerik 1",
                Board = Board.DONE,
                Buyukluk = Buyukluk.M
            });
            ToDoList.Add(new ToDo()
            {
                Baslik = "Baslik 2",
                AtananKisi = "Kisi 2",
                Icerik = "icerik 2",
                Board = Board.IN_PROGRESS,
                Buyukluk = Buyukluk.XS
            });
            ToDoList.Add(new ToDo()
            {
                Baslik = "Baslik 3",
                AtananKisi = "Kisi 3",
                Icerik = "icerik 3",
                Board = Board.IN_PROGRESS,
                Buyukluk = Buyukluk.L
            });
            ToDoList.Add(new ToDo()
            {
                Baslik = "Baslik 4",
                AtananKisi = "Kisi 4",
                Icerik = "icerik 4",
                Board = Board.TODO,
                Buyukluk = Buyukluk.XL
            });
        }
        public void AddTodo(ToDo toDo)
        {
            toDoList.Add(toDo);
        }
    }
    public class TakimUyesi
    {
        public int Id { get; set; }
        public int Ad { get; set; }
    }
    public enum Buyukluk
    {
        XS,
        S,
        M,
        L,
        XL
    }
    public enum Board
    {
        TODO,
        IN_PROGRESS,
        DONE
    }  
}
