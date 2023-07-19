/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDb
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
           
            InitializeComponent();

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Search_TextChanged(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Search.Text == "Search IMDb")
            {
                Search.Text = "";
                Search.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesReport_Click(object sender, EventArgs e)
        {
            geners_report_form gen = new geners_report_form();
            gen.Show();

        }

        private void DirectorsReport_Click(object sender, EventArgs e)
        {
           
            director_form dir = new director_form();
            dir.Show();
    

        }
    }
}*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDb
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;
        public Button[] b = new Button[10];
        public static String[] arr = new string[10];
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
            b[0] = AddFurious7;
            b[1] = AddInsideOut;
            b[2] = AddInsurgent;
            b[3] = AddJurassicWorld;
            b[4] = AddMadMax;
            b[5] = AddMinions;
            b[6] = AddStarWars;
            b[7] = AddTerminator;
            b[8] = AddTheMartian;
            b[9] = AddTheRevenant;
        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Search.Text == "Search IMDb")
            {
                Search.Text = "";
                Search.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Watchlist_Click(object sender, EventArgs e)
        {
            WatchList watchlist = new WatchList();
            watchlist.Show();


        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void AddMadMax_Click(object sender, EventArgs e)
        {
            AddMadMax.Text = "Added";
            arr[0] = "MadMax";
        }

        private void Furious7Movie_Click(object sender, EventArgs e)
        {

        }

        private void AddJurassicWorld_Click(object sender, EventArgs e)
        {
            AddJurassicWorld.Text = "Added";
            arr[1] = "JurassicWorld";
        }

        private void AddFurious7_Click(object sender, EventArgs e)
        {
            AddFurious7.Text = "Added";
            arr[2] = "Furious7";
        }

        private void AddTheMartian_Click(object sender, EventArgs e)
        {
            AddTheMartian.Text = "Added";
            arr[3] = "TheMartian";
        }

        private void AddStarWars_Click(object sender, EventArgs e)
        {
            AddStarWars.Text = "Added";
            arr[4] = "StarWars";
        }

        private void AddTheRevenant_Click(object sender, EventArgs e)
        {
            AddTheRevenant.Text = "Added";
            arr[5] = "TheRevenant";
        }

        private void AddInsideOut_Click(object sender, EventArgs e)
        {
            AddInsideOut.Text = "Added";
            arr[6] = "InsideOut";
        }

        private void AddTerminator_Click(object sender, EventArgs e)
        {
            AddTerminator.Text = "Added";
            arr[7] = "Terminator";
        }

        private void AddInsurgent_Click(object sender, EventArgs e)
        {
            AddInsurgent.Text = "Added";
            arr[8] = "Insurgent";
        }

        private void AddMinions_Click(object sender, EventArgs e)
        {
            AddMinions.Text = "Added";
            arr[9] = "Minions";
        }

        private void MadMaxMovie_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieDetails md = new MovieDetails();
            md.Show();
        }

        private void CategoriesReport_Click(object sender, EventArgs e)
        {
            geners_report_form gen = new geners_report_form();
            gen.Show();
        }

        private void DirectorsReport_Click(object sender, EventArgs e)
        {
            director_form dir = new director_form();
            dir.Show();
        }
    }
}

