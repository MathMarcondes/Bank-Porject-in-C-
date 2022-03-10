 using System;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with US${account.Balance}.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent Paymant");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(120, DateTime.Now, "Nude da Lux");
            Console.Write(account.Balance);
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
