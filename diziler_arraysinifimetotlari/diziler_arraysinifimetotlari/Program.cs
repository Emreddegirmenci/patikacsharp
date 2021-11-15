using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_arraysinifimetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort (Sıralama)

            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            // Sırasız Dizi

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Sıralı Dizi

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // Clear

            Array.Clear(sayiDizisi, 2, 2);
            // Sayı dizisi elemanlarını kullanarak
            // 2.indexten itibaren 2 elemanı 0'lar.

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse
            Array.Reverse(sayiDizisi);
            Console.WriteLine("******* Array Reverse*****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // IndexOf
            Console.WriteLine("******* Array IndexOf*******");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            // Resize
            Console.WriteLine("******* Resize*******");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Resize 2
            Console.WriteLine("******* Resize2*******");
            Array.Resize<int>(ref sayiDizisi, 7);
            //sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }



            Console.ReadKey();
        }
    }
}
