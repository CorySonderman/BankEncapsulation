using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        
        }
        //A private field of type double named **balance **with a value of 0
        private double balance = 0;
        //Define a method named Deposit that will accept a double and
        //store that value in the balance field
        public void Deposit(double amount)
        {
             balance += amount;
        }
        //Define a method named GetBalance that will return the amount stored in
        //the balance field

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
        

    }
}
