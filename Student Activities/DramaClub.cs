using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student_Activities
{
    internal class DramaClub
    {

        private string playTitle;
        private string role;
        
        public string PlatTitle
        {
            get { return playTitle; } 
            set { playTitle = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public DramaClub() { }

        public DramaClub(string playTitle, string role)
        {
            this.playTitle = playTitle;        
            this.role = role;
        }

        public void Participate()
        {
            Console.WriteLine($"Acting as {role} in {playTitle}.");
        }

    }
}
