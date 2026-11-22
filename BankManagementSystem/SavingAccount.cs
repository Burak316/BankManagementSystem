using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class SavingAccount: BankAccount//inheritance
    {
        public override double CalculateInterest()
        {
            return Balance * 0.1;
        }
        public SavingAccount(int accountNumber , string ownerName,double deposit) : base(accountNumber,ownerName,deposit)
        {

        }
    }
}
