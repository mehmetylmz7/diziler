using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizi tanımlama 

            string[] renkler = new string[5];
            string[] hayvanlar = { "kopek", "kedi", "sincap", "kuş" };

            int[] dizi;
            dizi = new int[5];

            // dizilere deger atama ve erişim

            renkler[0] = "mavi";
            dizi[3] = 99;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            // dongulerle dizi kullanımı

            Console.Write("lutfen dizinin eleman sayısını gırınız:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("lutfen {0}. sayısını giriniz:",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("ortalama:"+ toplam/diziUzunlugu);


            Console.ReadLine();
        }

    }
}
