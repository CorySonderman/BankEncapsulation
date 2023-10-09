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

            do
            {
                Console.WriteLine("In this scenario, this is an ATM. Only options " +
                    "are balance, deposit, withdraw, or cancel(On an ATM there are" +
                    " only buttons to press so no other inputs could be given).");
                Console.WriteLine();
                Console.WriteLine("How may I help you today?");

                string input = Console.ReadLine().ToLower();

                if (input == "balance")
                {
                    Console.WriteLine($"Your balance is ${account.GetBalance()}.");
                }
                else if (input == "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine($"Your new balance is ${account.GetBalance()}.");
                }
                else if (input == "withdraw")
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    Console.WriteLine($"Your new balance is ${account.GetBalance()}.");
                }
                else if (input == "cancel")
                {
                    Console.WriteLine("Have an amazing day!");
                    break; 
                }

                Console.WriteLine("Do you want to make another transaction? (yes/no)");
                string anotherTransaction = Console.ReadLine().ToLower();

                if (anotherTransaction != "yes")
                {
                    Console.WriteLine("Have an amazing day!");
                    break; 
                }
            } while (true); 
        }


    }
}

