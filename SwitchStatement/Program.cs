using System;
using System.Diagnostics;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        int Function1(int input)
        {
            switch (input)
            {
                case 1:
                    return 1;
                case 4:
                    return 2;
                default:
                    return 3;
            }
        }

        int Function2(int input)
        {
            return input switch
            {
                1 => 1,
                4 => 2,
                _ => 3
            };
        }
    }
}