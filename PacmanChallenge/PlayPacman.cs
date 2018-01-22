using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanChallenge
{
    class PlayPacman : PlayerInput
    {
        public static void Begin()
        {
            GetGamePlayInfo;
        }

        //Constructors
        public PlayPacman()
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

        public static string[] GetGamePlayInfo()
        {
            var path = @"C:\DotNetProjects\PacmanChallenge\KataPacman-seq.txt";
            var file = File.ReadAllText(path);
            string[] stream = file.Split(',');
            return stream;
        }
    }
}
