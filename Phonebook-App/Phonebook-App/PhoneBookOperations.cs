using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_App
{
    public class PhoneBookOperations
    {
        PhoneBookList bookList = new PhoneBookList();
        public void YeniNumaraEkle(PhoneBook phoneBook)
        {
            bookList.AddPhoneBook(phoneBook);
        }
        public bool NumaraSil(string key)
        {
            var _phoneBook = PhoneBookList.phoneBookList.Where(n => n.Isim == key || n.Soyad == key)
                .FirstOrDefault();
            return PhoneBookList.phoneBookList.Remove(_phoneBook);
        }
        public void NumaraGuncelle(string key, string no)
        {
            var _phoneBook = PhoneBookList.phoneBookList.
                Where(n => n.Isim == key || n.Soyad == key)
                .FirstOrDefault();

            var indexOf = PhoneBookList.phoneBookList.IndexOf(_phoneBook);
            var temp = PhoneBookList.phoneBookList[indexOf];
            temp.TelNo = no;
            PhoneBookList.phoneBookList[indexOf] = temp;

        }
        public void RehberiListele(SiralamaKriteri kriter)
        {
            var list = from phoneBookList in PhoneBookList.phoneBookList
                       orderby phoneBookList.Isim ascending
                       select phoneBookList;
            if (kriter == SiralamaKriteri.Z_A)
                list = from phoneBookList in PhoneBookList.phoneBookList
                       orderby phoneBookList.Isim descending
                       select phoneBookList;
            RehberiListele(list);
        } 
        private void RehberiListele(IOrderedEnumerable<PhoneBook> list)
        {
            RehberiListele(list.ToList());
        }
        private void RehberiListele(List<PhoneBook> phoneBookList)
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var item in phoneBookList)
            {
                Console.WriteLine();
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.TelNo);
            }
        }
        public void ListedeAra(Kriter kriter, string key)
        {
            var list = PhoneBookList.phoneBookList;
            switch (kriter)
            {
                case Kriter.IsimveyaSoyisim:
                    list = list.Where(n => n.Isim.StartsWith(key) || n.Soyad.StartsWith(key)).ToList();
                    RehberiListele(list);
                    break;
                case Kriter.TelefonNumarasi:
                    list = list.Where(n => n.TelNo.StartsWith(key)).ToList();
                    RehberiListele(list);
                    break;
            }
        }
    }
}
