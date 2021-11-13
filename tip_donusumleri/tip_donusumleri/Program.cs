using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm) => Kapasitesi düşük değişkenlerin kapasitesi büyük değişkene atanması (Makine tarafından otomatik yapılır)

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "Emre";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);


            // Explicit Conversion (Bilinçli Dönüşüm) => C#'ın kendi kendine yapamadığı dönüşümdür. Convert, parse, toString gibi ifadelerle yapılır.

            int x = 4;
            byte y = (byte)x; // cast işlemi
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);


            // ToString Metodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);


            // System.Convert

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);


            // Parse => String ifadeleri dönüştürmek için kullanılır.

            ParseMethod();


            Console.ReadKey();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1:" + rakam1);
            double1 = double.Parse(metin2);
            Console.WriteLine("double1:" + double1);

            Console.ReadKey();

        }
    }
}
