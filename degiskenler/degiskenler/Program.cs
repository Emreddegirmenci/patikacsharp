using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;    // 1 byte
            sbyte s = 5;   // 1 byte

            short sh = 5;   // 2 byte
            ushort us = 5;  // 2 byte

            Int16 i16 = 2;   // 2 byte
            int i = 2;       // 4 byte
            Int32 i32 = 2;   // 4 byte
            Int64 i64 = 2;   // 8 byte

            uint ui = 2;     // 4 byte
            long l = 4;      // 4 byte
            ulong ul = 4;    // 8 byte

            // Reel Sayılar
            float f = 5; // 4 byte
            double d = 5; // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';  // 2 byte
            string str = "Emre";  // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime d1 = DateTime.Now;

           // Console.WriteLine(d1);
            // Console.ReadKey();


            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;

            // bool
            bool bool1 = 10 > 2;

            // Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();

            //Console.WriteLine(yeniDeger);
            //Console.ReadKey(); // Çıktı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            // Console.WriteLine(int21);
            // Console.ReadKey(); // Çıktısı 40

            // PARSE

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);
                     // Çıktısı 40

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);


            // Saat
            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);

            Console.ReadKey();
        }
       
        
    }
}
