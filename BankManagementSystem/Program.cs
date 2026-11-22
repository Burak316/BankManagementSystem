namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new SavingAccount(1, "Ali",1000));
            accounts.Add(new CheckingAccount(2, "Furkan",2000));
            accounts.Add(new SavingAccount(3, "Mehmet",3000));
            
            foreach(BankAccount i in accounts)
            {
                Console.WriteLine($"{i.AccountNumber} {i.OwnerName} {i.Balance} {i.CalculateInterest()}");
            }

           
            
           





        }
    }
}
