using System;
using ClassLibrary;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Example of a class

            BankCustomer Bob = new BankCustomer("Bob");
            Bob.CheckAccount();
            Console.WriteLine(Bob.MoneyOnPerson + " in my pockets");
            Bob.Deposit(Bob.MoneyOnPerson);
            Console.WriteLine(Bob.MoneyOnPerson + " in my pockets");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Bob.Withdraw(4294967294);
            Bob.CheckAccount();
            Bob.Withdraw(10);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            RobTheRobber.RobFrom(Bob);

            RobTheRobber Rob = new RobTheRobber();
            Console.WriteLine();
            Console.WriteLine();
            Rob.Brag();

        }
    }
}
