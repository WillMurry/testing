using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<Team> AllTeams = new List<Team>();

        public static List<Team> Readgdb(string path, bool hasHeaders = true)
        {
            var list = new List<Team>();
            foreach (var line in File.ReadLines(path).Skip(hasHeaders ? 1 : 0))
            {
                list.Add(new Team(line));
            }
            return list;
        }

        public static List<Data> Stats(string path, int i, bool hasHeaders = true)
        {
            var list = new List<Data>();
            foreach (var line in File.ReadLines(path).Skip(hasHeaders ? 1 : 0))
            {
                list.Add(new Data(line, i));
            }
            return list;
        }

        public Form1()
        {
            InitializeComponent();
            string[] Teams = new string[] { "Data/Team-Data.csv" };
            string[] Team1 = new string[] { "Data/Team-Data1.csv" };
            string[] Team2 = new string[] { "Data/Team-Data2.csv" };
            string[] Team3 = new string[] { "Data/Team-Data3.csv" };

            var TotalRoster = Readgdb(Teams[0]);
            var GiveawayStats = Stats(Team1[0], 0);
            var DefenseStats = Stats(Team2[0], 1);

            TimeCombobox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;
            foreach (var t in TotalRoster)
            {
                AwayComboBox.Items.Add(t.Name);
                HomeComboBox.Items.Add(t.Name);

                foreach (var x in GiveawayStats)
                {
                    if (t.Name == x.Name)
                    {
                        t.Giveaways = x.Giveaways;
                        t.Takeaways = x.Takeaways;
                        break;
                    }
                }
                foreach (var x in DefenseStats)
                {
                    if (t.Name == x.Name)
                    {
                        t.OPPG = x.OPPG;
                        t.ORPG = x.ORPG;
                        break;
                    }
                }
                AllTeams.Add(t);
            }
            AwayComboBox.SelectedIndex = 0;
            HomeComboBox.SelectedIndex = 0;
        }

        private void ChoiceButton_Click(object sender, EventArgs e)
        {
            if (AwayComboBox.Text != HomeComboBox.Text)
            {
                WinnerLabel.Visible = true;
                WinnerLabel.Text = Decision(AwayComboBox.Text, HomeComboBox.Text);
            }
            else
            {
                MessageBox.Show("No Clone Matchups are alowed", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string Decision (string a, string b)
        {
            string winner = "";
            double a1 = 0;
            double a2 = 0;
            double a3 = 0;
            double b1 = 0;
            double b2 = 0;
            double b3 = 0;
            bool home = false;
            bool special = false;

            if (LocationComboBox.SelectedIndex == 0)
            {
                home = true;
            }
            if (TimeCombobox.SelectedIndex == 0)
            {
                special = true;
            }
            foreach (var i in AllTeams)
            {
                if (i.Name == a)
                {
                    a1 = (i.RPG + i.PPG) * i.Giveaways;
                    a2 = (i.ORPG + i.OPPG) * i.Takeaways;
                    a3 = a1 - a2;
                }
                if (i.Name == b)
                {
                    b1 = (i.RPG + i.PPG) * i.Giveaways;
                    b2 = (i.ORPG + i.OPPG) * i.Takeaways;
                    b3 = b1 - b2;
                    if (home == true)
                    {
                        if (special == true)
                        {
                            b3 = b3 * 1.5;
                        }
                        else
                        {
                            b3 = b3 * 1.25;
                        }
                    }
                }
            }
            if (a3 >= b3)
            {
                winner = a;
            }
            else
            {
                winner = b;
            }
            return winner;
        }        
    }
}
