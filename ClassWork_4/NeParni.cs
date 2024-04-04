using System;

namespace NeParniChyslaNamespace

{
    public class NeParniRandomNumbGen
    {
        private Random rand;

        public NeParniRandomNumbGen()
        {
            rand = new Random();
        }

        public int NeParniGenParniRandNum()
        {
            return rand.Next(1, 6) * 2 - 1;
        }
    }
}