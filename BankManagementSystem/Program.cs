namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.AddAccount(new SavingAccount(1, "Ali", 1000));
            bank.AddAccount(new CheckingAccount(2, "Mehmet", 3000));
            bank.AddAccount(new SavingAccount(3, "Murat", 12000));
            //bank.ListAccounts();
            bank.FindAccount(1);
        }
    }
}
