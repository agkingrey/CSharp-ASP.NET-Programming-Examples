namespace TicTacToeSimulatorKingrey
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
            this.firstLbl = new System.Windows.Forms.Label();
            this.secondLbl = new System.Windows.Forms.Label();
            this.thirdLbl = new System.Windows.Forms.Label();
            this.seventhLbl = new System.Windows.Forms.Label();
            this.fifthLbl = new System.Windows.Forms.Label();
            this.fourthLbl = new System.Windows.Forms.Label();
            this.sixthLbl = new System.Windows.Forms.Label();
            this.ninthLbl = new System.Windows.Forms.Label();
            this.eighthLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.winnerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstLbl
            // 
            this.firstLbl.Location = new System.Drawing.Point(39, 28);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(44, 44);
            this.firstLbl.TabIndex = 0;
            // 
            // secondLbl
            // 
            this.secondLbl.Location = new System.Drawing.Point(109, 28);
            this.secondLbl.Name = "secondLbl";
            this.secondLbl.Size = new System.Drawing.Size(44, 44);
            this.secondLbl.TabIndex = 1;
            // 
            // thirdLbl
            // 
            this.thirdLbl.Location = new System.Drawing.Point(186, 28);
            this.thirdLbl.Name = "thirdLbl";
            this.thirdLbl.Size = new System.Drawing.Size(44, 44);
            this.thirdLbl.TabIndex = 2;
            // 
            // seventhLbl
            // 
            this.seventhLbl.Location = new System.Drawing.Point(39, 143);
            this.seventhLbl.Name = "seventhLbl";
            this.seventhLbl.Size = new System.Drawing.Size(44, 44);
            this.seventhLbl.TabIndex = 3;
            this.seventhLbl.Click += new System.EventHandler(this.seventhLbl_Click);
            // 
            // fifthLbl
            // 
            this.fifthLbl.Location = new System.Drawing.Point(109, 89);
            this.fifthLbl.Name = "fifthLbl";
            this.fifthLbl.Size = new System.Drawing.Size(44, 44);
            this.fifthLbl.TabIndex = 4;
            // 
            // fourthLbl
            // 
            this.fourthLbl.Location = new System.Drawing.Point(39, 89);
            this.fourthLbl.Name = "fourthLbl";
            this.fourthLbl.Size = new System.Drawing.Size(44, 44);
            this.fourthLbl.TabIndex = 5;
            // 
            // sixthLbl
            // 
            this.sixthLbl.Location = new System.Drawing.Point(186, 89);
            this.sixthLbl.Name = "sixthLbl";
            this.sixthLbl.Size = new System.Drawing.Size(44, 44);
            this.sixthLbl.TabIndex = 6;
            // 
            // ninthLbl
            // 
            this.ninthLbl.Location = new System.Drawing.Point(186, 143);
            this.ninthLbl.Name = "ninthLbl";
            this.ninthLbl.Size = new System.Drawing.Size(44, 44);
            this.ninthLbl.TabIndex = 7;
            // 
            // eighthLbl
            // 
            this.eighthLbl.Location = new System.Drawing.Point(109, 143);
            this.eighthLbl.Name = "eighthLbl";
            this.eighthLbl.Size = new System.Drawing.Size(44, 44);
            this.eighthLbl.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "SIMULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // winnerLbl
            // 
            this.winnerLbl.Location = new System.Drawing.Point(47, 236);
            this.winnerLbl.Name = "winnerLbl";
            this.winnerLbl.Size = new System.Drawing.Size(183, 23);
            this.winnerLbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.winnerLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eighthLbl);
            this.Controls.Add(this.ninthLbl);
            this.Controls.Add(this.sixthLbl);
            this.Controls.Add(this.fourthLbl);
            this.Controls.Add(this.fifthLbl);
            this.Controls.Add(this.seventhLbl);
            this.Controls.Add(this.thirdLbl);
            this.Controls.Add(this.secondLbl);
            this.Controls.Add(this.firstLbl);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstLbl;
        private System.Windows.Forms.Label secondLbl;
        private System.Windows.Forms.Label thirdLbl;
        private System.Windows.Forms.Label seventhLbl;
        private System.Windows.Forms.Label fifthLbl;
        private System.Windows.Forms.Label fourthLbl;
        private System.Windows.Forms.Label sixthLbl;
        private System.Windows.Forms.Label ninthLbl;
        private System.Windows.Forms.Label eighthLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label winnerLbl;
    }
}

