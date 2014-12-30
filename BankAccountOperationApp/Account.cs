using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOperationApp
{
    class Account
    {
        private string accountNumber;
        private string customerName;
        private double balance;

        public Account()
        {
            Balance = 0;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string deposit(double amount)
        {
            Balance += amount;
            return amount + " Taka Has Deposited";
        }

        public string withdraw(double amount)
        {
            if (Balance - amount >=0)
            {
                Balance -= amount;
                return amount + " Taka Has Withdraw";
            }
            else
            {
                return "No Suficient Balance";
            }
        }
    }

    
}
