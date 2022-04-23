using Phonebook_App;
string[] ozellikler =
    {
       "Yeni Numara Kaydetmek",
       "Varolan Numarayı Silmek",
       "Varolan Numarayı Güncelleme",
       "Rehberi Listelemek",
       "Rehberde Arama Yapmak"
    };
basla: byte sayac = 0;
anaSecim: Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
Console.WriteLine("*******************************************");
foreach (var ozellik in ozellikler)
{
    sayac++;
    Console.WriteLine($"({sayac}) {ozellik}");
}
int secim;
PhoneBookOperations operations = new PhoneBookOperations();
PhoneBook phoneBook;
int.TryParse(Console.ReadLine(), out secim);
switch (secim)
{
    #region case 1: 
    case 1:
        Console.Clear();
        phoneBook = new PhoneBook();
        Console.Write("Lütfen isim giriniz             : ");
        phoneBook.Isim = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          : ");
        phoneBook.Soyad = Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz : ");
        phoneBook.TelNo = Console.ReadLine();
        operations.YeniNumaraEkle(phoneBook);
        break;
    #endregion
    #region  case 2:
    case 2:
        phoneBook = new PhoneBook();
yenidenSil:
        Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        string AdveyaSoyad = Console.ReadLine();
        var _phoneBook = PhoneBookList.phoneBookList
            .Where(n => n.Isim == AdveyaSoyad || n.Soyad == AdveyaSoyad)
           .FirstOrDefault();
        if (_phoneBook is null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.Write("* Silmeyi sonlandırmak için : (1)");
            Console.Write("* Yeniden denemek için      : (2)");
            int.TryParse(Console.ReadLine(), out secim);
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    goto anaSecim;
                    break;
                case 2:
                    Console.Clear();
                    goto yenidenSil;
                    break;
                default:
                    break;
            }
        }
        else
        {
silmeOnay:
            Console.WriteLine($"{AdveyaSoyad} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
            string onayDurumu = Console.ReadLine();
            bool sonuc = false;
            if (onayDurumu.ToLower() == "y")
            {
                sonuc = operations.NumaraSil(AdveyaSoyad);
                goto anaSecim;
            }
            else if (onayDurumu.ToLower() == "n")
            {
                goto anaSecim;
            }
            else
                goto silmeOnay;
        }
        break;
    #endregion
    #region  case 3:
    case 3:
        phoneBook = new PhoneBook();
yenidenGuncelle:
        string YeniNo = "";

        Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
        AdveyaSoyad = Console.ReadLine();
        _phoneBook = PhoneBookList.phoneBookList
           .Where(n => n.Isim == AdveyaSoyad || n.Soyad == AdveyaSoyad)
          .FirstOrDefault();
        if (_phoneBook is null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.Write("* Güncellemeyi sonlandırmak için : (1)");
            Console.Write("* Yeniden denemek için      : (2)");
            int.TryParse(Console.ReadLine(), out secim);
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    goto anaSecim;
                    break;
                case 2:
                    Console.Clear();
                    goto yenidenGuncelle;
                    break;
                default:
                    break;
            }
        }
        else
        {
guncellemeOnay:
            Console.Write("yeni numara girin: ");
            YeniNo = Console.ReadLine();
            Console.WriteLine($"{AdveyaSoyad} isimli kişi rehberden güncellenmek üzere, onaylıyor musunuz ?(y/n)");
            string onayDurumu = Console.ReadLine();
            if (onayDurumu.ToLower() == "y")
            {
                operations.NumaraGuncelle(AdveyaSoyad, YeniNo);
                goto anaSecim;
            }
            else if (onayDurumu.ToLower() == "n")
            {
                goto anaSecim;
            }
            else
                goto guncellemeOnay;
        }

        operations.NumaraGuncelle(AdveyaSoyad, YeniNo);

        break;
    #endregion
    #region case 4:
    case 4:
        Console.Clear();
        SiralamaKriteri siralamaKriteri = SiralamaKriteri.A_Z;
        Console.WriteLine("Lütfen sıralama kriteri seçin: ");
        Console.WriteLine("**********************************************");
        Console.WriteLine("[A-Z] seçimi için (1)");
        Console.WriteLine("[Z-A] seçimi için (2)");
        string kriter = Console.ReadLine();
        if (kriter == "1")
        {
             operations.RehberiListele(SiralamaKriteri.A_Z);
        }
        else if (kriter == "2")
        {
            operations.RehberiListele(SiralamaKriteri.Z_A);
        }
        break;
    #endregion
    #region  case 5:
    case 5:
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        kriter = Console.ReadLine();
  
        Kriter secimKriter = (kriter == "1") ? Kriter.IsimveyaSoyisim : Kriter.TelefonNumarasi;
        operations.ListedeAra(secimKriter, kriter);
        break;
    #endregion
    #region default:
    default:
        Console.Clear();
        Console.WriteLine("Listeden Seçim Yapın!");
        goto basla;
        #endregion
}


