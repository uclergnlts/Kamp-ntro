using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
            ICreditManager transportCredit = new TransportCredit();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();



            AppealManager appealManger = new AppealManager();
            appealManger.BasvuruYap(personalFinanceCredit, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCredit };
        }
    }

}