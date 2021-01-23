using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCredit:ICreditManager
    {
        void ICreditManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void ICreditManager.Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
