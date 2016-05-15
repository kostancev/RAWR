using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    [Serializable]
    public class Highscores
    {
        public List<Highscore> highscores { get; set; }

        public Highscores() {
            highscores = new List<Highscore>();
        }

        public void addHighScore(Highscore h) {
            highscores.Add(h);
        }

        public void removeHighScore(Highscore h) {
            highscores.Remove(h);
        }

        public void sortHighScores() {
            
        }

    }
}
