using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        public int PlayerScore1 { get; set; }

        public bool IsPlaying = true;
        public bool IsPlaying2 = true;

        public bool winner;
        

        public void Score(int runs)
        {

            if (IsPlaying)
            {
                PlayerScore += runs;
            }
            
        }

        public void Score1(int runs2)
        {
            if (IsPlaying2)
            {
                PlayerScore1 += runs2;
            }
        }
    }
}
