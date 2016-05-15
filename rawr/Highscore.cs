using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWR
{
    [Serializable]
    public class Highscore
    {
        public String name { get; set; }
        public String score { get; set; }

        public Highscore() {
        }

        public Highscore(String Name,String Score) {
            name = Name;
            score = Score;
        }

      
    }
}
