using System;

namespace NullCoalescing
{
    record Person(int Id, string FirstName, string LastName);

    class Program
    {
        static void Main(string[] args)
        {
            var person = GetPerson(12) ?? new Person(0, "John", "Doe");
            //equivalent of:
            //var person = GetPerson(12);
            //if(person is null) {
            //    person = new Person(0, "John", "Doe");
            //}
            
            var person2 = GetPerson(12);
            person2 ??= new Person(0, "John", "Doe");
        }

        public static Person GetPerson(int id)
        {
            return null;
        }

        public static Person GetPerson(int? id)
        {
            _ = id ?? throw new ArgumentNullException(nameof(id));
            return new Person(id.Value, "Some", "Fella");
        }
    }
}