using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace IMDb
{
    public partial class WatchList : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public WatchList()
        {
            InitializeComponent();
            hide();
            for (int i = 0; i < MainForm.arr.Length; i++)
            {
                if (MainForm.arr[i] == "MadMax")
                {
                    flowLayoutPanel6.Show();
                }
                else if (MainForm.arr[i] == "Furious7")
                {
                    flowLayoutPanel2.Show();
                }
                if (MainForm.arr[i] == "JurassicWorld")
                {
                    flowLayoutPanel5.Show();
                }
                if (MainForm.arr[i] == "TheMartian")
                {
                    flowLayoutPanel11.Show();
                }
                if (MainForm.arr[i] == "StarWars")
                {
                    flowLayoutPanel8.Show();
                }
                if (MainForm.arr[i] == "TheRevenant")
                {
                    flowLayoutPanel10.Show();
                }
                if (MainForm.arr[i] == "InsideOut")
                {
                    flowLayoutPanel3.Show();
                }
                if (MainForm.arr[i] == "Terminator")
                {
                    flowLayoutPanel9.Show();
                }
                if (MainForm.arr[i] == "Insurgent")
                {
                    flowLayoutPanel4.Show();
                }
                if (MainForm.arr[i] == "Minions")
                {
                    flowLayoutPanel7.Show();
                }
            }
            

        }
        private void hide()
        {
            flowLayoutPanel2.Hide();
            flowLayoutPanel3.Hide();
            flowLayoutPanel4.Hide();
            flowLayoutPanel5.Hide();
            flowLayoutPanel6.Hide();
            flowLayoutPanel7.Hide();
            flowLayoutPanel8.Hide();
            flowLayoutPanel9.Hide();
            flowLayoutPanel10.Hide();
            flowLayoutPanel11.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void WatchList_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < MainForm.arr.Length; x++)
            {
                MainForm.arr[x] = "";
            }
            hide();
            for (int y = 0;y< MainForm.Instance.b.Length; y++)
            {
                MainForm.Instance.b[y].Text = "+ Watchlist";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {           

        }
        private void button42_Click(object sender, EventArgs e)
        {
            string constr = " User Id=scott; Password=tiger; Data Source=orcl;";
            string cmdstr = @"select IMDB_ID,Description,ReleaseYear,VoteAverage
                               from Movies m
                                where m.OriginalTitle=:filmname";

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("filmname", comboBox1.SelectedItem.ToString());
             ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "+ Watchlist";
            MainForm.arr[2] = "";
            flowLayoutPanel2.Hide(); 

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "+ Watchlist";
            MainForm.arr[6] ="";
            flowLayoutPanel3.Hide();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = "+ Watchlist";
            MainForm.arr[0] = "";
            flowLayoutPanel6.Hide();
        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "+ Watchlist";
            MainForm.arr[1] = "";
            flowLayoutPanel5.Hide();
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Text = "+ Watchlist";
           // MainForm.AddTheMartian.Text = "Added";
            MainForm.arr[3] = "";
            flowLayoutPanel11.Hide();
        }

        private void flowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Text = "+ Watchlist";
            MainForm.arr[4] = "";
            flowLayoutPanel8.Hide();
        }

        private void flowLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Text = "+ Watchlist";
            MainForm.arr[9] = "";
            flowLayoutPanel7.Hide();
        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "+ Watchlist";
            MainForm.arr[8] = "";
            flowLayoutPanel4.Hide();
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void button44_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("UPDATED");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Text = "Added";
            MainForm.arr[5] = "";
            flowLayoutPanel10.Hide();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Text = "+ Watchlist";
            MainForm.arr[7] = "";
            flowLayoutPanel9.Hide();

        }

        private void flowLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
