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
    public partial class MovieDetails : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password = tiger; ";
        OracleConnection conn ;

        public MovieDetails()
        {
            InitializeComponent();
           
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        //private void button1_Click(object sender, EventArgs e)
        //{


        //    conn = new OracleConnection(ordb);
        //    conn.Open();

        //    OracleCommand cmd1 = new OracleCommand();

        //    cmd1.Connection = conn;
        //    cmd1.CommandText = "select DESCRIPTION,RELEASEYEAR from MOVIES where MOVIES.ORIGINALTITLE =:title";

        //    cmd1.CommandType = CommandType.Text;
        //    cmd1.Parameters.Add("title", Search.Text);


        //    OracleDataReader dr1 = cmd1.ExecuteReader();
        //    if (dr1.Read())
        //    {
        //        MovieName.Text = Search.Text;
        //        label2.Text = dr1[0].ToString();
        //        label9.Text = dr1[1].ToString();
        //        //label10.Text = dr1[2].ToString();
        //    }
        //    else
        //    {
        //        MovieName.Text = "NOT FOUND!!!!!!";
        //    }
        //    ///////REQUIREMENT 3

        //    OracleCommand cmd3 = new OracleCommand();
        //    cmd3.Connection = conn;
        //    cmd3.CommandText = "GETRATING";
        //    cmd3.CommandType = CommandType.StoredProcedure;
        //    cmd3.Parameters.Add("title", Search.Text);
        //    cmd3.Parameters.Add("Rating", OracleDbType.Int32 , ParameterDirection.Output);
           
        //    cmd3.ExecuteNonQuery();
          
        //    try
        //    {
        //        label10.Visible = true;
        //        label10.Text =Convert.ToString(cmd3.Parameters["Rating"].Value.ToString());
        //    }
        //    catch
        //    {
        //        label10.Text = "Rating not available";


        //    }



        //    ///////REQUIREMENT 4
        //    OracleCommand cmd4 = new OracleCommand();
        //    cmd4.Connection = conn;
        //    cmd4.CommandText = "GETDETAILS";
        //    cmd4.CommandType = CommandType.StoredProcedure;
        //    cmd4.Parameters.Add("title", Search.Text);
        //    cmd4.Parameters.Add("genre", OracleDbType.RefCursor,ParameterDirection.Output);

        //    OracleDataReader dr4 = cmd4.ExecuteReader();
        //    if (dr4.Read())
        //    {
        //        MovieName.Text = Search.Text;
        //        label7.Text = dr4[0].ToString();
               
        //    }
        //    else
        //    {
        //        MovieName.Text = "NOT FOUND!!!!!!";
        //    }
        //}
        //}

        private void button2_Click(object sender, EventArgs e)
        {


            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd1 = new OracleCommand();

            cmd1.Connection = conn;
            cmd1.CommandText = "select DESCRIPTION,RELEASEYEAR from MOVIES where MOVIES.ORIGINALTITLE =:title";

            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("title", Search.Text);


            OracleDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                MovieName.Visible = true;
                label2.Visible = true;
                label9.Visible=true;
                MovieName.Text = Search.Text;
                label2.Text = dr1[0].ToString();
                label9.Text = dr1[1].ToString();
                
            }
            else
            {
                MovieName.Visible = true;
                MovieName.Text = "NOT FOUND!!!!!!";
            }


            ///////REQUIREMENT 3
            //char c = Encoding.GetEncoding(9733);
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "GETRATE";
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("title", Search.Text);
            cmd3.Parameters.Add("Rating", OracleDbType.Decimal, ParameterDirection.Output);

            cmd3.ExecuteNonQuery();

            try
            {
                label10.Visible = true;
                label10.Text = Convert.ToString(cmd3.Parameters["Rating"].Value.ToString());
                //label10.Text.Append("U + 2605");
            }
            catch
            {
                label10.Visible = true;
                label10.Text = "Rating not available";


            }



            ///////REQUIREMENT 4
            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = conn;
            cmd4.CommandText = "GETDETAILS";
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Parameters.Add("title", Search.Text);
            cmd4.Parameters.Add("genre", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                MovieName.Visible = true;
                label7.Visible = true;
                MovieName.Text = Search.Text;
                label7.Text = dr4[0].ToString();

            }
            else
            {
                MovieName.Visible = true;
                MovieName.Text = "NOT FOUND!!!!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(ordb);
            conn.Open();
            ////////REQIUREMENT 2
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "insert into MActors values (:id,:name)";
            
            cmd2.Parameters.Add("id", A_ID.Text);
            cmd2.Parameters.Add("name", A_name.Text);

            int ins = cmd2.ExecuteNonQuery();
            if (ins != -1)
            {
                MessageBox.Show("New Actor is Added");
            }


        }

        private void MovieDetails_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
    

