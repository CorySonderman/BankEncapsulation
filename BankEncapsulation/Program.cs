using System.Runtime.InteropServices;

namespace BankEncapsulation
{
    public class Program
    {
        //In the main method of your application, create a new instance of the
        //BankAccount class. Allow the user of the application to Deposit money and
        //retrieve their balance through the console.
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much is your deposit?");
            var depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine($"Your new balance is $ {account.GetBalance()}.");
        }
    }
}
