using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        private static int recursiveLoopCount = 0;
        static void Main(string[] args)
        {
            //TODO: Example of a string array
            string[] stringArray = {"first string", "Second string", "third string", "fourth string"};
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (var s in stringArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int count = 0;
            int length = stringArray.Length;
            while (count < length)
            {
                Console.WriteLine(stringArray[count]);
                count++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int whileLoopCount = 0;
            while (true)
            {
                Console.WriteLine("loop the loop");
                whileLoopCount++;
                if (whileLoopCount == 4)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int doingStuff = 0;
            do
            {
                Console.WriteLine("doing stuff");
                doingStuff++;
            } while (doingStuff < 4);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                if (i < 9)
                {
                    // If the integer is smaller than 9 continue (break/skip) to the next incremented run through of the for loop
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            RecursiveLooping(ref recursiveLoopCount);
        }
        //TODO: Reference keyword
        private static void RecursiveLooping(ref int input)
        {
            if (input < 4)
            {
                Console.WriteLine("One more time");
                input++;
                RecursiveLooping(ref input);
            }
        }
    }
}
