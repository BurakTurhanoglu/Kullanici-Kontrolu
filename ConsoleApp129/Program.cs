using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.isim = "Doğukan";
            M1.soyisim = "Baygut";
            M1.emailAdres = "dogukan2014gs@gmail.com";
            M1.KullaniciAdi = "dogukan.baygut";
            M1.sifre = "1";
            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                musteriID = 2,
                isim = "Ahmet",
                soyisim = "Atilla",
                emailAdres = "ahmet.atilla@hotmail.com",
                KullaniciAdi = "ahmet.atilla",
                sifre = "2"
            };
            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();
            M3.musteriID = 1;
            M3.isim = "Doğukan";
            M3.soyisim = "Baygut";
            M3.emailAdres = "dogukan2014gs@gmail.com";
            M3.KullaniciAdi = "dogukan.baygut";
            M3.sifre = "1";
            Musteri.MusteriEkle(M3);

        }
    }

}
