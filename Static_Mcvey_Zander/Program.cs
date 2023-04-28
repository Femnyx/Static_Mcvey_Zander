using System;

namespace Static_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integers equations.
            Console.WriteLine("Integer Methods");
            Console.WriteLine("15 + 88 is " + Calculate.Add(15, 88));
            Console.WriteLine("53 - 86 is " + Calculate.Sub(53, 86));
            Console.WriteLine("5 * 56 is " +Calculate.Mult(5, 56));
            Console.WriteLine("84 / 6 is " + Calculate.Div(84, 6));

            //Floats equations.
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine("15.14 + 88.636 is " + Calculate.Add(15.14f, 88.636f));
            Console.WriteLine("53.965 - 86.51 is " + Calculate.Sub(53.965f, 86.51f));
            Console.WriteLine("5.90 * 56.271 is " + Calculate.Mult(5.90f, 56.271f));
            Console.WriteLine("84.572 / 6.12 is " + Calculate.Div(84.572f, 6.12f));
        }
    }
}
