using System;

namespace BoxingAndUnboxingOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boxing and Unboxing Operations!");

            //Declare a Variable
            int x = 20;
            Console.WriteLine($"x = {x}");

            //Perform the Boxing Operation
            object obj = x; //BOXING
            Console.WriteLine($"Object = {obj}");

            //Perform the Unboxing Operation
            int y = (int)obj; //UNBOXING
            Console.WriteLine($"y = {y}");
        }
    }
}
