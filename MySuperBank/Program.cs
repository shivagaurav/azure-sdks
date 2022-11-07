// See https://aka.ms/new-console-template for more information
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("shiva", 10000);
            Console.WriteLine($"account {account.Number} was created for {account.Owner} with balance {account.Balance}");
            account.MakeWithdrawal(300, DateTime.Now, "pizza");
            Console.WriteLine($"remaining balance {account.Balance}");
        }
    }
}
