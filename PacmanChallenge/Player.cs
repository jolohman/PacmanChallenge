using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanChallenge
{
    class Player : PlayerInput
    {
        //Constants
        const int Min_Lives = 0;

        //Constructors
        public Player(string name )
        {
            this.IsAlive = true;
            this.TotalLives = 3;
            this.TotalPoints = 5000;
            this.TotalLivesGained = 0;
        }


        //Methods
        public int EatingMachine()
        {

            return 0;
        }

        public int
    }
}
