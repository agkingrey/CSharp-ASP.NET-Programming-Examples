namespace HospitalChargesKingrey
{
    partial class HospitalCharges
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.numberOfDaysLbl = new System.Windows.Forms.Label();
            this.medChargesLbl = new System.Windows.Forms.Label();
            this.surgicalChargesLbl = new System.Windows.Forms.Label();
            this.labFeeLbl = new System.Windows.Forms.Label();
            this.rehabChargesLbl = new System.Windows.Forms.Label();
            this.numberOfDaysTxt = new System.Windows.Forms.TextBox();
            this.medChargesTxt = new System.Windows.Forms.TextBox();
            this.surgicalChargesTxt = new System.Windows.Forms.TextBox();
            this.labFeesTxt = new System.Windows.Forms.TextBox();
            this.physicalRehabTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.totalChargesTxt = new System.Windows.Forms.TextBox();
            this.totalChargesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(245, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Hospital Charge Calculator";
            // 
            // numberOfDaysLbl
            // 
            this.numberOfDaysLbl.AutoSize = true;
            this.numberOfDaysLbl.Location = new System.Drawing.Point(12, 74);
            this.numberOfDaysLbl.Name = "numberOfDaysLbl";
            this.numberOfDaysLbl.Size = new System.Drawing.Size(156, 13);
            this.numberOfDaysLbl.TabIndex = 1;
            this.numberOfDaysLbl.Text = "Number of Days in the Hospital:";
            // 
            // medChargesLbl
            // 
            this.medChargesLbl.AutoSize = true;
            this.medChargesLbl.Location = new System.Drawing.Point(12, 103);
            this.medChargesLbl.Name = "medChargesLbl";
            this.medChargesLbl.Size = new System.Drawing.Size(104, 13);
            this.medChargesLbl.TabIndex = 2;
            this.medChargesLbl.Text = "Medication Charges:";
            // 
            // surgicalChargesLbl
            // 
            this.surgicalChargesLbl.AutoSize = true;
            this.surgicalChargesLbl.Location = new System.Drawing.Point(12, 135);
            this.surgicalChargesLbl.Name = "surgicalChargesLbl";
            this.surgicalChargesLbl.Size = new System.Drawing.Size(90, 13);
            this.surgicalChargesLbl.TabIndex = 3;
            this.surgicalChargesLbl.Text = "Surgical Charges:";
            // 
            // labFeeLbl
            // 
            this.labFeeLbl.AutoSize = true;
            this.labFeeLbl.Location = new System.Drawing.Point(12, 165);
            this.labFeeLbl.Name = "labFeeLbl";
            this.labFeeLbl.Size = new System.Drawing.Size(54, 13);
            this.labFeeLbl.TabIndex = 4;
            this.labFeeLbl.Text = "Lab Fees:";
            // 
            // rehabChargesLbl
            // 
            this.rehabChargesLbl.AutoSize = true;
            this.rehabChargesLbl.Location = new System.Drawing.Point(12, 190);
            this.rehabChargesLbl.Name = "rehabChargesLbl";
            this.rehabChargesLbl.Size = new System.Drawing.Size(126, 13);
            this.rehabChargesLbl.TabIndex = 5;
            this.rehabChargesLbl.Text = "Physical Rehab Charges:";
            // 
            // numberOfDaysTxt
            // 
            this.numberOfDaysTxt.Location = new System.Drawing.Point(172, 71);
            this.numberOfDaysTxt.Name = "numberOfDaysTxt";
            this.numberOfDaysTxt.Size = new System.Drawing.Size(100, 20);
            this.numberOfDaysTxt.TabIndex = 6;
            this.numberOfDaysTxt.TextChanged += new System.EventHandler(this.numberOfDaysTxt_TextChanged);
            // 
            // medChargesTxt
            // 
            this.medChargesTxt.Location = new System.Drawing.Point(172, 100);
            this.medChargesTxt.Name = "medChargesTxt";
            this.medChargesTxt.Size = new System.Drawing.Size(100, 20);
            this.medChargesTxt.TabIndex = 7;
            // 
            // surgicalChargesTxt
            // 
            this.surgicalChargesTxt.Location = new System.Drawing.Point(172, 128);
            this.surgicalChargesTxt.Name = "surgicalChargesTxt";
            this.surgicalChargesTxt.Size = new System.Drawing.Size(100, 20);
            this.surgicalChargesTxt.TabIndex = 8;
            // 
            // labFeesTxt
            // 
            this.labFeesTxt.Location = new System.Drawing.Point(172, 158);
            this.labFeesTxt.Name = "labFeesTxt";
            this.labFeesTxt.Size = new System.Drawing.Size(100, 20);
            this.labFeesTxt.TabIndex = 9;
            // 
            // physicalRehabTxt
            // 
            this.physicalRehabTxt.Location = new System.Drawing.Point(172, 184);
            this.physicalRehabTxt.Name = "physicalRehabTxt";
            this.physicalRehabTxt.Size = new System.Drawing.Size(100, 20);
            this.physicalRehabTxt.TabIndex = 10;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 226);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(93, 226);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // totalChargesTxt
            // 
            this.totalChargesTxt.Location = new System.Drawing.Point(172, 226);
            this.totalChargesTxt.Name = "totalChargesTxt";
            this.totalChargesTxt.Size = new System.Drawing.Size(100, 20);
            this.totalChargesTxt.TabIndex = 13;
            // 
            // totalChargesLbl
            // 
            this.totalChargesLbl.AutoSize = true;
            this.totalChargesLbl.Location = new System.Drawing.Point(181, 207);
            this.totalChargesLbl.Name = "totalChargesLbl";
            this.totalChargesLbl.Size = new System.Drawing.Size(76, 13);
            this.totalChargesLbl.TabIndex = 14;
            this.totalChargesLbl.Text = "Total Charges:";
            // 
            // HospitalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.totalChargesLbl);
            this.Controls.Add(this.totalChargesTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.physicalRehabTxt);
            this.Controls.Add(this.labFeesTxt);
            this.Controls.Add(this.surgicalChargesTxt);
            this.Controls.Add(this.medChargesTxt);
            this.Controls.Add(this.numberOfDaysTxt);
            this.Controls.Add(this.rehabChargesLbl);
            this.Controls.Add(this.labFeeLbl);
            this.Controls.Add(this.surgicalChargesLbl);
            this.Controls.Add(this.medChargesLbl);
            this.Controls.Add(this.numberOfDaysLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label numberOfDaysLbl;
        private System.Windows.Forms.Label medChargesLbl;
        private System.Windows.Forms.Label surgicalChargesLbl;
        private System.Windows.Forms.Label labFeeLbl;
        private System.Windows.Forms.Label rehabChargesLbl;
        private System.Windows.Forms.TextBox numberOfDaysTxt;
        private System.Windows.Forms.TextBox medChargesTxt;
        private System.Windows.Forms.TextBox surgicalChargesTxt;
        private System.Windows.Forms.TextBox labFeesTxt;
        private System.Windows.Forms.TextBox physicalRehabTxt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox totalChargesTxt;
        private System.Windows.Forms.Label totalChargesLbl;
    }
}

