using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Team
    {
        public string Name;
        public double RPG = 0;
        public double PPG = 0;
        public double Giveaways = 0;
        public double Takeaways = 0;
        public double ORPG = 0;
        public double OPPG = 0;
        public double Points = 0;

        // Constructor that takes one argument:
        public Team(string line)
        {
            var data = line.Split(',');
            double games = 0;
            Name = data[1];
            games = Convert.ToDouble(data[2]);
            RPG = Convert.ToDouble(data[3]) / games;
            RPG = Math.Round(RPG, 2, MidpointRounding.AwayFromZero);
            PPG = Convert.ToDouble(data[4]) / games;
            PPG = Math.Round(PPG, 2, MidpointRounding.AwayFromZero);
        }
    }

    public class Data
    {
        public string Name;
        public double RPG = 0;
        public double PPG = 0;
        public double Giveaways = 0;
        public double Takeaways = 0;
        public double ORPG = 0;
        public double OPPG = 0;
        // Constructor that takes one argument:
        public Data(string line , int h)
        {
            var data = line.Split(',');
            Name = data[1];
            
            if (h == 0)
            {
                Giveaways = Convert.ToInt32(data[5]);
                Takeaways = Convert.ToInt32(data[8]);
            }
            if (h == 1)
            {
                double game = Convert.ToDouble(data[2]);
                ORPG = Convert.ToDouble(data[3]) / game;
                ORPG = Math.Round(ORPG, 2, MidpointRounding.AwayFromZero);
                OPPG = Convert.ToDouble(data[4]) / game;
                OPPG = Math.Round(OPPG, 2, MidpointRounding.AwayFromZero);
            }
        }
    }
}
