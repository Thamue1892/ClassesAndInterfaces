using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //var person = Person.Parse("Thaymes");
            //person.Introduce("Mosh");
            //var customer = new Customer(1,"Thaymes");


            //var  order =new Order();
            //customer.Orders.Add(order);

            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            // var number = int.Parse("abc");


            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 5));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");

            }
        }
    }
}
