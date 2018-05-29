namespace WindowsFormsApplication1
{
    partial class formHeadsTails
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
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picTails = new System.Windows.Forms.PictureBox();
            this.picHeads = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHeads
            // 
            this.btnHeads.AccessibleName = "";
            this.btnHeads.Location = new System.Drawing.Point(22, 180);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(75, 34);
            this.btnHeads.TabIndex = 0;
            this.btnHeads.Tag = "";
            this.btnHeads.Text = "Show &Heads";
            this.btnHeads.UseVisualStyleBackColor = true;
            this.btnHeads.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTails
            // 
            this.btnTails.Location = new System.Drawing.Point(120, 180);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(68, 34);
            this.btnTails.TabIndex = 1;
            this.btnTails.Text = "Show &Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "%Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // picTails
            // 
            this.picTails.Image = global::WindowsFormsApplication1.Properties.Resources.us_quarter_back;
            this.picTails.Location = new System.Drawing.Point(202, 47);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(79, 83);
            this.picTails.TabIndex = 4;
            this.picTails.TabStop = false;
            this.picTails.Visible = false;
            this.picTails.Click += new System.EventHandler(this.picTails_Click);
            // 
            // picHeads
            // 
            this.picHeads.Image = global::WindowsFormsApplication1.Properties.Resources.us_quarter_front1;
            this.picHeads.Location = new System.Drawing.Point(22, 47);
            this.picHeads.Name = "picHeads";
            this.picHeads.Size = new System.Drawing.Size(82, 83);
            this.picHeads.TabIndex = 3;
            this.picHeads.TabStop = false;
            this.picHeads.Visible = false;
            this.picHeads.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // formHeadsTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 261);
            this.Controls.Add(this.picTails);
            this.Controls.Add(this.picHeads);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Name = "formHeadsTails";
            this.Text = "HeadsOrTails";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHeads;
        private System.Windows.Forms.PictureBox picTails;
    }
}

