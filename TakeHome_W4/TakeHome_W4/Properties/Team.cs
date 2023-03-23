using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Team
    {
        public string teamName;
        public string teamCountry;
        public string teamCity;
        public List<Player> Players=new List<Player>();
        
        public Team(string teamName,string teamCountry,string teamCity) { 
            
            this.teamName = teamName;
            this.teamCountry = teamCountry;
            this.teamCity = teamCity;
            Players= new List<Player>();
        }
    }

