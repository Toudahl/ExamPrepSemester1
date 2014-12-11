using System;
using ClassLibrary;

namespace PropertiesAndBackingFields
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Numbers

            // bytes take up 8 bits of memory

            // sbyte

            Console.WriteLine("The min sbyte is: " + sbyte.MinValue);
            Console.WriteLine("The max sbyte is: " + sbyte.MaxValue);

            // byte

            Console.WriteLine("The min byte is: " + byte.MinValue);
            Console.WriteLine("The max byte is: " + byte.MaxValue);

            // shorts take up 16 bits of memory

            // short

            Console.WriteLine("The min short is: " + short.MinValue);
            Console.WriteLine("The max short is: " + short.MaxValue);

            // ushort

            Console.WriteLine("The min ushort is: " + ushort.MinValue);
            Console.WriteLine("The max ushort is: " + ushort.MaxValue);

            // ints take up 32 bits of memory

            // int

            Console.WriteLine("The min int is: " + int.MinValue);
            Console.WriteLine("The max int is: " + int.MaxValue);

            // uint

            Console.WriteLine("The min uint is: " + uint.MinValue);
            Console.WriteLine("The max uint is: " + uint.MaxValue);

            // longs take up 64 bits of memory

            // long

            Console.WriteLine("The min long is: " + long.MinValue);
            Console.WriteLine("The max long is: " + long.MaxValue);

            // ulong

            Console.WriteLine("The min ulong is: " + ulong.MinValue);
            Console.WriteLine("The max ulong is: " + ulong.MaxValue);

            // floats take up 32 bits of memory

            // float floatingPoint = 2.1F


            Console.WriteLine("The min float is: " + float.MinValue);
            Console.WriteLine("The max float is: " + float.MaxValue);

            // decimals take up 128 bits of memory

            // decimal
            // If the M (or m) is not there, the number is treated as a decimal.
           
            Console.WriteLine("The min decimal is: " + decimal.MinValue);
            Console.WriteLine("The max decimal is: " + decimal.MaxValue/1000);

            // doubles take up 64 bit of memory

            // double
         
            Console.WriteLine("The min double is: " + double.MinValue);
            Console.WriteLine("The max double is: " + double.MaxValue);

            #endregion


            char C = 'C'; // takes up 16 bits
            string thisVariableContainsAString = "and this is the string it contians"; // Deppends on the size of the array
            object thisIsAnObject = new object(); // But it doesnt really do anything.

            bool trueOrFalse = true; // default value false. 8 bits of memory
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bob at the bank:");
            Console.WriteLine();
            Console.WriteLine();

            BankCustomer Bob = new BankCustomer("Bob");


            Bob.CheckAccount();
            Bob.Withdraw(123214315M);
            Bob.Deposit(123214315M);
            Bob.CheckAccount();

            // Instantiating a public class from an other project.
            // Class1 classFromOtherProject = new Class1(); //Wont work because it is by default private.
            Class2 classFromOtherProject = new Class2();

        }
    }
}
