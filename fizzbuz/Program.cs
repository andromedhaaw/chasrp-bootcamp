// See https://aka.ms/new-console-template for more information
namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("foobar");
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("foo");
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("bar");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
