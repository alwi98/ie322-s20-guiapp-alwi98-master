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
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
          
        {
            string msg = "";
            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;           
            }
            if (chkDount.Checked == true)
            {
                msg = msg + "   " + chkDount.Text;
            }
            if (chkBrownie.Checked == true)
            {
                msg = msg + "   " + chkBrownie.Text;

            } // now display the order
            if (msg.Length == 0)

            {
                msg = "Nothing selected";
            }
            MessageBox.Show(msg + " ordered ");
            // another way 
            // if (msg.length > 0)
            //{
            //  messagebox.show(msg + "ordered" );
            //}
            //else    // lingth is zero
            //{
            //messagebox.show("nothing ordered)";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
