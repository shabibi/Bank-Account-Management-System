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

        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
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
        public void Deposit(decimal amount)
        {
                Balance += amount;
        }

        //Withdraw
        public void Withdraw(decimal amount)
        {
                    Balance -= amount;
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
