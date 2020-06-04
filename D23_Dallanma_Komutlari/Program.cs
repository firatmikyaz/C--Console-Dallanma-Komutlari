using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D23_Dallanma_Komutlari
{
    class Program
    {
        static void Main(string[] args)
        {
        // Kullanıcı 3 adet yazılı sınav botunun ort.hesaplayan,kullanıcı isterse işlemi tekrar yapan bir program//

            BASADON:
            Console.Clear();
            Console.Write("1.Yazılı Notunu Giriniz?");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Yazılı Notunu Giriniz?");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.Sınav Notunu Giriniz?");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int ort = (y1 + y2 + y3) / 3;
            Console.WriteLine("Yazılıların Ortalaması:{0}", ort);
            SECİMYAP:
            Console.WriteLine("Yeniden işlem yapmak ister misiniz? (e veya h)");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == 'e' || secim == 'E')
            {
                goto BASADON;
            }
            else if (secim == 'h' || secim == 'H')
            {
                Console.WriteLine("İyi Günler...");
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.Tekrar Deneyiniz...");
                Console.Clear();
                goto SECİMYAP;
                
            }
            Console.ReadKey();
        }
    }
}
