using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasolineBlending
{
    public partial class GasolineBlending : Form
    {
        public GasolineBlending()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RON obj = new RON();
            Contentpanel.Controls.Clear();
            Contentpanel.Controls.Add(obj);
        }

        private void btnRVP_Click(object sender, EventArgs e)
        {
            RVP obj = new RVP();
            Contentpanel.Controls.Clear();
            Contentpanel.Controls.Add(obj);
        }

        private void btnSG_Click(object sender, EventArgs e)
        {
            SG obj = new SG();
            Contentpanel.Controls.Clear();
            Contentpanel.Controls.Add(obj);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Form1 obj = new Form1();
            GasolineBlending Check = new GasolineBlending();
            ActiveForm.Hide();
            Check.Show();
            
           
            
        }

       
    }
}
