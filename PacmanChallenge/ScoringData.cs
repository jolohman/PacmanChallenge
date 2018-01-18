using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanChallenge
{
    public class ScoringData
    {
        //Properties
        public int DotPoint { get; set; }
        public int VulGhostPoint { get; set; }
        public int Cherry { get; set; }
        public int Strawberry { get; set; }
        public int Orange { get; set; }
        public int Apple { get; set; }
        public int Melon { get; set; }
        public int Galaxian { get; set; }
        public int Bell { get; set; }
        public int Key { get; set; }


        //Construtors
        public ScoringData(string name)
        {
            this.DotPoint = 10;
            this.VulGhostPoint = 200;
            this.Cherry = 100;
            this.Strawberry = 300;
            this.Orange = 500;
            this.Apple = 700;
            this.Melon = 1000;
            this.Galaxian = 2000;
            this.Bell = 3000;
            this.Key = 5000;
        }
    }
}
