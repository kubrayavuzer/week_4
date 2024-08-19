using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_closing
{
    abstract class BaseMakine
    {
        public string UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMakine()
        {
            UretimTarihi = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  // Üretim Tarihi otomatik olarak atanıyor


        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim sistemi: {IsletimSistemi}");
        }

        public abstract string UrunAdiGetir();

    }

    class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı: {(TrLisansli ? "Evet" : "Hayır")}");

        }

        public override string UrunAdiGetir()
        {
            return $"Telefon adı: {Ad}";

        }

        class Bilgisayar : BaseMakine
        {
            private int _usbGirisSayisi;

            public int UsbGirisSayisi
            {
                get { return _usbGirisSayisi; }
                set
                {
                    if (value == 2 || value == 4)
                    {
                        _usbGirisSayisi = value;
                    }
                    else
                    {
                        Console.WriteLine("Usb giriş sayısı 2 veya 4 olmalıdır.");
                        _usbGirisSayisi = -1;
                    }
                }
            }
            public bool Bluetooth { get; set; }

            public override void BilgileriYazdir()
            {
                base.BilgileriYazdir();

                if (_usbGirisSayisi != -1)
                {
                    Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
                }

                Console.WriteLine($"Bluetooth: {(Bluetooth ? "Evet" : "Hayır")}");
            }

            public override string UrunAdiGetir()
            {
                return $"Bilgisayarınızın adı ---> {Ad}";
            }
        }
    }


}