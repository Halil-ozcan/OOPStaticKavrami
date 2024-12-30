using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProje
{
    internal class Musteri
    {
        static ArrayList musteriDatabase;

        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        public int MusteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }

        private string _kullaniciAdi;
      
        public string KullaniciAdi 
        {
            get { return _kullaniciAdi; }
            set 
            {
                bool kullaniciAdiKontrol = MusteriKullaniciKontrol(value);
                if(kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek İstediğiniz Kullanici Adi Sistem İçerisinde Kayıtlı");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
                    
            } 
        }

        static bool MusteriKullaniciKontrol(string _kullaniciadi)
        {
            bool kontrol = false;

            for(int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if( Temp.KullaniciAdi == _kullaniciadi)
                {
                    kontrol = true;
                    break;
                }

            }
            return kontrol;
        }

        public static void MusteriEkle(Musteri M)
        {
            if( M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriEmailKontrol(M.emailAdres);
                if( emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek İstediğiniz kullanici sistemde Kayıtlı");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni Kayit İşlemi Başarılı.");
                }
            }
        }

        static bool musteriEmailKontrol(string _emailAdres)
        {
            bool kontrol = false;
            for( int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if(Temp.emailAdres == _emailAdres)
                {
                    kontrol = true; 
                    break;
                }

            }
            return kontrol;
        }
    }
}
