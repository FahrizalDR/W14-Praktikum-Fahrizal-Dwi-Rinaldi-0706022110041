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

namespace W14Praktikum
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable DTTeam = new DataTable();        
        DataTable DTTopScores = new DataTable();

        int PositionRightNow = 0;


        private void Team_Load(object sender, EventArgs e)
        {            
            /*sqlQuery = "SELECT CONCAT(p.player_name, ' ', sum(if (dm.`type` = 'GO' or dm.`type` = 'GP',1, 0)),'(',sum(if (dm.`type` = 'GP',1, 0)),')')  as 'Top Score' FROM player p, dmatch dm WHERE p.player_id = dm.player_id group by p.player_id order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(DTTopScores);  */          

            sqlQuery = "select t.team_id as `ID Tim`, t.team_name as `Nama Tim`, concat(m.manager_name,' ','(',n.nation,')'), concat(home_stadium,',',' ',city,' ','(',capacity,')') from team t, manager m, player p, nationality n where t.manager_id = m.manager_id AND m.nationality_id = n.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(DTTeam);
            TeamData(0);
        }

        public void TeamData(int position)
        {
            OutputTeamName.Text = DTTeam.Rows[position][1].ToString();
            OutputManager.Text = DTTeam.Rows[position][2].ToString();
            OutputStadium.Text = DTTeam.Rows[position][3].ToString();            

            PositionRightNow = position;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            TeamData(0);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (PositionRightNow > 0)
            {
                PositionRightNow--;
                TeamData(PositionRightNow);
            }
            else
            {
                MessageBox.Show("Data Ini Sudah Data Pertama");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (PositionRightNow < DTTeam.Rows.Count - 1)
            {
                PositionRightNow++;
                TeamData(PositionRightNow);
            }
            else
            {
                MessageBox.Show("Data Ini Sudah Data Terakhir");
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            TeamData(DTTeam.Rows.Count - 1);
        }
    }
}
