using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While

            // 1'den başlayarak console dan girilen sayıya kadar(sayı dahil)
            // ortalama hesaplayıp console'a yazdıran program

            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;


            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // A'dan Z'ye kadar tüm harfleri console'a yazdıralım


            //char character = 'a';
            //while (character < 'z')
            //{
            //    Console.Write(character);
            //    character++;
            //}


            // Foreach

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }




            Console.ReadKey();
        }
    }
}
