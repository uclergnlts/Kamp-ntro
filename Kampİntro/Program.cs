using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini Tekrarlama
            string kategoriEtiketi = "Kategori"; //Değişken atamak için kullnılır
            int ogrenciSayisi = 32000;  //Tam Sayılar
            double faizOrani = 1.45;   //Ondalıklı Sayılar
            bool SistemeGirisYapmıisMi = true;  //Kontrol Kodu
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }

            if (SistemeGirisYapmıisMi == true)  //Şart Bloğu
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            Console.WriteLine(kategoriEtiketi);

        }
    }
}
