using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineKingrey
{
    public partial class vendingMachineForm : Form
    {
        public vendingMachineForm()
        {
            InitializeComponent();
        }
        //create a variable to hold the running total
        double totalPrice;
       
        //create an array to hold the amount of soda left for each type and one for the price
        int[] sodaRemaining = new int[5];
        double[] sodaPrices = { 1, 1, 1, 1.50, 1.50 };
        private void vendingMachineForm_Load(object sender, EventArgs e)
        {
            //fill picture boxes with the correct images
            colaPictureBox.Image = sodaImageList.Images[4];
            lemonLimeSodaPictureBox.Image = sodaImageList.Images[0];
            creamSodaPictureBox.Image = sodaImageList.Images[1];
            rootBeerPictureBox.Image = sodaImageList.Images[2];
            grapeSodaPictureBox.Image = sodaImageList.Images[3];

            

            //fill the machine with 20 of each type of soda
            for (int i = 0; i < sodaRemaining.Length; i++)
            {
                sodaRemaining[i] = 20;
            }
            
            //Set each of element of my array to different remaining labels
                colaRemainingLbl.Text = sodaRemaining[0].ToString();
                rootBeerRemainingLbl.Text = sodaRemaining[1].ToString();
                lemonLimeRemainingLbl.Text = sodaRemaining[2].ToString();
                grapeSodaRemainingLbl.Text = sodaRemaining[3].ToString();
                creamSodaRemainingLbl.Text = sodaRemaining[4].ToString();

            //running total label
            totalPriceLbl.Text = totalPrice.ToString("C");
            
        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += sodaPrices[0];
            sodaRemaining[0]--;
            totalPriceLbl.Text = totalPrice.ToString("C");
            colaRemainingLbl.Text = sodaRemaining[0].ToString();
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += sodaPrices[1];
            sodaRemaining[1]--;
            totalPriceLbl.Text = totalPrice.ToString("C");
            rootBeerRemainingLbl.Text = sodaRemaining[1].ToString();
        }

        private void lemonLimeSodaPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += sodaPrices[2];
            sodaRemaining[2]--;
            totalPriceLbl.Text = totalPrice.ToString("C");
            lemonLimeRemainingLbl.Text = sodaRemaining[2].ToString();
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += sodaPrices[3];
            sodaRemaining[3]--;
            totalPriceLbl.Text = totalPrice.ToString("C");
            grapeSodaRemainingLbl.Text = sodaRemaining[3].ToString();
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += sodaPrices[4];
            sodaRemaining[4]--;
            totalPriceLbl.Text = totalPrice.ToString("C");
            creamSodaRemainingLbl.Text = sodaRemaining[4].ToString();
        }
    }
}
