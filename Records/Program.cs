using System;

namespace Records
{
    public class PersonA
    {
        public PersonA(string firstName, string lastName, string[] phoneNumbers)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public string FirstName { get; }
        public string LastName { get; }
    }


    record PersonB(string FirstName, string LastName, string[] PhoneNumbers);
    
    class Program
    {
        static void Main(string[] args)
        {
            var phones = new[] { "1234567" };
            
            var person1 = new PersonB("Marek", "Szala", new string[0]);
            var person2 = new PersonB("Marek", "Szala", new string[0]);
            
            //person1.FirstName = "Andrzej";

            var person3 = person1 with { FirstName = "Andrzej" };

            var (name, lastName, p) = person1;
            
            Console.WriteLine(person1 == person2);
        }
    }
}