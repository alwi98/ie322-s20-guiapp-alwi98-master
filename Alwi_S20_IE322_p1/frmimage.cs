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
    public partial class frmimage : Form
    {
        public frmimage()
        {
            InitializeComponent();
        }

        private void btn_loadimage_Click(object sender, EventArgs e)
        {
            picTry.Image = Image.FromFile("C:\\Users\\user\\Desktop\\minitab\\111.PNG");

        }

        private void frmimage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
