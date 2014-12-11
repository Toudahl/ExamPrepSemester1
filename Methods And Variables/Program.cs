using System;
using ClassLibrary;

namespace Methods_And_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of methods, can be found in these classes.
            BankCustomer Bob = new BankCustomer("Bob");
            RobTheRobber Rob = new RobTheRobber(); // Example of static can be found in this class
            RobTheRobber.RobFrom(Bob);
            if (Bob.MoneyOnPerson == 0)
            {
                Console.WriteLine(Bob + ": Damn, he got all my money");
                Console.WriteLine("Im lucky ive got some left on my account");
                Bob.CheckAccount();
            }

            Rob.Brag();

            

        }
    }
}
