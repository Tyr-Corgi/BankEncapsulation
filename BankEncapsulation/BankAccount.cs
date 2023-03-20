using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
    public BankAccount()
        {

        }

    private double _balance = 0;

    public void Deposit(double num)
    {
        _balance += num;//-balance = _balance + amount;
        Console.WriteLine("Deposit Accepted");
    }

        //Overload Deposit Method
        public void Deposit()
        {
            bool depositAmount = false;
            double amount;
            bool nextDeposit;


            do
            {
                Console.WriteLine("How much would you like to deposit?");
                Console.Write("$");
                depositAmount = double.TryParse(Console.ReadLine(), out amount);

                if (!depositAmount)
                {
                    Console.WriteLine("Invalid input. Please try again. \n");
                }
            } while (!true);

            Thread.Sleep(1000);

            Console.WriteLine($"${amount} Deposited Accepted");
            _balance += amount;

            Thread.Sleep(1000);

            GetBalance();

            Thread.Sleep(2000);


            //    do
            //    {
            //        Console.WriteLine("Are there any other deposits you would like complete? \n Yes/No");
            //        nextDeposit = (Console.ReadLine();

            //        if (nextDeposit = "no")
            //        {
            //            Console.WriteLine("Have a great day");
            //        }
            //    } while (nextDeposit = "yes");
            //    de

        }
        public void GetBalance()
        {
                Console.WriteLine();
                Console.WriteLine($"The current account balance is:$" +
                    $"{_balance}");
                //Console.WriteLine($"${_balance}");
        }
    }

}
