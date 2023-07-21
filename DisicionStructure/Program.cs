using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisicionStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //&& operatörü ile || operatörü arasındaki farkı if-else yapısı ile örneklendirelim

            int sifre;
            string kullanici;

            Console.WriteLine("Lütfen kullanici adi giriniz : ");
            kullanici = Console.ReadLine();
            Console.WriteLine("Lütfen sifre giriniz : ");
            sifre = Convert.ToInt32(Console.ReadLine());


            // *** && kullanımi ***
            //if (kullanici == "admin" && sifre == 123456)
            //{
            //    Console.WriteLine("Hosgeldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("hata");
            //}

            //*** || kullanimi ***

            if (kullanici == "admin" || sifre == 123456)
            {
                Console.WriteLine("Hosgeldiniz");
            }
            else
            {
                Console.WriteLine("hata");
            }


            Console.Read();
        }
    }
}
