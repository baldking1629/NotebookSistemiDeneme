using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NotebookSistemiDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.RamEkleme();
            /*
             1- laptop sistemi 4 farklı marka için
             2- her markada işlemci,ram,anakart,disk ve ekran bulunuyor.
             3- bu bilgisayarlara ram ekleme yapılabiliyor
             4- lenovoların ekranı 17.3 inç olmalıdır.
             5- sonylerin işlemcisi en az i5
             6- dell bilgisayarlarda disk ssd olmalıdır
             7- asuslarda sadece i7 li bilgisayar üretilmektedir
             8- bilgisayarın detay özellikleri olmalıdır. örn: ramin veri yolu hızı, işlemcinin hızı, diskin okuma yazma hızı, ekran kartı varsa markası 
            paylaşımlı olup olmadığı, ekran boyutu vb.
             9- fiyatlandırma laptopta bulunan özelliklere göre yapılmalıdır. 2.4 ghz li bir ram her markada farklı dönecektir örn: ramin fiyatı 10$ 
            a marka bilgisayar 100$ 112$ a satacak b marka pc 100$ 108$ e satacak vb.
                        ----------------------------------------------------------------------------------------------------------------
            laptop classı oluştur.
            markası rami vb prop ver 
            ram özellikleri için ayrı bir ram classı oluştur(tüm özellikler için geçerli)
            markalara göre if koşulu ekle 
            fiyatlandırma için laptop classına fonksiyon aç
            */
        }
        public class Laptop
        {
            public string marka { get; set; }
            public Ram Ram { get; set; }
            public disk disk { get; set; }
            public void RamEkleme()
            {
                Ram = new Ram { fiyati=500,okumaHizi=4,yazmaHizi=3,ramMarkasi="Acer"};
            }

            
        }
        public class Ram
        {
            public string ramMarkasi { get; set; }
            public int okumaHizi { get; set; }
            public int yazmaHizi { get; set; }
            public int fiyati { get; set; }
        }
         public class disk
        {
            
        }

    }
    
}
