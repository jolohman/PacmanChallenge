using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanChallenge
{
    public class LifeData
    {
        //Properties
        public int GainLife { get; set; }
        public int GhostofDeath { get; set; }

        //Constructors
        public LifeData(string name)
        {
            this.GainLife = 1;
            this.GhostofDeath = -1;
        }
    }
}
