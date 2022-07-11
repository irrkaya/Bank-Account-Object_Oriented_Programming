using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Irem", 160000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());


            ////// test for a negative balance.
            ////try
            ////{
            ////    account.makewithdrawal(750000, datetime.now, "attempt to overdraw");
            ////}
            ////catch (invalidoperationexception e)
            ////{
            ////    console.writeline("exception caught trying to overdraw");
            ////    console.writeline(e.tostring());
            ////}


            ////// test that the initial balances must be positive.
            ////bankaccount invalidaccount;
            ////try
            ////{
            ////    invalidaccount = new bankaccount("invalid", -55);
            ////}
            ////catch (argumentoutofrangeexception e)
            ////{
            ////    console.writeline("exception caught creating account with negative balance");
            ////    console.writeline(e.tostring());
            ////    return;
            ////}

        }
    }
}
