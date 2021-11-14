﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            // Expression -> Kontrol etmek istenen koşul

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;


                //default: => Kullanımı zorunlu değildir
                //    break;
            }






            Console.ReadKey();
        }
    }
}
