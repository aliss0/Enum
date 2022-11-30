using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sıcaklık = 9;

            if (sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya Çıkabilmek İçin Havanın Isınmasını Bekleyelim");
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarı Çıkmak İçin Hava Çok Sıcak");
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hadi Dışarıya Çıkalım");

            Console.ReadLine();
        }
    }
    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar,
    }
    enum HavaDurumu
    {
        Soguk = 1,
        Normal = 22,
        Sıcak = 30,
        ÇokSıcak = 35,
    }
}
