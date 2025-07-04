using System;

namespace Banking
{
    class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    class Account
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int Balance { get; private set; }

        public Account(int accountnumber, string customername, int initialbalance)
        {
            AccountNumber = accountnumber;
            CustomerName = customername;
            Balance = initialbalance;
        }

        public void Deposit(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");
            if (amount > Balance)
                throw new InsufficientBalanceException("Insufficient balance for this transaction.");
            Balance -= amount;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Customer Name  : {CustomerName}");
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }

    class Qn1
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter Account Number: ");
                int accountnumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Customer Name: ");
                string customername = Console.ReadLine();

                Console.Write("Enter Initial Balance: ");
                int initialbalance = int.Parse(Console.ReadLine());

                Account account = new Account(accountnumber, customername, initialbalance);

                Console.Write("Enter Transaction Type (D for Deposit / W for Withdraw): ");
                string input = Console.ReadLine().Trim().ToUpper();

                if (input != "D" && input != "W")
                {
                    Console.WriteLine("Invalid transaction type. Please enter 'D' or 'W'.");
                }
                else
                {
                    Console.Write("Enter Amount: ");
                    int amount = int.Parse(Console.ReadLine());

                    if (input == "D")
                        account.Deposit(amount);
                    else if (input == "W")
                        account.Withdraw(amount);
                    else
                        Console.WriteLine("Enter Valid Transaction type...");
                    account.ShowDetails();

;                }
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Transaction Failed: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format, Please enter numeric values wherever required ");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Input Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }   
            Console.Read();
        }
    }
}
