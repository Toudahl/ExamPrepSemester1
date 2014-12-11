using System;

namespace ClassLibrary
{
    public class BankCustomer: IVictim
    {
        private decimal _moneyOnPerson;
        private BankTeller Cheryl;
        private string _name;

        public BankCustomer(string name)
        {
            _name = name;
            _moneyOnPerson = int.MaxValue;
            Cheryl = new BankTeller();
        }

        public string Name
        {
            get { return _name; }
            set { _name = _name; }
        }

        public decimal MoneyOnPerson
        {
            get { return _moneyOnPerson; }
            set { _moneyOnPerson = value; }
        }

        public void Deposit(decimal amountToDeposit)
        {
            if (Cheryl.DepositMoney(amountToDeposit))
            {
                MoneyOnPerson -= amountToDeposit;
            }
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            MoneyOnPerson += Cheryl.WithdrawMoney(amountToWithdraw);
        }

        public void CheckAccount()
        {
            Console.WriteLine("Seems ive got: " + Cheryl.AccountStatus() + " in my account");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
