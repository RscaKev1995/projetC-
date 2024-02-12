using System;

namespace carsGame.Classes
{
    public class Des
    {
        private Random random;

        public Des()
        {
            random = new Random();
        }

        public int LancerDes()
        {
            return random.Next(1, 7); 
        }
    }
}
