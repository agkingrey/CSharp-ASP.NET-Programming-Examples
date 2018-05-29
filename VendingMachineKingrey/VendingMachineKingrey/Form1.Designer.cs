namespace VendingMachineKingrey
{
    partial class vendingMachineForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendingMachineForm));
            this.sodaImageList = new System.Windows.Forms.ImageList(this.components);
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.rootBeerPictureBox = new System.Windows.Forms.PictureBox();
            this.lemonLimeSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.grapeSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.creamSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.colaPriceLbl = new System.Windows.Forms.Label();
            this.rootBeerPriceLbl = new System.Windows.Forms.Label();
            this.lemomLimePriceLbl = new System.Windows.Forms.Label();
            this.grapeSodaPriceLbl = new System.Windows.Forms.Label();
            this.creamSodaPriceLbl = new System.Windows.Forms.Label();
            this.drinksLeftLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colaRemainingLbl = new System.Windows.Forms.Label();
            this.rootBeerRemainingLbl = new System.Windows.Forms.Label();
            this.lemonLimeRemainingLbl = new System.Windows.Forms.Label();
            this.grapeSodaRemainingLbl = new System.Windows.Forms.Label();
            this.creamSodaRemainingLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimeSodaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sodaImageList
            // 
            this.sodaImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sodaImageList.ImageStream")));
            this.sodaImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.sodaImageList.Images.SetKeyName(0, "500px-Sierra-Mist-2005.png");
            this.sodaImageList.Images.SetKeyName(1, "9039.jpg");
            this.sodaImageList.Images.SetKeyName(2, "Mug_Root_Beer_Logo.jpg");
            this.sodaImageList.Images.SetKeyName(3, "welchs-grape-soda.jpg");
            this.sodaImageList.Images.SetKeyName(4, "kSz1jtnn.jpg");
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.Location = new System.Drawing.Point(12, 12);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(55, 43);
            this.colaPictureBox.TabIndex = 0;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.colaPictureBox_Click);
            // 
            // rootBeerPictureBox
            // 
            this.rootBeerPictureBox.Location = new System.Drawing.Point(12, 80);
            this.rootBeerPictureBox.Name = "rootBeerPictureBox";
            this.rootBeerPictureBox.Size = new System.Drawing.Size(55, 43);
            this.rootBeerPictureBox.TabIndex = 1;
            this.rootBeerPictureBox.TabStop = false;
            this.rootBeerPictureBox.Click += new System.EventHandler(this.rootBeerPictureBox_Click);
            // 
            // lemonLimeSodaPictureBox
            // 
            this.lemonLimeSodaPictureBox.Location = new System.Drawing.Point(12, 156);
            this.lemonLimeSodaPictureBox.Name = "lemonLimeSodaPictureBox";
            this.lemonLimeSodaPictureBox.Size = new System.Drawing.Size(55, 43);
            this.lemonLimeSodaPictureBox.TabIndex = 2;
            this.lemonLimeSodaPictureBox.TabStop = false;
            this.lemonLimeSodaPictureBox.Click += new System.EventHandler(this.lemonLimeSodaPictureBox_Click);
            // 
            // grapeSodaPictureBox
            // 
            this.grapeSodaPictureBox.Location = new System.Drawing.Point(148, 12);
            this.grapeSodaPictureBox.Name = "grapeSodaPictureBox";
            this.grapeSodaPictureBox.Size = new System.Drawing.Size(55, 43);
            this.grapeSodaPictureBox.TabIndex = 3;
            this.grapeSodaPictureBox.TabStop = false;
            this.grapeSodaPictureBox.Click += new System.EventHandler(this.grapeSodaPictureBox_Click);
            // 
            // creamSodaPictureBox
            // 
            this.creamSodaPictureBox.Location = new System.Drawing.Point(148, 80);
            this.creamSodaPictureBox.Name = "creamSodaPictureBox";
            this.creamSodaPictureBox.Size = new System.Drawing.Size(55, 43);
            this.creamSodaPictureBox.TabIndex = 4;
            this.creamSodaPictureBox.TabStop = false;
            this.creamSodaPictureBox.Click += new System.EventHandler(this.creamSodaPictureBox_Click);
            // 
            // colaPriceLbl
            // 
            this.colaPriceLbl.AutoSize = true;
            this.colaPriceLbl.Location = new System.Drawing.Point(74, 12);
            this.colaPriceLbl.Name = "colaPriceLbl";
            this.colaPriceLbl.Size = new System.Drawing.Size(34, 13);
            this.colaPriceLbl.TabIndex = 5;
            this.colaPriceLbl.Text = "$1.00";
            // 
            // rootBeerPriceLbl
            // 
            this.rootBeerPriceLbl.AutoSize = true;
            this.rootBeerPriceLbl.Location = new System.Drawing.Point(74, 80);
            this.rootBeerPriceLbl.Name = "rootBeerPriceLbl";
            this.rootBeerPriceLbl.Size = new System.Drawing.Size(34, 13);
            this.rootBeerPriceLbl.TabIndex = 6;
            this.rootBeerPriceLbl.Text = "$1.00";
            // 
            // lemomLimePriceLbl
            // 
            this.lemomLimePriceLbl.AutoSize = true;
            this.lemomLimePriceLbl.Location = new System.Drawing.Point(74, 156);
            this.lemomLimePriceLbl.Name = "lemomLimePriceLbl";
            this.lemomLimePriceLbl.Size = new System.Drawing.Size(34, 13);
            this.lemomLimePriceLbl.TabIndex = 7;
            this.lemomLimePriceLbl.Text = "$1.00";
            // 
            // grapeSodaPriceLbl
            // 
            this.grapeSodaPriceLbl.AutoSize = true;
            this.grapeSodaPriceLbl.Location = new System.Drawing.Point(219, 12);
            this.grapeSodaPriceLbl.Name = "grapeSodaPriceLbl";
            this.grapeSodaPriceLbl.Size = new System.Drawing.Size(34, 13);
            this.grapeSodaPriceLbl.TabIndex = 8;
            this.grapeSodaPriceLbl.Text = "$1.50";
            // 
            // creamSodaPriceLbl
            // 
            this.creamSodaPriceLbl.AutoSize = true;
            this.creamSodaPriceLbl.Location = new System.Drawing.Point(219, 80);
            this.creamSodaPriceLbl.Name = "creamSodaPriceLbl";
            this.creamSodaPriceLbl.Size = new System.Drawing.Size(34, 13);
            this.creamSodaPriceLbl.TabIndex = 9;
            this.creamSodaPriceLbl.Text = "$1.50";
            // 
            // drinksLeftLbl
            // 
            this.drinksLeftLbl.Location = new System.Drawing.Point(73, 25);
            this.drinksLeftLbl.Name = "drinksLeftLbl";
            this.drinksLeftLbl.Size = new System.Drawing.Size(62, 14);
            this.drinksLeftLbl.TabIndex = 10;
            this.drinksLeftLbl.Text = "Drinks Left:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(73, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Drinks Left:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(73, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drinks Left:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(219, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Drinks Left:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(219, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Drinks Left:";
            // 
            // colaRemainingLbl
            // 
            this.colaRemainingLbl.Location = new System.Drawing.Point(73, 41);
            this.colaRemainingLbl.Name = "colaRemainingLbl";
            this.colaRemainingLbl.Size = new System.Drawing.Size(62, 14);
            this.colaRemainingLbl.TabIndex = 15;
            // 
            // rootBeerRemainingLbl
            // 
            this.rootBeerRemainingLbl.Location = new System.Drawing.Point(73, 107);
            this.rootBeerRemainingLbl.Name = "rootBeerRemainingLbl";
            this.rootBeerRemainingLbl.Size = new System.Drawing.Size(62, 14);
            this.rootBeerRemainingLbl.TabIndex = 16;
            // 
            // lemonLimeRemainingLbl
            // 
            this.lemonLimeRemainingLbl.Location = new System.Drawing.Point(73, 185);
            this.lemonLimeRemainingLbl.Name = "lemonLimeRemainingLbl";
            this.lemonLimeRemainingLbl.Size = new System.Drawing.Size(62, 14);
            this.lemonLimeRemainingLbl.TabIndex = 17;
            // 
            // grapeSodaRemainingLbl
            // 
            this.grapeSodaRemainingLbl.Location = new System.Drawing.Point(219, 41);
            this.grapeSodaRemainingLbl.Name = "grapeSodaRemainingLbl";
            this.grapeSodaRemainingLbl.Size = new System.Drawing.Size(62, 14);
            this.grapeSodaRemainingLbl.TabIndex = 18;
            // 
            // creamSodaRemainingLbl
            // 
            this.creamSodaRemainingLbl.Location = new System.Drawing.Point(219, 109);
            this.creamSodaRemainingLbl.Name = "creamSodaRemainingLbl";
            this.creamSodaRemainingLbl.Size = new System.Drawing.Size(62, 14);
            this.creamSodaRemainingLbl.TabIndex = 19;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(167, 155);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(61, 13);
            this.totalLbl.TabIndex = 20;
            this.totalLbl.Text = "Total Price:";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.Location = new System.Drawing.Point(168, 170);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(60, 13);
            this.totalPriceLbl.TabIndex = 21;
            // 
            // vendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.creamSodaRemainingLbl);
            this.Controls.Add(this.grapeSodaRemainingLbl);
            this.Controls.Add(this.lemonLimeRemainingLbl);
            this.Controls.Add(this.rootBeerRemainingLbl);
            this.Controls.Add(this.colaRemainingLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drinksLeftLbl);
            this.Controls.Add(this.creamSodaPriceLbl);
            this.Controls.Add(this.grapeSodaPriceLbl);
            this.Controls.Add(this.lemomLimePriceLbl);
            this.Controls.Add(this.rootBeerPriceLbl);
            this.Controls.Add(this.colaPriceLbl);
            this.Controls.Add(this.creamSodaPictureBox);
            this.Controls.Add(this.grapeSodaPictureBox);
            this.Controls.Add(this.lemonLimeSodaPictureBox);
            this.Controls.Add(this.rootBeerPictureBox);
            this.Controls.Add(this.colaPictureBox);
            this.Name = "vendingMachineForm";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.vendingMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimeSodaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList sodaImageList;
        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.PictureBox rootBeerPictureBox;
        private System.Windows.Forms.PictureBox lemonLimeSodaPictureBox;
        private System.Windows.Forms.PictureBox grapeSodaPictureBox;
        private System.Windows.Forms.PictureBox creamSodaPictureBox;
        private System.Windows.Forms.Label colaPriceLbl;
        private System.Windows.Forms.Label rootBeerPriceLbl;
        private System.Windows.Forms.Label lemomLimePriceLbl;
        private System.Windows.Forms.Label grapeSodaPriceLbl;
        private System.Windows.Forms.Label creamSodaPriceLbl;
        private System.Windows.Forms.Label drinksLeftLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label colaRemainingLbl;
        private System.Windows.Forms.Label rootBeerRemainingLbl;
        private System.Windows.Forms.Label lemonLimeRemainingLbl;
        private System.Windows.Forms.Label grapeSodaRemainingLbl;
        private System.Windows.Forms.Label creamSodaRemainingLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label totalPriceLbl;
    }
}

