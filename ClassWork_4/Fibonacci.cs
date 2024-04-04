using System;

namespace FibonacciNumbersGenerator
{
    public class MyRandomFibonacci
    {
        private Random rand;

        public MyRandomFibonacci()
        {
            rand = new Random();
        }

        public int GenerateFibonacciNumber()
        {
            int num;
            do
            {
                num = rand.Next(2, 10001); 
            } while (!IsFibonacci(num)); 
            return num;
        }

        private bool IsFibonacci(int num)
        {
            int a = 0, b = 1;
            while (b < num)//дуже красива формула находження числа Фібоначчі, сподобалось
            {
                int temp = b;
                b += a;
                a = temp;
            }
            return b == num;
        }
    }
}
