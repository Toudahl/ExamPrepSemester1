using System;

namespace ClassLibrary
{
    public class Class1
    {
        private int _integer = 0;

        public Class1()
        {
            Console.WriteLine("No parameter");
        }

        public Class1(string singleParameter)
        {
            Console.WriteLine("The same class instantiated with one parameter");
        }

        public Class1(string singleParameter, string doubleParameter)
        {
            Console.WriteLine("The same class instantiated with two parameters");
        }

        public int Integer
        {
            get { return _integer; }
            set { _integer = value; }
        }
    }
}
