using System;

namespace ClassLibrary
{
    // TODO: Inherritance
    class BankTeller : Bank
    {
        /// <summary>
        /// The BankTeller manages the withdrawal process.
        /// Ideally there would be an account number or someother identification going on too.
        /// </summary>
        /// <param name="moneyToWithdraw"></param>
        /// <returns></returns>
        public decimal WithdrawMoney(decimal moneyToWithdraw)
        {
            if (AnAccount >= moneyToWithdraw)
            {
                Console.WriteLine("You have withdrawn " + moneyToWithdraw + " from your account" +
                                  "\nYou now have: " + AccountStatus());
                return Withdraw(moneyToWithdraw);
            }
            Console.WriteLine("You do not have enough funds in your account to do that.");
            return 0;
        }

        /// <summary>
        /// The BankTeller manages the withdrawal process.
        /// Ideally there would be an account number or someother identification going on too.
        /// </summary>
        /// <param name="moneyToDeposit"></param>
        /// <returns></returns>
        public bool DepositMoney(decimal moneyToDeposit)
        {
            try
            {
                Deposit(moneyToDeposit);
                Console.WriteLine("The money was added to your account. You now have: " + AccountStatus() +" in your account.");
                return true;
            }
            catch (Exception exception)
            {
                //TODO: Catching an exception thrown somewhere else.
                Console.WriteLine(exception.Message);
            }
            return false;
        }

        /// <summary>
        /// Get the account status. This bank only service one customer.
        /// </summary>
        /// <returns></returns>
        public decimal AccountStatus()
        {
            return AnAccount;
        }
    }
}
