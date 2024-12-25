using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStat
{
    public class Ogrenci
    {
        public string Isim {  get; set; }
        public string SoyIsim { get; set; }

        public string EmailAdres{ get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne Örneği Alındıktan Sonra Çalışan Metot");

            Test2();

            // static olamayan bir metot static olan bir metotu Çağırabilir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne Örneği Alınmadan Kullanılabilir");

            // static olan bir metot static olamayan bir metotu çağıramaz.
        }
    }
}
