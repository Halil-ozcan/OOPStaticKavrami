using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.isim = "Halil";
            musteri.soyisim = "Özcan";
            musteri.emailAdres = "halil.özcan@gmail.com";
            musteri.KullaniciAdi = "halil.ozcan";
            musteri.sifre = "1";

            Musteri.MusteriEkle(musteri);

        }
    }
}
