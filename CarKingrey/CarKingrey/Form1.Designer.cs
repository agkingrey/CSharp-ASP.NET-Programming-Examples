namespace CarKingrey
{
    partial class Form1
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
            this.accelerateBtn = new System.Windows.Forms.Button();
            this.brakeBtn = new System.Windows.Forms.Button();
            this.speedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accelerateBtn
            // 
            this.accelerateBtn.Location = new System.Drawing.Point(33, 179);
            this.accelerateBtn.Name = "accelerateBtn";
            this.accelerateBtn.Size = new System.Drawing.Size(86, 23);
            this.accelerateBtn.TabIndex = 0;
            this.accelerateBtn.Text = "&ACCELERATE";
            this.accelerateBtn.UseVisualStyleBackColor = true;
            this.accelerateBtn.Click += new System.EventHandler(this.accelerateBtn_Click);
            // 
            // brakeBtn
            // 
            this.brakeBtn.Location = new System.Drawing.Point(167, 179);
            this.brakeBtn.Name = "brakeBtn";
            this.brakeBtn.Size = new System.Drawing.Size(75, 23);
            this.brakeBtn.TabIndex = 1;
            this.brakeBtn.Text = "&BRAKE";
            this.brakeBtn.UseVisualStyleBackColor = true;
            this.brakeBtn.Click += new System.EventHandler(this.brakeBtn_Click);
            // 
            // speedLbl
            // 
            this.speedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLbl.Location = new System.Drawing.Point(86, 43);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(100, 42);
            this.speedLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.speedLbl);
            this.Controls.Add(this.brakeBtn);
            this.Controls.Add(this.accelerateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accelerateBtn;
        private System.Windows.Forms.Button brakeBtn;
        private System.Windows.Forms.Label speedLbl;
    }
}

