using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace TakeHome_W8
{
    public partial class ShowMatch : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string query = "";
        DataTable dtTeam = new DataTable();
        DataTable dtTanggal= new DataTable();
        DataTable dtHome = new DataTable();
        DataTable dtAway = new DataTable();
        DataTable dtMatch= new DataTable();
        DataTable dtDetail= new DataTable();
        string pilih = "";
        public ShowMatch()
        {
            InitializeComponent();
        }
        private void updateLabel()
        {
            cmb_match.ValueMember = "t1";
            if (cmb_match.SelectedValue != null)
                label_home.Text = cmb_match.SelectedValue.ToString();

            cmb_match.ValueMember = "t2";
            if (cmb_match.SelectedValue != null)
                label_away.Text = cmb_match.SelectedValue.ToString();
            cmb_match.ValueMember = "ID";
        }
        private void ShowMatch_Load(object sender, EventArgs e)
        {
            query = "SELECT team_name FROM premier_league.team;";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);

            cmb_team.DataSource = dtTeam;
            cmb_team.DisplayMember = "team_name";
        }

        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtTanggal=new DataTable();
            pilih = cmb_team.Text;
            query = $"SELECT m.match_date as 'tanggal', t1.team_name as't1',t2.team_name as't2',m.match_id as'ID'\r\nFROM team t1,team t2, premier_league.match m\r\nWHERE (t1.team_name='{pilih}' or t2.team_name='{pilih}') AND t1.team_id=m.team_home AND t2.team_id=m.team_away;";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTanggal);

            cmb_match.DataSource= dtTanggal;
            cmb_match.DisplayMember = "tanggal";
            updateLabel();
        }

        private void cmb_match_SelectedIndexChanged(object sender, EventArgs e)
        { 
            dtMatch = new DataTable();
            query = $"select t1.team_name as 't1', t2.team_name as 't2' \r\nfrom premier_league.match m, team t1, team t2 \r\nwhere m.team_home = t1.team_id and m.team_away = t2.team_id and m.match_id = '{cmb_match.SelectedValue.ToString()}';";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMatch);

            updateLabel();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            dtHome= new DataTable();
            query = $"SELECT t.team_name, p.player_name,if(p.playing_pos='G','GoalKeeper',if(p.playing_pos='M','MidFielder',if(p.playing_pos='D','Defender','Forward')))as'Position'\r\nFROM player p, team t\r\nWHERE p.team_id=t.team_id AND t.team_name='{label_home.Text}';";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHome);
            dgv_home.DataSource= dtHome;

            dtAway = new DataTable();
            query = $"SELECT t.team_name, p.player_name,if(p.playing_pos='G','GoalKeeper',if(p.playing_pos='M','MidFielder',if(p.playing_pos='D','Defender','Forward')))as'Position'\r\nFROM player p, team t\r\nWHERE p.team_id=t.team_id AND t.team_name='{label_away.Text}';";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtAway);
            dgv_away.DataSource = dtAway;

            dtDetail= new DataTable();
            query = $"SELECT d.minute as'minute',t.team_name as'team name',p.player_name as'player name',if(d.type='CY','Yellow Card',if(d.type='CR','Red Card',if(d.type='GO','Goal',if(d.type='GP','Goal Penalty',if(d.type='GW','Own GOal','Penalty Miss'))))) as 'type'\r\nFROM dmatch d,team t,player p\r\nWHERE d.team_id=t.team_id AND d.player_id=p.player_id AND d.match_id='{cmb_match.SelectedValue.ToString()}';";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtDetail);
            dgv_detail.DataSource = dtDetail;
        }
    }
}
