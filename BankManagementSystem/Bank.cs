using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class Bank
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
        }
        public void ListAccounts()
        {
            foreach(BankAccount account in accounts)
            {
                Console.WriteLine($"{account.AccountNumber} {account.OwnerName} {account.Balance} {account.CalculateInterest()}");
            }
        }
        public BankAccount FindAccount(int accountNumber)
        {
            foreach(BankAccount account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            Console.WriteLine("Invalid number");
            return null;
        }
        public void TransferMoney(int senderAccountNumber,int reciverAccountNumber,double amount)
        {
            BankAccount sender = FindAccount(senderAccountNumber);
            BankAccount reciver = FindAccount(reciverAccountNumber);

            if(sender==null || reciver == null)
            {
                return;
            }
            sender.Transfer(reciver, amount);

        }
    }
}
