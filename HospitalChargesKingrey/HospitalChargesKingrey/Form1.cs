using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalChargesKingrey
{
    public partial class HospitalCharges : Form
    {
        public HospitalCharges()
        {
            InitializeComponent();
        }
        int dailyBaseCharge = 350;
        double stayCharges;
        double miscCharges;
        double totalCharges;

        //Calcualte stay charges will take the input of number of days from the user and return the price
        private double CalcStayCharges(int days)
        {
            return stayCharges = days * dailyBaseCharge;
        }

        //Calculate Misc charges will add up med surgical lab and rehab charges
        private double CalcMiscCharges(double medCharges, double surgicalCharges, double labFees, double physicalRehabCharges)
        {
            return miscCharges = medCharges + surgicalCharges + labFees + physicalRehabCharges;
        }

        //Calculate total charges will add the calcStayCharges and CalcMiscCharges methods
        private double CalcTotalCharges()
        {

            return totalCharges = stayCharges +  miscCharges;
        }

        private void numberOfDaysTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int days;
            double stayCharges, miscMedCharges, medCharges, surgicalCharges, labFees, physicalTherapyCharges, totalCharges;

            //grab number of days
            if (int.TryParse(numberOfDaysTxt.Text, out days))
            {
                //grab medCharges
                if (double.TryParse(medChargesTxt.Text, out medCharges))
                {
                    //grab surgical charges
                    if (double.TryParse(surgicalChargesTxt.Text, out surgicalCharges))
                    {
                        //grab labfees
                        if (double.TryParse(labFeesTxt.Text, out labFees))
                        {
                            //grab physical therapy charges
                            if(double.TryParse(physicalRehabTxt.Text, out physicalTherapyCharges))
                            {
                                stayCharges = CalcStayCharges(days);
                                miscMedCharges = CalcMiscCharges(medCharges, surgicalCharges, labFees, physicalTherapyCharges);
                                totalCharges = CalcTotalCharges();
                                totalChargesTxt.Text = totalCharges.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Please enter a physical therapy charge");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid lab fees");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Surgical charges.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid MedicalCharges");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid number of days");
            }
            
        }

        //exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
