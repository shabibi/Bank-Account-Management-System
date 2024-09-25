namespace OOPPart1Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bool flge = false;
            Console.WriteLine("********************Bank Account Management System r********************\n");
            Console.WriteLine("_____________________________________________________________\n");


           

            do
            {
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
                        BankAccount BA = bank.GetAccountByNumber();
                        BA.Deposit();
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        break;

                    case 5:
                        return;
                        break;


                }

            } while (flge==true);
        }
    }
}
