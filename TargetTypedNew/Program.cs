using System;
using System.Collections.Generic;

namespace TargetTypedNew
{
    record Person(string FirstName, string LastName);
    
    class Program
    {
        private Dictionary<string, string> SomeDict = new();
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public Person CreatePerson() => new("Marek", "Szala");
        
        public Person CreateOtherPerson()
        {
            const string name = "Bjørn";
            const string lastname = "Tveter";
            
            return new Person(name, lastname);
        }
    }
}