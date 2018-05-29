namespace GuessingGameKingrey
{
    partial class guessingGameForm
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
            this.numGenBtn = new System.Windows.Forms.Button();
            this.numGenLbl = new System.Windows.Forms.Label();
            this.guessANumberLbl = new System.Windows.Forms.Label();
            this.guessBtn = new System.Windows.Forms.Button();
            this.userInputLbl = new System.Windows.Forms.Label();
            this.tooHighTooLowLbl = new System.Windows.Forms.Label();
            this.numberOfGuessesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numGenBtn
            // 
            this.numGenBtn.Location = new System.Drawing.Point(96, 58);
            this.numGenBtn.Name = "numGenBtn";
            this.numGenBtn.Size = new System.Drawing.Size(75, 23);
            this.numGenBtn.TabIndex = 0;
            this.numGenBtn.Text = "&GENERATE";
            this.numGenBtn.UseVisualStyleBackColor = true;
            this.numGenBtn.Click += new System.EventHandler(this.numGenBtn_Click);
            // 
            // numGenLbl
            // 
            this.numGenLbl.AutoSize = true;
            this.numGenLbl.Location = new System.Drawing.Point(43, 24);
            this.numGenLbl.Name = "numGenLbl";
            this.numGenLbl.Size = new System.Drawing.Size(189, 13);
            this.numGenLbl.TabIndex = 1;
            this.numGenLbl.Text = "Click this button to generate a number!";
            // 
            // guessANumberLbl
            // 
            this.guessANumberLbl.AutoSize = true;
            this.guessANumberLbl.Location = new System.Drawing.Point(43, 120);
            this.guessANumberLbl.Name = "guessANumberLbl";
            this.guessANumberLbl.Size = new System.Drawing.Size(188, 13);
            this.guessANumberLbl.TabIndex = 2;
            this.guessANumberLbl.Text = "Okay, now it\'s time to guess a number!";
            // 
            // guessBtn
            // 
            this.guessBtn.Location = new System.Drawing.Point(82, 170);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(100, 23);
            this.guessBtn.TabIndex = 3;
            this.guessBtn.Text = "&SUBMIT GUESS";
            this.guessBtn.UseVisualStyleBackColor = true;
            // 
            // userInputLbl
            // 
            this.userInputLbl.Location = new System.Drawing.Point(82, 137);
            this.userInputLbl.Name = "userInputLbl";
            this.userInputLbl.Size = new System.Drawing.Size(100, 23);
            this.userInputLbl.TabIndex = 4;
            // 
            // tooHighTooLowLbl
            // 
            this.tooHighTooLowLbl.Location = new System.Drawing.Point(28, 209);
            this.tooHighTooLowLbl.Name = "tooHighTooLowLbl";
            this.tooHighTooLowLbl.Size = new System.Drawing.Size(100, 15);
            this.tooHighTooLowLbl.TabIndex = 5;
            // 
            // numberOfGuessesLbl
            // 
            this.numberOfGuessesLbl.Location = new System.Drawing.Point(134, 209);
            this.numberOfGuessesLbl.Name = "numberOfGuessesLbl";
            this.numberOfGuessesLbl.Size = new System.Drawing.Size(100, 15);
            this.numberOfGuessesLbl.TabIndex = 7;
            // 
            // guessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numberOfGuessesLbl);
            this.Controls.Add(this.tooHighTooLowLbl);
            this.Controls.Add(this.userInputLbl);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.guessANumberLbl);
            this.Controls.Add(this.numGenLbl);
            this.Controls.Add(this.numGenBtn);
            this.Name = "guessingGameForm";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.guessingGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numGenBtn;
        private System.Windows.Forms.Label numGenLbl;
        private System.Windows.Forms.Label guessANumberLbl;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Label userInputLbl;
        private System.Windows.Forms.Label tooHighTooLowLbl;
        private System.Windows.Forms.Label numberOfGuessesLbl;
    }
}

