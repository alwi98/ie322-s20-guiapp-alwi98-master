namespace Alwi_S20_IE322_p1
{
    partial class frmCombo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSSM1 = new System.Windows.Forms.Button();
            this.btnSSM2 = new System.Windows.Forms.Button();
            this.btnRBI = new System.Windows.Forms.Button();
            this.btnRBN = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRLI1 = new System.Windows.Forms.Button();
            this.btnR2LI = new System.Windows.Forms.Button();
            this.cmbdays = new System.Windows.Forms.ComboBox();
            this.Btn_table1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSSM1
            // 
            this.btnSSM1.Location = new System.Drawing.Point(12, 61);
            this.btnSSM1.Name = "btnSSM1";
            this.btnSSM1.Size = new System.Drawing.Size(207, 23);
            this.btnSSM1.TabIndex = 0;
            this.btnSSM1.Text = "Show selected method 1";
            this.btnSSM1.UseVisualStyleBackColor = true;
            this.btnSSM1.Click += new System.EventHandler(this.btnSSM1_Click);
            // 
            // btnSSM2
            // 
            this.btnSSM2.Location = new System.Drawing.Point(271, 60);
            this.btnSSM2.Name = "btnSSM2";
            this.btnSSM2.Size = new System.Drawing.Size(221, 23);
            this.btnSSM2.TabIndex = 1;
            this.btnSSM2.Text = "Show Selected Method 2";
            this.btnSSM2.UseVisualStyleBackColor = true;
            this.btnSSM2.Click += new System.EventHandler(this.btnSSM2_Click);
            // 
            // btnRBI
            // 
            this.btnRBI.Location = new System.Drawing.Point(81, 324);
            this.btnRBI.Name = "btnRBI";
            this.btnRBI.Size = new System.Drawing.Size(75, 58);
            this.btnRBI.TabIndex = 3;
            this.btnRBI.Text = "Removed by Index";
            this.btnRBI.UseVisualStyleBackColor = true;
            this.btnRBI.Click += new System.EventHandler(this.btnRBI_Click);
            // 
            // btnRBN
            // 
            this.btnRBN.Location = new System.Drawing.Point(253, 323);
            this.btnRBN.Name = "btnRBN";
            this.btnRBN.Size = new System.Drawing.Size(75, 59);
            this.btnRBN.TabIndex = 4;
            this.btnRBN.Text = "Remove by Name";
            this.btnRBN.UseVisualStyleBackColor = true;
            this.btnRBN.Click += new System.EventHandler(this.btnRBN_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(701, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRLI1
            // 
            this.btnRLI1.Location = new System.Drawing.Point(613, 60);
            this.btnRLI1.Name = "btnRLI1";
            this.btnRLI1.Size = new System.Drawing.Size(120, 53);
            this.btnRLI1.TabIndex = 6;
            this.btnRLI1.Text = "Remove last item";
            this.btnRLI1.UseVisualStyleBackColor = true;
            this.btnRLI1.Click += new System.EventHandler(this.btnRLI1_Click);
            // 
            // btnR2LI
            // 
            this.btnR2LI.Location = new System.Drawing.Point(613, 197);
            this.btnR2LI.Name = "btnR2LI";
            this.btnR2LI.Size = new System.Drawing.Size(120, 53);
            this.btnR2LI.TabIndex = 7;
            this.btnR2LI.Text = "Remove 2nd last item";
            this.btnR2LI.UseVisualStyleBackColor = true;
            this.btnR2LI.Click += new System.EventHandler(this.button8_Click);
            // 
            // cmbdays
            // 
            this.cmbdays.FormattingEnabled = true;
            this.cmbdays.Items.AddRange(new object[] {
            "Sunday",
            "monday",
            "tusday",
            "wednsday",
            "thersday",
            "friday",
            "saturday"});
            this.cmbdays.Location = new System.Drawing.Point(225, 172);
            this.cmbdays.Name = "cmbdays";
            this.cmbdays.Size = new System.Drawing.Size(121, 24);
            this.cmbdays.TabIndex = 8;
            this.cmbdays.SelectedIndexChanged += new System.EventHandler(this.cmbdays_SelectedIndexChanged);
            // 
            // Btn_table1
            // 
            this.Btn_table1.Location = new System.Drawing.Point(70, 172);
            this.Btn_table1.Name = "Btn_table1";
            this.Btn_table1.Size = new System.Drawing.Size(75, 23);
            this.Btn_table1.TabIndex = 10;
            this.Btn_table1.Text = "Table1";
            this.Btn_table1.UseVisualStyleBackColor = true;
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_table1);
            this.Controls.Add(this.cmbdays);
            this.Controls.Add(this.btnR2LI);
            this.Controls.Add(this.btnRLI1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRBN);
            this.Controls.Add(this.btnRBI);
            this.Controls.Add(this.btnSSM2);
            this.Controls.Add(this.btnSSM1);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSSM1;
        private System.Windows.Forms.Button btnSSM2;
        private System.Windows.Forms.Button btnRBI;
        private System.Windows.Forms.Button btnRBN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRLI1;
        private System.Windows.Forms.Button btnR2LI;
        private System.Windows.Forms.ComboBox cmbdays;
        private System.Windows.Forms.Button Btn_table1;
    }
}