using System;

namespace ExpressionBodiedMembers
{
    class Person
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public void SetFirstName(string firstName) => FirstName = firstName;
    }

    class Order
    {
        private readonly int _quantity;
        private readonly double _price;
        public Order(int quantity, double price) => (_quantity, _price) = (quantity, price);
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}