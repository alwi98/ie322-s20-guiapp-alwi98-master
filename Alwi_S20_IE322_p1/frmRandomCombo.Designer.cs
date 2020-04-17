namespace Alwi_S20_IE322_p1
{
    partial class frmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_GR500 = new System.Windows.Forms.RadioButton();
            this.rdo_LT500 = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_generate = new System.Windows.Forms.Button();
            this.cmb_LT500 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset2 = new System.Windows.Forms.Button();
            this.rdo_GT50 = new System.Windows.Forms.RadioButton();
            this.rdo_LT50 = new System.Windows.Forms.RadioButton();
            this.btn_generate2 = new System.Windows.Forms.Button();
            this.Cmb_LT50 = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_GR500);
            this.groupBox1.Controls.Add(this.rdo_LT500);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_generate);
            this.groupBox1.Controls.Add(this.cmb_LT500);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03_AAF19";
            // 
            // rdo_GR500
            // 
            this.rdo_GR500.AutoSize = true;
            this.rdo_GR500.Location = new System.Drawing.Point(266, 129);
            this.rdo_GR500.Name = "rdo_GR500";
            this.rdo_GR500.Size = new System.Drawing.Size(101, 21);
            this.rdo_GR500.TabIndex = 4;
            this.rdo_GR500.TabStop = true;
            this.rdo_GR500.Text = "greater 500";
            this.rdo_GR500.UseVisualStyleBackColor = true;
            // 
            // rdo_LT500
            // 
            this.rdo_LT500.AutoSize = true;
            this.rdo_LT500.Location = new System.Drawing.Point(266, 98);
            this.rdo_LT500.Name = "rdo_LT500";
            this.rdo_LT500.Size = new System.Drawing.Size(110, 21);
            this.rdo_LT500.TabIndex = 3;
            this.rdo_LT500.TabStop = true;
            this.rdo_LT500.Text = "less than 500";
            this.rdo_LT500.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(266, 169);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(266, 52);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // cmb_LT500
            // 
            this.cmb_LT500.FormattingEnabled = true;
            this.cmb_LT500.Location = new System.Drawing.Point(17, 52);
            this.cmb_LT500.Name = "cmb_LT500";
            this.cmb_LT500.Size = new System.Drawing.Size(121, 24);
            this.cmb_LT500.TabIndex = 0;
            this.cmb_LT500.SelectedIndexChanged += new System.EventHandler(this.cmb_LT500_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_reset2);
            this.groupBox2.Controls.Add(this.rdo_GT50);
            this.groupBox2.Controls.Add(this.rdo_LT50);
            this.groupBox2.Controls.Add(this.btn_generate2);
            this.groupBox2.Controls.Add(this.Cmb_LT50);
            this.groupBox2.Location = new System.Drawing.Point(494, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03_EAF19";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "count:";
            // 
            // btn_reset2
            // 
            this.btn_reset2.Location = new System.Drawing.Point(173, 136);
            this.btn_reset2.Name = "btn_reset2";
            this.btn_reset2.Size = new System.Drawing.Size(75, 23);
            this.btn_reset2.TabIndex = 4;
            this.btn_reset2.Text = "reset";
            this.btn_reset2.UseVisualStyleBackColor = true;
            // 
            // rdo_GT50
            // 
            this.rdo_GT50.AutoSize = true;
            this.rdo_GT50.Location = new System.Drawing.Point(173, 109);
            this.rdo_GT50.Name = "rdo_GT50";
            this.rdo_GT50.Size = new System.Drawing.Size(93, 21);
            this.rdo_GT50.TabIndex = 3;
            this.rdo_GT50.TabStop = true;
            this.rdo_GT50.Text = "greater 50";
            this.rdo_GT50.UseVisualStyleBackColor = true;
            // 
            // rdo_LT50
            // 
            this.rdo_LT50.AutoSize = true;
            this.rdo_LT50.Location = new System.Drawing.Point(173, 78);
            this.rdo_LT50.Name = "rdo_LT50";
            this.rdo_LT50.Size = new System.Drawing.Size(102, 21);
            this.rdo_LT50.TabIndex = 2;
            this.rdo_LT50.TabStop = true;
            this.rdo_LT50.Text = "less than 50";
            this.rdo_LT50.UseVisualStyleBackColor = true;
            // 
            // btn_generate2
            // 
            this.btn_generate2.Location = new System.Drawing.Point(173, 42);
            this.btn_generate2.Name = "btn_generate2";
            this.btn_generate2.Size = new System.Drawing.Size(75, 23);
            this.btn_generate2.TabIndex = 1;
            this.btn_generate2.Text = "generate ";
            this.btn_generate2.UseVisualStyleBackColor = true;
            // 
            // Cmb_LT50
            // 
            this.Cmb_LT50.FormattingEnabled = true;
            this.Cmb_LT50.Location = new System.Drawing.Point(0, 41);
            this.Cmb_LT50.Name = "Cmb_LT50";
            this.Cmb_LT50.Size = new System.Drawing.Size(121, 24);
            this.Cmb_LT50.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(666, 399);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_GR500;
        private System.Windows.Forms.RadioButton rdo_LT500;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.ComboBox cmb_LT500;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset2;
        private System.Windows.Forms.RadioButton rdo_GT50;
        private System.Windows.Forms.RadioButton rdo_LT50;
        private System.Windows.Forms.Button btn_generate2;
        private System.Windows.Forms.ComboBox Cmb_LT50;
        private System.Windows.Forms.Button btn_back;
    }
}