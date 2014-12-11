using System;

namespace ClassLibrary
{
    // TODO: Example of static and non static.
    // Static belongs to the class, non static belongs to the instance.
    public class RobTheRobber
    {
        private static decimal _loot;
        private static string victimName;

        // TODO: Polymorphism
        public static void RobFrom(IVictim victim)
        {
            victimName = victim.ToString();
            Loot = victim.MoneyOnPerson;
            victim.MoneyOnPerson = 0;
        }

        private static decimal Loot
        {
            get { return _loot; }
            set
            {
                Console.WriteLine("Hahaha, i got all your money");
                _loot = value;
            }
        }

        public void Brag()
        {
            if (Loot > 0)
            {
                Console.WriteLine("Haha, i just stole: " + Loot + " from " + victimName);
            }
        }

    }
}
