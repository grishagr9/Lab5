using System.Numerics;

namespace MyProject
{
    class Program
    {
        public static BigInteger Factorial(int n)
        {
                var factorial = new BigInteger(1);
                for (int i = 1; i <= n; i++)
                    factorial *= i;

                return factorial;
        }
        static void Main(string[] args) {
            int a = 5;
            int axaxaxaa
                //int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(a));
        }
    }
}
