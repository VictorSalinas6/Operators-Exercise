using System.Reflection.PortableExecutable;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int subtraction = a - b;
            int multiplication = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {subtraction}");
            Console.WriteLine($"{a} * {b} is {multiplication}");

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}\n");

            Console.WriteLine("Whats is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe area of a circle with radius of {radius} is {AreaOfCircle(radius)}\n");

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k);
        }

        public static double AreaOfCircle (double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
    }
}
