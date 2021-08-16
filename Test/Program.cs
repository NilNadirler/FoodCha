using Core.Entity;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using Test.Abstract;
using Test.Concrete;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transaction transaction = new Transaction() { Type=TransactionType.Buy};
            /*
             * TransactionType Sabit değerler olarak (Buy,Sell,Return) tipleri kullanılabilir. 
             * Bu sebepten ötürü TransactionType adında bir class oluşturduk ve sabit değeri static tanımladık.
             */
            UserRepository userRepository = new UserRepository();
            userRepository.GetAll();
            userRepository.Get(u=>u.Name=="Nil");
            ICredit credit = CreditFunction();
            Console.WriteLine(" test "+credit.CheckBalance());
        }
        public static ICredit CreditFunction()
        {
            ICredit credit;
            string creditText = "ing";
            if (creditText == "ing")
            {
                credit = new IngCredit();
                credit.CheckBalance();
            }
            else
            {
                credit = new FinanceCredit();
                credit.CheckBalance();
            }
            return credit;
        }
    }
}
