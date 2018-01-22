using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanChallenge
{
    public static class PlayPacman
    {
        public static void Begin()
        {
            var runGame = GetGamePlayInfo;


            //Constructors
            PlayPacman()
            {
                this.IsAlive = true;
                this.TotalLives = 3;
                this.TotalPoints = 5000;
                this.TotalLivesGained = 0;
            }


            //Methods
            int EatingMachine()
            {

                return 0;
            }
        }

        public static string[] GetGamePlayInfo()
        {
            var file = File.ReadAllText(@"C:\DotNetProjects\PacmanChallenge\KataPacman-seq.txt");
            string[] stream = file.Split(',');
            return stream;
        }
    }
}
