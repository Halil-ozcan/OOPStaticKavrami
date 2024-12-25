using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPStat;

namespace OOPStaticKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static : nesne örneği alınmadan ulaşabildiğimiz metot, field, sinif...


            // Stack Bölge içerisinde pointer ımız oluştu.

            Ogrenci O1;

            // stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static, field, metot, static dediğimiz bölgede oluştu.
            Ogrenci.Test2();


            O1 = new Ogrenci();
            // Stack Bölgede pointer => kendisini heap bölgede tamamladı... static olmayan tanımları tanımladı...
            O1.Test1();// nesne örneği alındıktan sonra test1 adındaki metotuma ulaştım.

        }
    }
}
