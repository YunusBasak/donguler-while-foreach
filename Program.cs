using System;

namespace donguler_while__foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1 den başlayarak konsoldan girilen (tek) sayının ortasını hesaplayıp konsole yazdıran program.
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac ++;
                
            }
            Console.WriteLine(toplam/sayi);

            // a'dan z'ye kadar tüm harfleri konsola yazdır.
            char character = 'a';
            while (character < 'z')
            {
                System.Console.Write(character);
                character ++;
            }

            // Foreach
            System.Console.WriteLine(" *** foreach ***");
            string[] arabalar = {"BMW", "Audi", "RR", "Benz"};
             foreach (var araba in arabalar)
             {
                 Console.WriteLine(araba);
             }
        }
    }
}
