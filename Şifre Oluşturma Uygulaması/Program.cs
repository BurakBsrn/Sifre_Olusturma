using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Şifre_Oluşturma_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ilk:
            Console.WriteLine("Oluşturulacak Şifre Uzunluğu Nedir ?");
            string uzunluk = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(uzunluk, "[^0-9]"))
            {
                Console.WriteLine("Sadece Sayı Girebilirsiniz.");
                goto ilk;
            }
            Console.WriteLine("Kaç Adet Şifre Oluşturulacak ? ");
            string adet = Console.ReadLine();

            iki:
            if (System.Text.RegularExpressions.Regex.IsMatch (uzunluk, "[^0-9]"))
            {
                Console.WriteLine("Sadece Sayı Girebilirsiniz.");
                goto iki;
            }

            Console.WriteLine("Şifre Türünü Seçiniz.. (1/2)");
            Console.WriteLine("1) Rastgele Şifre");
            Console.WriteLine("2) Anahtar Karakterli Şifre");
            Console.WriteLine("------------------------------");

            üç:
            string secim = Console.ReadLine();
            Console.WriteLine("-------------------------");
            if (secim == "1")
            {
                Random rnd = new Random();
                string character = "ABCDEFGHIJKLMNOPRSTUVYZQW._-+/abcdefghıijklmnoöprstuüvyzqw0123456789";

                for (int z = 0; z < Convert.ToInt64(adet); z++)
                {
                    string aaa = "";
                    for (int i = 0; i < Convert.ToInt32(uzunluk); i++)
                    {
                        int r = rnd.Next(0, character.Length);
                        aaa = aaa + character[r];
                    }
                    Console.WriteLine(aaa);
                    Console.WriteLine("-------------------------------------");
                }
            }

            else if (secim == "2")
            {
                Random rnd = new Random();
                Console.WriteLine("İstediğiniz Karakterleri Giriniz ");
                Console.WriteLine("-----------------------------");
                string characters = Console.ReadLine();
                Console.WriteLine("------------------------------");

                for (int z = 0; z < Convert.ToInt64(adet); z++)
                {
                    string sonuc = "";
                    for (int i = 0; i < Convert.ToInt32(uzunluk); i++)
                    {
                        int r = rnd.Next(0, characters.Length);
                        sonuc = sonuc + characters[r];
                    }
                    Console.WriteLine(sonuc);
                    Console.WriteLine("------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Lütfen 1 yada 2 Numaralı Seçeneği Seçiniz");
                goto üç;
            }
        }
    }
}
