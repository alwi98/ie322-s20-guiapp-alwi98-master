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
    public partial class frmRandomCombo : Form
    {
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
           
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                cmb_LT500.Items.Add(r.Next(100, 999));
            }

        }

        private void cmb_LT500_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cmb_LT500.ResetText();
            cmb_LT500.Items.Clear();
        }
    }
}
