using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager    
{
    class Account
    {
        private string name;
        private double balance;
        private static int seq;
        private int AccountNumber;
        private bool isActive;

        static Account()
        {
            seq = 1;
        }

        public Account(string name)
        {
            this.AccountNumber = seq;
            this.name = name;
            this.balance = 0;
            this.isActive = true;
            seq++;
        }

        public Account(string name, double balance)
        {
            this.AccountNumber = seq;
            this.name = name;
            this.balance = balance;
            this.isActive = true;
            seq++;
        }

        public double depositeAmount(double amount)
        {
            if (isActive)
            {
                this.balance += amount;
                }
            else
            {
                Console.WriteLine("Account is inactive ");
            }
            return this.balance;
        }

        public double withDrawAmount(double amount)
        {

            if (isActive)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Account is inactive ");
            }
            return this.balance;
        }

        public double balanceEnquiry()
        {
            return this.balance;
        }

        public bool closeAccount()
        {
            this.balance = 0;
            this.isActive = false;
            return true;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n ACNO: {1}\n Balance: {2}\n Active: {3}\n", this.name, AccountNumber, this.balance, this.isActive);
        }

    }
}
