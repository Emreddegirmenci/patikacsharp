using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //try // Hataya sebeb verme ihtimali olan kod  
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
            //}
            //catch (Exception ex) // Hatayı yakalar
            //{
            //    Console.WriteLine("Hata" + ex.Message.ToString());
              
            //}
            //finally // ne olursa olsun en sonunda kullanıcıya gösterilir.
            //{
            //    Console.WriteLine("İşlem tamamlandı");
            //}

            try 
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Burası ne olursa olsun okunur");
            }
            
            
            
            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
