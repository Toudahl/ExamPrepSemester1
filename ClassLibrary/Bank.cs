using System;

namespace ClassLibrary
{
    /// <summary>
    /// Abstract class, it cannot be instantiated.
    /// </summary>
    abstract class Bank
    {
        /// <summary>
        /// Some private fields, so only the bank can reach it.
        /// </summary>
        private decimal _totalMoneyInBank;
        private decimal _anAccount;

        /// <summary>
        /// A public constructor, means any class can construct it (as a subclass of course)
        /// </summary>
        public Bank()
        {
            _totalMoneyInBank = decimal.MaxValue;
            _anAccount = int.MaxValue;
        }


        /// <summary>
        /// Protected means that all subclasses can reach it.
        /// The private setter however ensures that it is only
        /// the base class that can change the value on the account
        /// </summary>
        protected decimal AnAccount
        {
            get { return _anAccount; }
            private set { _anAccount = value; }
        }

        /// <summary>
        /// Withdrawing should only be allowed from subclasses
        /// </summary>
        /// <param name="moneyToWithdraw"></param>
        /// <returns></returns>
        protected decimal Withdraw(decimal moneyToWithdraw)
        {
            if ((TotalMoneyInBank - moneyToWithdraw) >= 0)
            {
                if ((AnAccount - moneyToWithdraw) >= 0)
                {
                    TotalMoneyInBank -= moneyToWithdraw;
                    AnAccount -= moneyToWithdraw;
                    return moneyToWithdraw;
                }
            }
            return 0;
        }

        /// <summary>
        /// Depositing should only be allowed by subclasses
        /// Make sure that someone knows that it went wrong, by throwing an exception.
        /// </summary>
        /// <param name="moneyToDeposit"></param>
        protected void Deposit(decimal moneyToDeposit)
        {
            decimal tempDeposit = AnAccount + moneyToDeposit;

            if (tempDeposit > AnAccount)
            {
                AnAccount = tempDeposit;
            }
            else
            {
                throw new Exception("The funds was not added to the account");
            }
        }
        
        /// <summary>
        /// Private so only the bank it self knows the total amount of money in the bank.
        /// </summary>
        private decimal TotalMoneyInBank
        {
            get { return _totalMoneyInBank; }
            set { _totalMoneyInBank = value; }
        }
    }
}
