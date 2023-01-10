using System;
using System.Data;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args )
        {
            // type casting

            // implicite type casting : char -> int -> float -> double
            int x = 5;
            float z = x;
            double y = z;

            //float j = Convert.ToInt32(5.55);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(j);

            // reading input from user
            //Console.WriteLine("Enter your name: ");
            //string user = Console.ReadLine();
            //Console.WriteLine("Hello " + user);

            //Console.WriteLine("How many candies do you want?");
            //string candies = Console.ReadLine();
            //Console.WriteLine("You will get total " + (Convert.ToInt32(candies) + 4) + " candies !");

            string name = "Deve";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine($"My name is {name}.");
            Console.WriteLine(name.LastIndexOf('e'));

            Console.ReadLine(); // it will take input from user and we are using it for holding the console
        }
    }
}


