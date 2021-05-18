using System;

namespace InitSetters
{
    public class Person
    {
        public string FirstName { get; init; } 
        public string LastName { get; init; } 
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Marek",
                LastName = "Szala"
            };

            //person.FirstName = "Andrzej";
            
            Console.WriteLine("Hello World!");
        }
    }
}