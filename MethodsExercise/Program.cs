using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            console.writeline("what is your name?");
            string name = console.readline();

            console.writeline("what is your favoriate color?");
            string color = console.readline();

            console.writeline("what is your favorite animal?");
            string animal = console.readline();

            console.writeline("what is your favorite band?");
            string band = console.readline();

            console.writeline($"{name} went to go see {band} live but a {color} {animal} blocked their drive way making them late.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1,num2);
            Console.WriteLine($"final sum for addition {sum}");

            Console.WriteLine("Give me a number to multiply");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to multiply");
            int num4 = int.Parse(Console.ReadLine());

            int sum2 = Multiply(num3, num4);

            Console.WriteLine($"final sum for multiplication {sum2}");
        }

        public static int Sum(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public static int Multiply (int operand1, int operand2)
        {
            return operand1* operand2;
        }
    }
}
