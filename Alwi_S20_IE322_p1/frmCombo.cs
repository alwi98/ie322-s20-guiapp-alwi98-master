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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            // adding items to the combobox
            cmbdays.Items.Add("sunday");
            cmbdays.Items.Add("monday");
            cmbdays.Items.Add("tuesday");
            cmbdays.Items.Add("wednesday");
            cmbdays.Items.Add("thursday");
            cmbdays.Items.Add("friday");
            cmbdays.Items.Add("saturday");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cmbdays.Items.Count >= 2)
            {
                cmbdays.Items.RemoveAt(cmbdays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Can't remove the last item");
            }

        }

        private void cmbdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbdays.Text);
        }

        private void btnSSM1_Click(object sender, EventArgs e)
        {// USING METHOD 1
            MessageBox.Show(cmbdays.Text);
        }

        private void btnSSM2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRBN_Click(object sender, EventArgs e)
        {
            cmbdays.Items.Remove("friday");
        }

        private void btnRBI_Click(object sender, EventArgs e)
        {
            cmbdays.Items.RemoveAt(1);
        }

        private void btnRLI1_Click(object sender, EventArgs e)
        {
            if (cmbdays.Items.Count >= 1)
            {
                cmbdays.Items.RemoveAt(cmbdays.Items.Count - 1);  
            }
            else
            {
                MessageBox.Show("Can't remove the last item");
            }
        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
