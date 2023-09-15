using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberguesser_ILA2_1300
{
    internal class Highscore
    {
        private List<int> highscores = new List<int>();

        public void AddScore(int score)
        {
            highscores.Add(score);
        }

        public void DisplayHighscores()
        {
            highscores.Sort();//Chat GPT
            Console.WriteLine("Highscores:");

            for (int i = 0; i < highscores.Count; i++)
            {
                Console.WriteLine($"Platz {i + 1}: {highscores[i]} Versuche");
            }
        }
    }
}
