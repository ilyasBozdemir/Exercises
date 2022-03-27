using System;
class switch_case_06
{
    public static async void Main()
    {
        DateTime dateTime = DateTime.Now;
int time = DateTime.Now.Hour;
string[] Messages =
    {
       "Günaydın"/*[0]*/, "İyi Günler"/*[1]*/, "İyi Akşamlar"/*[2]*/, "İyi Geceler"/*[3]*/
    }; //1.kullanım
// 2.kullanım
/*string[] Messages = new string[4];
Messages[0] = "Günaydın";
Messages[1] = "İyi Günler";
Messages[2] = "İyi Akşamlar";
Messages[3] = "İyi Geceler";*/

string Message = "", Today = "";
string[] Days = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

if (time >= 6 && time < 12)
    Message = Messages[0];//tek satır içi süslü parantezler kaldırılabilir.ikinci satıra yazılan döngü dısında olucaktır.
if (time >= 12 && time < 18)
    Message = Messages[1];
if (time >= 18 && time < 0)
    Message = Messages[2];
if (time >= 0 && time < 6)
    Message = Messages[3];

switch (dateTime.DayOfWeek)
{
    case DayOfWeek.Sunday:
        Today = Days[6];
        break;
    case DayOfWeek.Monday:
        Today = Days[0];
        break;
    case DayOfWeek.Tuesday:
        Today = Days[1];
        break;
    case DayOfWeek.Wednesday:
        Today = Days[2];
        break;
    case DayOfWeek.Thursday:
        Today = Days[3];
        break;
    case DayOfWeek.Friday:
        Today = Days[4];
        break;
    case DayOfWeek.Saturday:
        Today = Days[5];
        break;
    //default://bu günler dısında gün olmadığı için default hiç çalışmıycaktır.
    //    break;
}

Console.WriteLine("{0} Bugün Günlerden {1}.", Message, Today);
Console.WriteLine($"{Message} Bugün Günlerden {Today}.");
Console.WriteLine(Message + " Bugün Günlerden " + Today + ".");
    }
}