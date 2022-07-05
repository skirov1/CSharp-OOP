using System;
using System.Collections.Generic;

namespace _06.MoneyTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, double>();
            var accountsInfo = Console.ReadLine().Split(new char[] { '-', ',' });
            for (int i = 0; i < accountsInfo.Length; i += 2)
            {
                var accountNumber = int.Parse(accountsInfo[i]);
                var accountBalance = double.Parse(accountsInfo[i + 1]);
                accounts[accountNumber] = accountBalance;
            }
            while (true)
            {
                try
                {
                    var cmd = Console.ReadLine().Split();
                    if (cmd[0] == "End")
                    {
                        Environment.Exit(0);
                    }
                    var action = cmd[0];
                    var accountNumber = int.Parse(cmd[1]);
                    var sum = double.Parse(cmd[2]);
                    if (action == "Deposit")
                    {
                        Deposit(accounts, accountNumber, sum);
                    }
                    else if (action == "Withdraw")
                    {
                        Withdraw(accounts, accountNumber, sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                        continue;
                    }
                    Console.WriteLine($"Account {accountNumber} has new balance: {accounts[accountNumber]:f2}");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid account!");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }
        static void Deposit(Dictionary<int, double> accounts, int accountNumber, double sum)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                throw new ArgumentException();
            }
            accounts[accountNumber] += sum;
        }
        static void Withdraw(Dictionary<int, double> accounts, int accountNumber, double sum)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                throw new ArgumentException();
            }
            if (sum > accounts[accountNumber])
            {
                throw new InvalidOperationException();
            }
            accounts[accountNumber] -= sum;
        }
    }
}
