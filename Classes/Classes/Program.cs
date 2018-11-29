using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //var person = Person.Parse("Thaymes");
            //person.Introduce("Mosh");
            var customer = new Customer(1,"Thaymes");


            var  order =new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
