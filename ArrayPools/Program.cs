using System;
using System.Buffers;

namespace ArrayPools
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = ArrayPool<int>.Shared.Rent(2100);


            var span = arr.AsSpan();
            var slice = span.Slice(100, 1000);
            var slice2 = span.Slice(1100, 1000);
            slice.Fill(12);
            slice.CopyTo(slice2);
        }
    }
}