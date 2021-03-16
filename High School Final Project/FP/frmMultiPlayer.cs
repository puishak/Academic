using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class frmMultiPlayer : Form
    {
        public frmMultiPlayer()
        {
            InitializeComponent();
        }

        public void Hover(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = SystemColors.ControlDark;
        }

        public void Leave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = SystemColors.ControlDarkDark;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
