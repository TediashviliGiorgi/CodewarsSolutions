using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol20
{
    internal class Solution
    {

        private int number;
        private int lives;

        public Solution(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives == 0)
            {
                throw new Exception("An error occurred");
            }
            else if (this.number == n)
            {

                return true;
            }
            else if (this.number > n)

                this.lives -= 1;
            return false;
        }
    }
}

