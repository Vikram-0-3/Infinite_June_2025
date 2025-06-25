using System;


namespace Bank 
{

    class Account
    {
        public int AccountNumber;
        public string CustomerName;
        public string AccountType;
        public char TransactionType;
        public int TransactionAmount;
        public int Balance;

        public Account(int AccountNumber, string CustomerName, string AccountType, int Balance)
        {
            this.AccountNumber = AccountNumber;
            this.CustomerName = CustomerName;
            this.AccountType = AccountType;
            this.Balance = Balance;
        }

        public void UpdateBalance()
        {
            if (TransactionType == 'D')
            {
                Credit(TransactionAmount);
            }
            else if (TransactionType == 'W')
            {
                Debit(TransactionAmount);
            }
        }

        public void Credit(int Amount)
        {
            Balance += Amount;
        }

        public void Debit(int Amount)
        {
            if (Amount <= Balance)
            {
                Balance -= Amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void ShowData()
        {

            Console.WriteLine("\nAccount Number: " + AccountNumber);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Transaction Type: " + TransactionType);
            Console.WriteLine("Transaction Amount: " + TransactionAmount);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Account Number: ");
            int AccountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string CustomerName = Console.ReadLine();

            Console.Write("Enter Account Type: ");
            string AccountType = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            int Balance = int.Parse(Console.ReadLine());

            Account Acc = new Account(AccountNumber, CustomerName, AccountType, Balance);

            Console.Write("Enter Transaction Type (D/W): ");
            Acc.TransactionType = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Enter Transaction Amount: ");
            Acc.TransactionAmount = int.Parse(Console.ReadLine());

            Acc.UpdateBalance();
            Acc.ShowData();

            Console.ReadLine();
        }
    }

}

