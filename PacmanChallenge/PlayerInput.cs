using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanChallenge
{
    public abstract class PlayerInput
    {
        //Properties
        public bool IsAlive { get; set; }
        public int TotalLives { get; set; }
        public int TotalPoints { get; set; }
        public int TotalLivesGained { get; set; }
    }
}
