using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Video 1: 
             
            Console.WriteLine("Hello World!"); //bir alt satıra iner
            Console.Read();//enter tuşuna basınca konsolda bir alt satıra geçer
            Console.Write("omer");//bir alt satıra inmez
            Console.ReadKey();//herhangibir tuşa basılınca konsolda alt satıra geçilecek
            Console.Write(" ali");
            */


            /*
            Video 2: 
            
            Console.Write("Adınız nedir?");
            Console.ReadLine();
            Console.Write("Soyadınız nedir?");
            Console.ReadLine();
            Console.Write("İyi günler");
            */

            /*
            Alıştırma 1: 
           
            Console.WriteLine("Kaç yaşındasınız?");
            Console.ReadLine();
            Console.Write("Mesleğiniz?");
            Console.ReadLine();
            Console.Write("Herhangi bir tuşa basarak uygulamayı tamamlayabilirsiniz.");
            Console.ReadKey();
             */


            /*
            Video 3:
            
            //ctrl+k+d kodların satırlarını ve boşluklarını düzenler

            string name = "OMER";


            Console.WriteLine("Adım " + name);

            string surname = Console.ReadLine();

            Console.WriteLine("Adım " + name + " Soyadım " + surname);
            */


            /*
            Alıştırma 2: 
            
            Console.WriteLine("En sevdiğiniz meyve nedir?");

            string meyve = Console.ReadLine();

            Console.WriteLine("En sevdiğiniz tatlı hangisi?");

            string tatlı = Console.ReadLine();

            Console.WriteLine("Dur tahmin ediyorum. En sevdiğin tatlı: " + tatlı);
            Console.WriteLine("En sevdiğin meyve: " + meyve);
            Console.Read();
            */

            /* Video 4

            float maas = 9020.80F;
            int yas = 20;
            char harf = 'A';
            */

            /* Video 5
             float ucgeninDikKenari = 20;
            float ucgeninAltKenari = 20;
            float alan = ucgeninDikKenari * ucgeninAltKenari / 2;
            Console.WriteLine("Dik kenari: " + ucgeninDikKenari + ", Alt Kenari: " + ucgeninAltKenari + " olan ucgenin alani= " + alan);

            string name = "omer";
            string surname = "fidan";
            string fullName = name + " " + surname;
            Console.WriteLine(fullName);
             */

            /* Video 6
             
            int number1 = 5;
            number1 = number1 + 1;
            Console.WriteLine(number1);
            number1++;
            Console.WriteLine(number1);
            */

            string kucukKenar=Console.ReadLine();
            string buyukKenar = Console.ReadLine();

            int kucukK = int.Parse(kucukKenar);

            kucukKenar = kucukK.ToString();

            Console.WriteLine(kucukK * 2);
            Console.WriteLine(kucukKenar+" Bir string");
            string numberString = "150";
            int numberInteger = Convert.ToInt32(numberString);
            Console.WriteLine("Bu artık bi integer" + (numberInteger * 2));

        }
    }
}
