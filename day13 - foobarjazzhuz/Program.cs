using System;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 105; // Set the range up to 105

            for (int i = 1; i <= n; i++)
            {
                string output = "";

                // Apply the rules in the correct order
                if (i % 3 == 0)
                {
                    output += "foo";
                }
                if (i % 4 == 0)
                {
                    output += "baz";
                }
                if (i % 5 == 0)
                {
                    output += "bar";
                }
                if (i % 7 == 0)
                {
                    output += "jazz";
                }
                if (i % 9 == 0)
                {
                    output += "huzz";
                }

                // If output is empty, print the number itself
                if (output == "")
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(output + ", ");
                }
            }
        }
    }
}