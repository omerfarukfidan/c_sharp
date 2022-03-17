using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Video 1: 
             */
            Console.WriteLine("Hello World!"); //bir alt satıra iner
            Console.Read();//enter tuşuna basınca konsolda bir alt satıra geçer
            Console.Write("omer");//bir alt satıra inmez
            Console.ReadKey();//herhangibir tuşa basılınca konsolda alt satıra geçilecek
            Console.Write(" ali");


            /*
            Video 2: 
            */
            Console.Write("Adınız nedir?");
            Console.ReadLine();
            Console.Write("Soyadınız nedir?");
            Console.ReadLine();
            Console.Write("İyi günler");


            /*
            Alıştırma 1: 
            */
            Console.WriteLine("Kaç yaşındasınız?");
            Console.ReadLine();
            Console.Write("Mesleğiniz?");
            Console.ReadLine();
            Console.Write("Herhangi bir tuşa basarak uygulamayı tamamlayabilirsiniz.");
            Console.ReadKey();



            /*
            Video 3:
            */
            //ctrl+k+d kodların satırlarını ve boşluklarını düzenler

            string name = "OMER";


            Console.WriteLine("Adım " + name);

            string surname = Console.ReadLine();

            Console.WriteLine("Adım " + name + " Soyadım " + surname);



            /*
            Alıştırma 2: 
            */
            Console.WriteLine("En sevdiğiniz meyve nedir?");

            string meyve = Console.ReadLine();

            Console.WriteLine("En sevdiğiniz tatlı hangisi?");

            string tatlı = Console.ReadLine();

            Console.WriteLine("Dur tahmin ediyorum. En sevdiğin tatlı: " + tatlı);
            Console.WriteLine("En sevdiğin meyve: " + meyve);
            Console.Read();








        }
    }
}
