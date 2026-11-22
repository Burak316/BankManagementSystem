using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class CheckingAccount:BankAccount//inheritance
    {
        public override double CalculateInterest()
        {
            return Balance * 0.02;
        }
        public CheckingAccount(int accountNumber, string ownerName,double deposit):base(accountNumber,ownerName,deposit)
        {
            
        }
    }
}
