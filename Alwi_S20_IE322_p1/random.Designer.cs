namespace Alwi_S20_IE322_p1
{
    partial class random
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
            this.btn_GRC = new System.Windows.Forms.Button();
            this.lab_rgh = new System.Windows.Forms.Label();
            this.Btn_Numb = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GRC
            // 
            this.btn_GRC.Location = new System.Drawing.Point(246, 43);
            this.btn_GRC.Name = "btn_GRC";
            this.btn_GRC.Size = new System.Drawing.Size(325, 72);
            this.btn_GRC.TabIndex = 0;
            this.btn_GRC.Text = "Generate random color";
            this.btn_GRC.UseVisualStyleBackColor = true;
            this.btn_GRC.Click += new System.EventHandler(this.btn_GRC_Click);
            // 
            // lab_rgh
            // 
            this.lab_rgh.AutoSize = true;
            this.lab_rgh.Location = new System.Drawing.Point(382, 118);
            this.lab_rgh.Name = "lab_rgh";
            this.lab_rgh.Size = new System.Drawing.Size(39, 17);
            this.lab_rgh.TabIndex = 1;
            this.lab_rgh.Text = "r-g-b";
            this.lab_rgh.Click += new System.EventHandler(this.lab__Click);
            // 
            // Btn_Numb
            // 
            this.Btn_Numb.Location = new System.Drawing.Point(151, 283);
            this.Btn_Numb.Name = "Btn_Numb";
            this.Btn_Numb.Size = new System.Drawing.Size(142, 55);
            this.Btn_Numb.TabIndex = 2;
            this.Btn_Numb.Text = "Random Number";
            this.Btn_Numb.UseVisualStyleBackColor = true;
            this.Btn_Numb.Click += new System.EventHandler(this.Btn_Numb_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(700, 415);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(75, 23);
            this.Btn_back.TabIndex = 3;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_Numb);
            this.Controls.Add(this.lab_rgh);
            this.Controls.Add(this.btn_GRC);
            this.Name = "random";
            this.Text = "random";
            this.Load += new System.EventHandler(this.random_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GRC;
        private System.Windows.Forms.Label lab_rgh;
        private System.Windows.Forms.Button Btn_Numb;
        private System.Windows.Forms.Button Btn_back;
    }
}