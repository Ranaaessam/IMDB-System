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
  
    public partial class director_form : Form
    {
        
        CrystalReport2 CR1;
        public director_form()
        {
            InitializeComponent();
        }

        private void director_form_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport2();
            
        }
    }
}
