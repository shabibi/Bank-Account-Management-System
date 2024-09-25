using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1Task
{
    public class BankAccount
    {
        /// BankAccount private properties

        private string AccountNumber;
        private string AccountHolder;
        public decimal Balance  { get;private set; }

        //BankAccount constructors 
        public BankAccount(string AccountNum, string AccountName)
        {
            AccountNumber = AccountNum;
            AccountHolder = AccountName;
        }

        
        public BankAccount(string AccountNum, string AccountName, decimal amount)
        {
            AccountNumber = AccountNum;
            AccountHolder = AccountName;
            Balance = amount;
        }

        //BankAccount methods

        //Deposit
        public void Deposit()
        {
                Console.WriteLine("Enter the Amount to Deposit");
                decimal amount = decimal.Parse(Console.ReadLine());

                if (amount > 0)
                {
                    Balance += amount;
                }
                else
                {
                    Console.WriteLine("Sorry.. Invaild amount to Deposit");
                }
           
        }

        //Withdraw
        public decimal Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                return Balance += amount;
            }
            else
            {
                Console.WriteLine("Sorry..Your Balance less than the amount");
                return -1;
            }
        }

        //GetAccountInfo
        public void GetAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Holder Name: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance}");
        }

        public bool IsAccountNumberValid(string accountNumber)
        {
            if(AccountNumber == accountNumber)
            {
                return true;
            }
            else 
                return false;
        }

    }
}
