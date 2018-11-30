using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1989, 03, 18));
            Console.WriteLine(person.Age);
        }
    }
}
