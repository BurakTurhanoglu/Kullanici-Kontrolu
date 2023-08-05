using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp129
{
    internal class Musteri
    {
        static ArrayList musteriDatabase;
        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get { return this._kullaniciAdi; }
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlıdır.");
                    this._kullaniciAdi = String.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }
        
        static bool musteriKullaniciAdiKontrol(string _kullaniciadi)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.KullaniciAdi == _kullaniciadi)
                {
                    Kontrol = true;
                    break;
                }
            }


            return Kontrol;
        }
        public static void MusteriEkle(Musteri M)
        {
            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }
            }
        } 
        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;
            for (int i = 0;i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.emailAdres == _emailAdres)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }
    }
}
