using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Student_Activities
{
    internal class Sports
    {

        private string sportName;
        private int teamSize;

        public string SportName
        {
            get { return sportName; }
            set { sportName = value; }
        }

        public int TeamSize
        {
            get { return teamSize; }
            set { teamSize = value; }
        }

        public Sports() { }

        public Sports(string sportName, int teamSize)
        {
            this.sportName = sportName;
            this.teamSize = teamSize;
        }

        public void Participate()
        {
            Console.WriteLine($"Playing {sportName} in a team of {teamSize}.")
        }

    }
}
