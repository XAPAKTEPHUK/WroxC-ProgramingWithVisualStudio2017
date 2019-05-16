/* Ivan Boychuk
 * Chapter 4 - Flow Control
 * Using while loops */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(ReadLine()) / 100.0;
            WriteLine("What balace would you like to have?");
            targetBalance = ToDouble(ReadLine());
            int totalYears = 0;

            while (balance < targetBalance) 
            {
                balance += interestRate;
                ++totalYears;
            }
           
            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")}" +
                $" you will have a balance of {targetBalance}");
            if (totalYears == 0)
                WriteLine("To be honest you really didn't have to use this calculator.");
            ReadKey();
        }
    }
}
