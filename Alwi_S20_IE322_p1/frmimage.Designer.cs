namespace Alwi_S20_IE322_p1
{
    partial class frmimage
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
            this.btn_loadimage = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loadimage
            // 
            this.btn_loadimage.Location = new System.Drawing.Point(50, 25);
            this.btn_loadimage.Name = "btn_loadimage";
            this.btn_loadimage.Size = new System.Drawing.Size(151, 39);
            this.btn_loadimage.TabIndex = 0;
            this.btn_loadimage.Text = "Load image";
            this.btn_loadimage.UseVisualStyleBackColor = true;
            this.btn_loadimage.Click += new System.EventHandler(this.btn_loadimage_Click);
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(50, 86);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(705, 303);
            this.picTry.TabIndex = 1;
            this.picTry.TabStop = false;
            // 
            // frmimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picTry);
            this.Controls.Add(this.btn_loadimage);
            this.Name = "frmimage";
            this.Text = "frmimage";
            this.Load += new System.EventHandler(this.frmimage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loadimage;
        private System.Windows.Forms.PictureBox picTry;
    }
}