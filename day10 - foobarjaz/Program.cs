﻿using System;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 105; 

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("foobarjazz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("foobar");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("foojazz");
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("barjazz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("bar");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("jazz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
