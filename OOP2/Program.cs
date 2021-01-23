using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual costumer1 = new Individual();
            costumer1.MusteriNo = "12345";
            costumer1.Adi = "Üçler";
            costumer1.Soyadi = "Gönültaş";
            costumer1.TcNo = "12345678910";
            costumer1.Id = 1;

            //Kodlama.io

            Coorporate costumer2 = new Coorporate();
            costumer2.Id = 2;
            costumer2.MusteriNo = "54321";
            costumer2.SirketAdi = "Kodlama.io";
            costumer2.VergiNo = "1111111111111";

            //Gerçek Müşteri - Tüzel Müşteri bunlar birbiri yerine kullanılamaz.
            //SOLID
            Costumer costumer3 = new Individual();
            Costumer costumer4 = new Coorporate();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Add(costumer2);

        }
    }
}
