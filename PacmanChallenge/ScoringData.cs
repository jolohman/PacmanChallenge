using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanChallenge
{
    public class ScoringData
    {
        public static Dictionary<string, int> StaticPoints = new Dictionary<string, int>
        {
            { "Dot", 10 },
            { "Cherry", 100 },
            { "Strawberry", 300 },
            { "Orange", 500 },
            { "Apple", 700 },
            { "Melon", 1000 },
            { "Galaxian", 2000 },
            { "Bell", 3000 },
            { "Key", 5000 },
        };

        public static Dictionary<string, int> ExponentialPoints = new Dictionary<string, int>
        {
            { "VulnerableGhost", 200 },
        };

        private int GhostEaten()
        {
            var exponentialValue = ExponentialPoints["VulnerableGhost"];

            for (int i = 0; i < CountGhostEaten, i++)
            {
                exponentialValue *= 2;
            }

            CountGhostEaten++;
            return exponentialValue;
            
        }

        private int CountGhostEaten { get; set; }


        public static int CollectPoints(string pointObject)
        {
            int result;
            if (StaticPoints.TryGetValue(pointObject, out result ))
            {
                return result;
            }
            else () 
            {
                ex
            }
        }
    }
}
