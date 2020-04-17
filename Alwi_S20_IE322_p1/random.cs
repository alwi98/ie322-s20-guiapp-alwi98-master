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
    public partial class random : Form
    {
        Random y = new Random();
        public random()
        {
            InitializeComponent();
        }

        private void random_Load(object sender, EventArgs e)
        {
           Btn_Numb.Text = Convert.ToString(y.Next(1, 10));
        }

        private void lab__Click(object sender, EventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void btn_GRC_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);
            lab_rgh.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
           btn_GRC.BackColor = Color.FromArgb(r, g, b);
            this.BackColor = Color.FromArgb(255 - r, 255 - g, 255 - b);
        }

        private void Btn_Numb_Click(object sender, EventArgs e)
        {
                 
        }
    }
}
