namespace console_programlama
{
    public static class Program
    {
        static void Main()
        {
            Console.Write("İsminizi giriniz: ");
            string isim = Console.ReadLine();

            Console.WriteLine($"Merhaba {isim}");
            Console.Read();
        }
    }
}