using System;
using System.Diagnostics;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        int Function1(int input)
        {
            switch (input)
            {
                case 1:
                case 2:
                case 3:
                    return 1;

                case 4:
                case 5:
                case 6:
                    return 2;
                default:
                    return 3;
            }
        }

        int Function2(int input)
        {
            return input switch
            {
                >=1 and <=3 => 1,
                >=4 and <=6 => 2,
                _ => 3
            };
        }
    }
}