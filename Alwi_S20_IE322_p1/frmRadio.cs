using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alwi_S20_IE322_p1
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoRed1_CheckedChanged(object sender, EventArgs e)
        {
           if (RdoRed1.Checked == true)
            RdoRed1.ForeColor = Color.FromArgb(255, 0, 0);
            //we can use      color = color.Fromname("green")
            else
                RdoRed1.ForeColor = Color.FromName("black");
        }

        private void RdoGreen1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen1.Checked == true)
            RdoGreen1.ForeColor = Color.FromName("green");
            else
                RdoGreen1.ForeColor = Color.FromName("black");
        }

        private void RdoBlue1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue1.Checked == true)
            RdoBlue1.ForeColor = Color.FromName("blue");
            else
                RdoBlue1.ForeColor = Color.FromName("black");
        }

        private void RdoYellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow1.Checked == true)
            RdoYellow1.ForeColor = Color.FromName("yellow");
            else
                RdoYellow1.ForeColor = Color.FromName("black");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoRed1.Checked = false;
            RdoGreen1.Checked = false;
            RdoBlue1.Checked = false;
            RdoYellow1.Checked = false;
            RdoRed2.Checked = false;
            RdoYellow.Checked = false;
            RdoBlue2.Checked = false;
            RdoGreen2.Checked = false;



            RdoRed1.ForeColor = Color.FromName("black");
            RdoGreen1.ForeColor = Color.FromName("black");
            RdoBlue1.ForeColor = Color.FromName("black");
            RdoYellow1.ForeColor = Color.FromName("black");
            RdoYellow.ForeColor = Color.FromName("black");
            RdoRed2.ForeColor = Color.FromName("black");
            RdoBlue2.ForeColor = Color.FromName("black");
            RdoGreen2.ForeColor = Color.FromName("black");


        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            
                RdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
            //we can use      color = color.Fromname("green")
            
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor = Color.FromName("green");

        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RdoBlue2.ForeColor = Color.FromName("blue");
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            RdoYellow.ForeColor = Color.FromName("yellow");
        }
    }
}
