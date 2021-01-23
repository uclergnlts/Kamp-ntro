using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCredit : ICreditManager
    {
        void ICreditManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void ICreditManager.Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
