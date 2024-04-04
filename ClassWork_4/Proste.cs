using System;


namespace ProsteChyslo
{
    public class MyRandomProsteChisloGen
    {
        private Random rand;

        public MyRandomProsteChisloGen() { 
        rand = new Random();
        }

        public int GenProsteChislo()
        {
            int num;            
            do
            {
                num = rand.Next(2, 10001);// 2 - 10_000
            } while (!proste(num));
            return num;
        }

        private bool proste(int num)
        {
            if (num <= 1)
                return false;
            if (num <= 3)
                return true;
            if (num % 2 == 0 || num % 3 == 0)
                return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }
            return true;
        }

    }
}
