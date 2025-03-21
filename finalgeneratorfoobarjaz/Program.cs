using System;
using System.Collections.Generic;

namespace Foobar
{
    class FoobarGenerator
    {
        private List<KeyValuePair<int, string>> rules;

        public FoobarGenerator()
        {
            rules = new List<KeyValuePair<int, string>>();
        }

        
        public void AddRule(int divisor, string output)
        {
            rules.Add(new KeyValuePair<int, string>(divisor, output));
        }

        
        public void PrintResult(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string output = "";

               
                foreach (var rule in rules)
                {
                    if (i % rule.Key == 0)
                    {
                        output += rule.Value;
                    }
                }

                
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

    class Program
    {
        static void Main(string[] args)
        {
            int n = 105; 
            FoobarGenerator generator = new FoobarGenerator();

            
            generator.AddRule(3, "foo");
            generator.AddRule(4, "baz");
            generator.AddRule(5, "bar");
            generator.AddRule(7, "jazz");
            generator.AddRule(9, "huzz");

            
            generator.PrintResult(n);
        }
    }
}
