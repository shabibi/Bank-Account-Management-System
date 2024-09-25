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

        public string AccountNumber { get;private set; }
        public string AccountHolder { get;private set; }
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


    }
}
