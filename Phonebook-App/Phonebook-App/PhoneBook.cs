using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_App
{
    public class PhoneBook
    {
        public static int id = 0;
        public int Id { get;private set; }
        public string Isim { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public PhoneBook()
        {
            id += 1;
            Id = id;
        }
    }
    public class  PhoneBookList
    {
        public static  List<PhoneBook> phoneBookList { get; set; }
        public PhoneBookList()
        {
            phoneBookList = new List<PhoneBook>();
            phoneBookList.Add(new PhoneBook
            {
                Isim = "Ali",
                Soyad = "Teker",
                TelNo = "576124897"
            });
            phoneBookList.Add(new PhoneBook
            {
                Isim = "Mehmet",
                Soyad = "Dağ",
                TelNo = "576124897"
            });
            phoneBookList.Add(new PhoneBook
            {
                Isim = "Ebru",
                Soyad = "Şeker",
                TelNo = "583457647"
            });
            phoneBookList.Add(new PhoneBook
            {
                Isim = "Cevat",
                Soyad = "Dağ",
                TelNo = "5761248972"
            });
            phoneBookList.Add(new PhoneBook
            {
                Isim = "Abdullah",
                Soyad = "Gilik",
                TelNo = "5674521252"
            });
        }
        public void AddPhoneBook(PhoneBook phone)
        {
            phoneBookList.Add(phone);
        }
    }
    public enum SiralamaKriteri
    {
        A_Z,
        Z_A
    }
    public enum Kriter
    {
        IsimveyaSoyisim,
        TelefonNumarasi
    }

}
