using System;

namespace PatternMatching
{
    public record Order(int Items, decimal Cost);

    public class OrderOperations
    {
        public double CalculateDiscount(Order order) => order switch
        {
            (Items: > 10, Cost: > 1000.00m) => 0.10,
            (Items: > 5, Cost: > 500.00m) => 0.05,
            { Cost: > 250.00m } => 0.02,
            null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
            var o => 0,
        };
    }
}