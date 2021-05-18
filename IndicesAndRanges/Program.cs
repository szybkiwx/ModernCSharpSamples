using System;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };

            var elementAt3 = arr[3];
            var elementLastMinus1 = arr[^1]; // ^n -> (Length - n )
            
            var emptyArray = arr[3..3];
            var arrayWithOneElement = arr[3..5];
            var fullArray = arr[0..^0]; // 
            var fullArray2 = arr[..]; // 
        }
    }
}