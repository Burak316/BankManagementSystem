namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BankAccount account1 = new BankAccount(); ------> error beacuse of abstract
            BankAccount account2 = new SavingAccount(2, "Ali");
            BankAccount account3 = new CheckingAccount(3,"Mehmet");

            // account1.AccountNumber = 1; ------> error beacuse of abstract
            account2.AccountNumber = 2;
            account3.AccountNumber = 3;


           
            account2.Deposit(100);
            account2.Withdraw(50);
            Console.WriteLine(account2.Balance);
            Console.WriteLine(account2.CalculateInterest());





        }
    }
}
