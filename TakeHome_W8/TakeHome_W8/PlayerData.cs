using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TakeHome_W8
{
    public partial class PlayerData : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string query = "";
        DataTable dtTeam=new DataTable();
        DataTable dtPlayer= new DataTable();
        DataTable dtInfoPemain1=new DataTable();
        DataTable dtidPemain=new DataTable();
        DataTable dtInfoPemain2= new DataTable();
        public PlayerData()
        {
            InitializeComponent();
        }
        private void idPemain(string namaPlayer)
        {
            dtidPemain = new DataTable();
            query = $"SELECT player_id\r\nFROM player\r\nWhere player_name='{namaPlayer}';";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtidPemain);
        }
        private void PlayerData_Load(object sender, EventArgs e)
        {
            query = "SELECT team_name FROM premier_league.team;";
            sqlConnection =new MySqlConnection(connectionString);
            sqlCommand=new MySqlCommand(query,sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);

            cmb_team.DataSource= dtTeam;
            cmb_team.DisplayMember= "team_name";
        }

        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pilih=cmb_team.Text;
            dtPlayer = new DataTable();
            query = $"SELECT p.player_name as'player'\r\nfrom player p,premier_league.team t \r\nwhere p.team_id=t.team_id and t.team_name='{pilih}' ;";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPlayer);

            cmb_player.DataSource = dtPlayer;
            cmb_player.DisplayMember = "player";
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            dtInfoPemain1 = new DataTable();
            string namaTeam = cmb_team.Text;
            string namaPlayer=cmb_player.Text;
            query = $"SELECT p.player_name,t.team_name,if(p.playing_pos='G','GoalKeeper',if(p.playing_pos='M','MidFielder',if(p.playing_pos='D','Defender','Forward')))as'Position',n.nation\r\nFROM player p,nationality n, team t\r\nWHERE p.team_id=t.team_id AND p.player_name='{namaPlayer}' AND t.team_name ='{namaTeam}' AND n.nationality_id=p.nationality_id";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtInfoPemain1);

            label_name.Text = dtInfoPemain1.Rows[0][0].ToString();
            label_team.Text= dtInfoPemain1.Rows[0][1].ToString();
            label_position.Text= dtInfoPemain1.Rows[0][2].ToString();
            label_nation.Text= dtInfoPemain1.Rows[0][3].ToString();

            idPemain(namaPlayer);
            dtInfoPemain2 = new DataTable();
            string _idPemain = dtidPemain.Rows[0][0].ToString();
            query = $"SELECT d.type FROM dmatch d WHERE d.player_id='{_idPemain}';";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtInfoPemain2);
            //MessageBox.Show(_idPemain+" "+ dtInfoPemain2.Rows.Count);
            int cy = 0, cr = 0, go = 0,pm=0 ;
            
            for(int i=0;i<dtInfoPemain2.Rows.Count;i++)
            {
                if (dtInfoPemain2.Rows[i][0].ToString()=="CY")
                    cy++;
                else if(dtInfoPemain2.Rows[i][0].ToString() == "CR")
                    cr++;
                else if (dtInfoPemain2.Rows[i][0].ToString() == "GO")
                    go++;
                else if (dtInfoPemain2.Rows[i][0].ToString() == "PM")
                    pm++;
            }
            label_yellow.Text = cy.ToString();
            label_red.Text=cr.ToString();
            label_goal.Text= go.ToString();
            label_penalty.Text= pm.ToString();
        }
    }
}
