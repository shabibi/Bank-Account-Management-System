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
            

            if (amount > 0)
            {
                Balance += amount;
                
            }
            else
            {
                Console.WriteLine("Sorry.. Invaild amount to Deposit");
                return;
            }
        }

        //Withdraw
        public void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("********************Withdraw********************\n");
            Console.WriteLine("_____________________________________________________________\n");
            Console.WriteLine("Your Balance is " + Balance);
            Console.WriteLine("\nEnter the Amount to Withdraw");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (Balance >= amount)
            {
                if (amount > 0)
                {
                    
                    Balance -= amount;
                    Console.WriteLine("\nYour Balance After Withdraw is " + Balance);
                }
                else
                {
                    Console.WriteLine("Sorry.. Invaild amount to Withdraw");
                }


            }
            else
            {
                Console.WriteLine("\nSorry..Your Balance less than the amount");

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
