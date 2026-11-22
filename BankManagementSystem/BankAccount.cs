using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal abstract class BankAccount
    {
        //public int AccountNumber; // field
        public int AccountNumber { get; set; }//property get=read set=change set DE because read only
        public string OwnerName { get; set; }
        public double Balance { get; private set; }

        public void Deposit(double amount)//add
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
                return;
            }
            Balance += amount;
        }
        
        public void Withdraw(double amount)//remove
        {
            if (amount <= 0 || amount>Balance)
            {
                Console.WriteLine("Invalid amount");
                return;
            }
            
            Balance -= amount;
        }
        public abstract double CalculateInterest();//polymorphism abstract instead of virtual
        
        public BankAccount(int accountNumber, string ownerName)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
        }
        

    }
}
