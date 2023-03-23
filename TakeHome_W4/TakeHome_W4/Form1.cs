using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHome_W4
{
    public partial class Form1 : Form
    {
        List<Team> teamlist = new List<Team>();
        public Form1()
        {
            InitializeComponent();
           //Player playermu=new Player()
            Team MU = new Team("Manchaster United", "England", "Manchester");
            MU.Players.Add(new Player("David De Gea", "1", "GK"));
            MU.Players.Add(new Player("Phil Jones", "4", "DF"));
            MU.Players.Add(new Player("Victor Lindelof", "2", "DF"));
            MU.Players.Add(new Player("Eric Bailly", "3", "DF"));
            MU.Players.Add(new Player("Harry Maguire", "5", "DF"));
            MU.Players.Add(new Player("Bruno Fernandes", "8", "MF"));
            MU.Players.Add(new Player("Christian Eriksen", "14", "MF"));
            MU.Players.Add(new Player("Casemiro", "18", "MF"));
            MU.Players.Add(new Player("Marcus Rasford", "10", "FW"));
            MU.Players.Add(new Player("Anthony Martial", "9", "FW"));
            MU.Players.Add(new Player("Mason Greenwood", "11", "FW"));
            teamlist.Add(MU);

            Team liverpool = new Team("Liveppool", "England", "Liverpool");
            liverpool.Players.Add(new Player("Alisson Becker", "1", "GK"));
            liverpool.Players.Add(new Player("Joe Gomez", "2", "DF"));
            liverpool.Players.Add(new Player("Trent Alexander Arnold", "66", "DF"));
            liverpool.Players.Add(new Player("Virgil Van Djik", "4", "DF"));
            liverpool.Players.Add(new Player("Andy Robetson", "26", "DF"));
            liverpool.Players.Add(new Player("Fabinho", "3", "MF"));
            liverpool.Players.Add(new Player("James Milner", "7", "MF"));
            liverpool.Players.Add(new Player("Curtis Jones", "17", "MF"));
            liverpool.Players.Add(new Player("Mohamed Salah", "11", "FW"));
            liverpool.Players.Add(new Player("Roberto Firminho", "9", "FW"));
            liverpool.Players.Add(new Player("Darwin Nunez", "27", "FW"));
            teamlist.Add(liverpool);

            Team barca = new Team("Barcelona", "Spain", "Barcelona");
            barca.Players.Add(new Player("Marc Andre Ter Stegen", "1", "GK"));
            barca.Players.Add(new Player("Ronald Araujo", "4", "DF"));
            barca.Players.Add(new Player("Jordi Alba", "18", "DF"));
            barca.Players.Add(new Player("Eric Garcia", "24", "DF"));
            barca.Players.Add(new Player("Jules Kounde", "23", "DF"));
            barca.Players.Add(new Player("Sergio Busquet", "5", "MF"));
            barca.Players.Add(new Player("Gavi", "6", "MF"));
            barca.Players.Add(new Player("Pedri", "8", "MF"));
            barca.Players.Add(new Player("Robert Lewandowski", "9", "FW"));
            barca.Players.Add(new Player("Ansu Fati", "10", "FW"));
            barca.Players.Add(new Player("Ferran Torres", "11", "FW"));
            teamlist.Add(barca);

            cmbBox_Country.Items.Add("England");
            cmbBox_Country.Items.Add("Spain");


        }
        public void printlistplayer()
        {
            listBox_TeamList.Items.Clear();
            foreach (Team team in teamlist)
            {
                //MessageBox.Show(team.teamCountry+"="+ cmbBox_Country.Text+" "+team.teamName+"="+cmbBox_Team.Text);
                if (team.teamCountry == cmbBox_Country.Text && team.teamName == cmbBox_Team.Text)
                {
                    // MessageBox.Show("HAHAHAHA");
                    foreach (Player player in team.Players)
                    {
                        string name = player.playerName;
                        string num = player.playerNum;
                        string pos = player.playerPos;
                        string result = "(" + num + ") " + name + ". " + pos;
                        listBox_TeamList.Items.Add(result);

                    }
                }
            }
        }
        private void btn_AddTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_TeamName.Text) || string.IsNullOrEmpty(txtBox_TeamCountry.Text) || string.IsNullOrEmpty(txtBox_TeamCity.Text))
            {
                MessageBox.Show("INPUTTT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool found = false;
                
                foreach (Team t in teamlist)
                {
                    if (t.teamName == txtBox_TeamName.Text)
                    {
                        MessageBox.Show("Team Already Exist !!!!!!!!!!!!!!!!");
                        found = true;
                        break;
                    }


                }


                if (found == false)
                {
                    bool isCountry = false;
                    foreach (Team t in teamlist)
                    {
                        if (t.teamCountry == txtBox_TeamCountry.Text)
                        {
                            Team teamBaru = new Team(txtBox_TeamName.Text, txtBox_TeamCountry.Text, txtBox_TeamCity.Text);
                            teamlist.Add(teamBaru);
                            isCountry = true;
                            txtBox_TeamCity.Clear();
                            txtBox_TeamCountry.Clear();
                            txtBox_TeamName.Clear();
                            break;
                        }

                    }
                    if (isCountry == false)
                    {
                        cmbBox_Country.Items.Add(txtBox_TeamCountry.Text);
                        Team teamBaru = new Team(txtBox_TeamName.Text, txtBox_TeamCountry.Text, txtBox_TeamCity.Text);
                        teamlist.Add(teamBaru);
                        txtBox_TeamCity.Clear();
                        txtBox_TeamCountry.Clear();
                        txtBox_TeamName.Clear();
                    }


                }
            }
                
        }
        private void btn_AddPlayer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_PlayerName.Text) || string.IsNullOrEmpty(txtBox_PlayerNumber.Text) || string.IsNullOrEmpty(cmbBox_Country.Text)|| string.IsNullOrEmpty(cmbBox_Team.Text))
            {
                MessageBox.Show("INPUTTT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int count = -1;
                int simpan = 0;
                foreach (Team t in teamlist)
                {
                    count++;
                    if (t.teamName.Equals(cmbBox_Team.Text))
                    {
                        simpan = count;
                        break;
                    }
                }

                bool found = false;
                foreach(Player player in teamlist[simpan].Players)
                {
                    if(player.playerName == txtBox_PlayerName.Text)
                    {
                        found = true;
                        MessageBox.Show("Name Already EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(player.playerNum == txtBox_PlayerNumber.Text)
                    {
                        found = true;
                        MessageBox.Show("Number Already EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (found == false)
                {
                   
                    Player playerbaru = new Player(txtBox_PlayerName.Text, txtBox_PlayerNumber.Text, cmbBox_Position.Text);
                    
                    //teamlist[cmbBox_Team.SelectedIndex].Players.Add(playerbaru);// masih salah !!
                    teamlist[simpan].Players.Add(playerbaru);
                    listBox_TeamList.Items.Clear();
                    printlistplayer();
                    txtBox_PlayerName.Clear();
                    txtBox_PlayerNumber.Clear();

                }

            }

        }
        private void cmbBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBox_Team.Items.Clear();
            foreach (Team t in teamlist)
            {

                if (t.teamCountry == cmbBox_Country.Text)
                {
                    cmbBox_Team.Items.Add(t.teamName);
                }
            }
        }

        private void cmbBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            printlistplayer();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            
            if (listBox_TeamList.Items.Count <= 11)
            {
                MessageBox.Show("Players must be more or equal to 11.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int count = -1;
                int simpan = 0;
                foreach (Team t in teamlist)
                {
                    count++;
                    if (t.teamName.Equals(cmbBox_Team.Text))
                    {
                        simpan = count;
                        break;
                    }
                }
                listBox_TeamList.Items.RemoveAt(listBox_TeamList.SelectedIndex);
                teamlist[simpan].Players.RemoveAt(listBox_TeamList.SelectedIndex+1);
            }
            
        }
    }
}
