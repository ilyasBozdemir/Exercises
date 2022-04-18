using System;
class datetime_math_15
{
    public static void Main()
    {
     DateTime dt = DateTime.Now;
Console.WriteLine("dt (DateTime.Now): " + dt);
Console.WriteLine("dt.Date: " + dt.Date);
Console.WriteLine("dt.Month: " + dt.Month);
Console.WriteLine("dt.Year: " + dt.Year);
Console.WriteLine("dt.Hour: " + dt.Hour);
Console.WriteLine("dt.Minute: " + dt.Minute);
Console.WriteLine("dt.Second: " + dt.Second);
Console.WriteLine("dt.DayOfWeek: " + dt.DayOfWeek);
Console.WriteLine("dt.DayOfYear: " + dt.DayOfYear);
Console.WriteLine("dt.ToLongDateString(): " + dt.ToLongDateString());
Console.WriteLine("dt.ToShortDateString(): " + dt.ToShortDateString());
Console.WriteLine("dt.ToLongTimeString(): " + dt.ToLongTimeString());
Console.WriteLine("dt.ToShortTimeString(): " + dt.ToShortTimeString());
Console.WriteLine("dt.AddDays(5): " + dt.AddDays(5));
Console.WriteLine("dt.AddHours(7): " + dt.AddHours(7));
Console.WriteLine("dt.AddSeconds(45): " + dt.AddSeconds(45));
Console.WriteLine("dt.AddMonths(5): " + dt.AddMonths(5));
Console.WriteLine("dt.AddYears(5): " + dt.AddYears(5));
Console.WriteLine("dt..AddYears(5): " + dt.AddMilliseconds(100));
//DateTime Format
Console.WriteLine("dd: " + dt.ToString("dd"));
Console.WriteLine("ddd: " + dt.ToString("ddd"));
Console.WriteLine("dddd: " + dt.ToString("dddd"));
Console.WriteLine("MM: " + dt.ToString("MM"));
Console.WriteLine("MMM: " + dt.ToString("MMM"));
Console.WriteLine("MMMM: " + dt.ToString("MMMM"));
Console.WriteLine("yy: " + dt.ToString("yy"));
Console.WriteLine("yyy: " + dt.ToString("yyy"));
//daha fazlası için :
//https://docs.microsoft.com/tr-tr/dotnet/standard/base-types/custom-date-and-time-format-strings
//Math Kütüphanesi
Console.WriteLine(Math.Abs(-75));
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));
Console.WriteLine(Math.Ceiling(22.3));
Console.WriteLine(Math.Round(22.3));
Console.WriteLine(Math.Round(22.7));
Console.WriteLine(Math.Floor(22.7));
Console.WriteLine(Math.Max(6, 5));
Console.WriteLine(Math.Min(23, 89));
Console.WriteLine(Math.Pow(2, 8));
Console.WriteLine(Math.Sqrt(49));
Console.WriteLine(Math.Log(15));
Console.WriteLine(Math.Log10(45));






    }
}