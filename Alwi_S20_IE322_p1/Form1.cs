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
    public partial class frmMain : Form
    {
        string username = "Alwi";
        string myPassword = "1234";
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BtnABC.Enabled = false;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnCB_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void BtnSA_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {


                while (attempt <= MaxAttempts)
                {
                    if (TxtUser.Text != username)
                    {
                        //username is incorrect
                        MessageBox.Show("invailed username," + (MaxAttempts - attempt) + "attempts remaning");
                        attempt++;
                        return;
                    }

                    else

                    { //username is correct - so check password
                        if (TxtPW.Text != myPassword)
                        { //incorrect password
                            attempt++;
                            MessageBox.Show("incorrect password," + (MaxAttempts - attempt) + "attempts remaning");
                            return;
                        }
                        else
                        { // both are correct
                            attempt = 1; //reset the number of attempts
                            loggedIn = true;
                            MessageBox.Show("Hi " + username + ", your login successful");
                            BtnLogin.Text = "Logout";
                            //this width = 1600;
                            break; //
                        }

                    }
                }
            }
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnRC_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPB_Click(object sender, EventArgs e)
        {
            frmimage frm = new frmimage();
            frm.ShowDialog();
        }

        private void BtnRan_Click(object sender, EventArgs e)
        {
            random frm = new random();
                frm.ShowDialog();
           
        }
    }
} 
