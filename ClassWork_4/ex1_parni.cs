using System;

namespace ParniChyslaNamespace

{
    public class RandomNumbGen
    {
        private Random rand;

        public RandomNumbGen()
        {
            rand = new Random();
        }

        public int GenParniRandNum()
        {            
            return rand.Next(1, 6) * 2;
        }
    }
}