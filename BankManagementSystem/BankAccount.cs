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

        public bool Deposit(double amount)//add
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
                return false;
            }
            Balance += amount;
            return true;
        }
        
        public bool Withdraw(double amount)//remove
        {
            if (amount <= 0 || amount>Balance)
            {
                Console.WriteLine("Invalid amount");
                return false;
            }
            
            Balance -= amount;
            return true;
        }
        public abstract double CalculateInterest();//polymorphism abstract instead of virtual
        
        public BankAccount(int accountNumber, string ownerName,double deposit)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Deposit(deposit);
        }
        public void Transfer(BankAccount recevier,double amount)
        {
            if (recevier == null)
            {
                Console.WriteLine("NULL!");
                return;
            }
            if (this == recevier)
            {
                Console.WriteLine("Same consumer!");
                return;
            }
            if (this.Withdraw(amount))
            {
                recevier.Deposit(amount);
            }
        }

    }
}
