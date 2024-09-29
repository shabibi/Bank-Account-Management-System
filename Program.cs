namespace OOPPart1Task
{
    internal class Program
    {
        static Bank bank = new Bank();
        static void Main(string[] args)
        {
            
            bool flge = false;
            Console.WriteLine("********************Bank Account Management System r********************\n");
            Console.WriteLine("_____________________________________________________________\n");

           

            do
            {
                Console.Clear();
                Console.WriteLine("Enter Number of your Choise..\n ");
                Console.WriteLine(" 1. Add New Account\n");
                Console.WriteLine(" 2. Deposit\n");
                Console.WriteLine(" 3. Withdraw\n");
                Console.WriteLine(" 4. Get Account Info\n");
                Console.WriteLine(" 5. Exit\n");

                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        bank.AddAccount();
                        break;

                    case 2:
                        DepositDisplay();
                        break;

                    case 3:
                        DepositWithdraw();

                        break;

                    case 4:
                        bank.DisplayAllAccounts();
                        break;

                    case 5:
                        return;
                        break;


                }
                Console.WriteLine("Enter 1 to Display Menu..");
                string count = Console.ReadLine();

                if(count == "1")
                {
                    flge = true;
                }
                else
                    flge = false;

            } while (flge==true);
        }
        public static void DepositDisplay()
        {
            BankAccount BA = bank.GetAccountByNumber();

            Console.Clear();
            Console.WriteLine("********************Deposit********************\n");
            Console.WriteLine("_____________________________________________________________\n");
            if (BA != null)
            {
                Console.WriteLine("\nYour Balance is " + BA.Balance);
                Console.WriteLine("\nEnter the Amount to Deposit");
                decimal amount = decimal.Parse(Console.ReadLine());
                
                if (amount > 0)
                {
                    BA.Deposit(amount);
                    Console.WriteLine("\nYour Balance After Deposit is " + BA.Balance);
                }
                else
                {
                    Console.WriteLine("Sorry.. Invaild amount to Deposit");
                    return;
                }
            }
            else
            {
                Console.WriteLine("\nAccount Not Found..");
            }

        }
        public static void DepositWithdraw()
        {
            BankAccount BA = bank.GetAccountByNumber();

            Console.Clear();
            Console.WriteLine("********************Withdraw********************\n");
            Console.WriteLine("_____________________________________________________________\n");
            if (BA != null)
            {
                Console.WriteLine("Your Balance is " + BA.Balance);
                Console.WriteLine("\nEnter the Amount to Withdraw");
                decimal amount = decimal.Parse(Console.ReadLine());

                if (amount > 0)
                {
                    if (BA.Balance >= amount)
                    {
                        BA.Withdraw(amount);
                        Console.WriteLine("\nYour Balance After Withdraw is " + BA.Balance);
                    }
                    else
                    {
                        Console.WriteLine("\nSorry..Your Balance less than the amount");

                    }
                }
                else
                {
                    Console.WriteLine("Sorry.. Invaild amount to Withdraw");
                }
            }
            else
            {
                Console.WriteLine("\nAccount Not Found..");
            }
        }
    }

   
}
