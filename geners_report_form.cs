using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace IMDb
{
    public partial class geners_report_form : Form
    {
        CrystalReport4 CR4;
        
        public geners_report_form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void geners_report_form_Load(object sender, EventArgs e)
        {
            CR4 = new CrystalReport4();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
