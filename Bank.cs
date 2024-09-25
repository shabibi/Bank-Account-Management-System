using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1Task
{
    public class Bank
    {
        public List<BankAccount> Accounts = new List<BankAccount>();

        public void AddAccount()
        {
            Console.Clear();
            Console.WriteLine("********************Add New Account********************\n");
            Console.WriteLine("_______________________________________________________\n");
            Console.WriteLine("Enter Acoount Number ");
            string AccountNum = Console.ReadLine();

            Console.WriteLine("\nEnter Acoount Holder ");
            string AccountName = Console.ReadLine();

            Console.WriteLine("\nDo you want Add Balance in this account");
            Console.WriteLine(" 1.yes\n 2.No ");
            string AddAmount = Console.ReadLine();

            if(AccountNum == "1")
            {
                Console.WriteLine("\nEnter the Amount");
                decimal amount = decimal.Parse(Console.ReadLine());
                Accounts.Add(new BankAccount(AccountNum, AccountName, amount));
                Console.WriteLine("\nNew Account Added Successfully..");
            }
            else if (AddAmount == "2")
            {
                Accounts.Add(new BankAccount(AccountNum, AccountName));
            }
            else
            {
                Console.WriteLine("\nInvalid input..");
            }


        }
    }
}
