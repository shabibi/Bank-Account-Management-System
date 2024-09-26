using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1Task
{
    public class Bank
    {
       static  public List<BankAccount> Accounts=new List<BankAccount>();

        
        static Bank()
        {
            
            Accounts.Add(new BankAccount("444", "mmm"));
            Accounts.Add(new BankAccount("555", "ccc"));
            Accounts.Add(new BankAccount("999", "ddd", 8));
            Accounts.Add(new BankAccount("888", "ddd", 10));
        }
        // method to add a new account
        public void AddAccount()
        {
            Console.Clear();
            Console.WriteLine("********************Add New Account********************\n");
            Console.WriteLine("_______________________________________________________\n");
            Console.WriteLine("Enter Acoount Number ");
            string AccountNum = Console.ReadLine();
            for (int i = 0; i < Accounts.Count; i++)
            {
                if(Accounts[i].IsAccountNumberValid(AccountNum))
                {
                    Console.WriteLine("This Account Number Regestered befor..\n");
                    return;
                }
            }
            Console.WriteLine("\nEnter Acoount Holder ");
            string AccountName = Console.ReadLine();

            Console.WriteLine("\nDo you want Add Balance in this account");
            Console.WriteLine(" 1.yes\n 2.No ");
            string AddAmount = Console.ReadLine();

            if (AddAmount == "1")
            {
                Console.WriteLine("\nEnter the Amount");
                decimal amount = decimal.Parse(Console.ReadLine());
                Accounts.Add(new BankAccount(AccountNum, AccountName, amount));
                Console.WriteLine("\nNew Account Added Successfully..");
            }
            else if (AddAmount == "2")
            {
                Accounts.Add(new BankAccount(AccountNum, AccountName));
                Console.WriteLine("\nNew Account Added Successfully..");
            }
            else
            {
                Console.WriteLine("\nInvalid input..");
            }

        }

        // method to get an account by AccountNumber
        public BankAccount GetAccountByNumber()
        {
            Console.Clear();
            Console.WriteLine("********************Get Account By Number********************\n");
            Console.WriteLine("_____________________________________________________________\n");
            Console.WriteLine("Enter Acoount Number ");
            string AccountNum = Console.ReadLine();
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].IsAccountNumberValid(AccountNum))
                {
                    return Accounts[i];
                }
               
            }
            Console.WriteLine("\nAccount Not Found..");
            return null;
        }

        // method to display all accounts with their balance
        public void DisplayAllAccounts()
        {
            Console.Clear();
            Console.WriteLine("********************Display All Accounts********************\n");
            Console.WriteLine("_____________________________________________________________\n");
            for (int i = 0; i < Accounts.Count; i++)
            {
                Accounts[i].GetAccountInfo();
                Console.WriteLine("_____________________________________________________________\n");
            }
        }

        
    }
}
