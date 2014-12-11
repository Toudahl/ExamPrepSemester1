using System;
using ClassLibrary;

namespace ObjectInitializationAndConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: overrideing constructors

            // Initialization of Class1, without any parameter.
            Class1 noParameter = new Class1();
            Console.WriteLine(noParameter.Integer);

            // Initialization of Class1, with one parameter (overloaded)
            Class1 oneParameter = new Class1("single");
            oneParameter.Integer = 1;
            Console.WriteLine(oneParameter.Integer);

            // Initialization of Class1, with two parameters (overloaded)
            Class1 twoParameters = new Class1("first parameter", "second parameter");
            twoParameters.Integer = 2;
            Console.WriteLine(twoParameters.Integer);
        }
    }
}
