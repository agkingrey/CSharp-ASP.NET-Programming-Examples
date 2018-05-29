using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace April11thHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getData(ProductionWorker worker)
        {
            //variables to hold emp number, shift number, and pay rate
            int empNumber;
            int shiftNumber;
            double payRate;

            //get employee name 
            worker.EmployeeName = empNameInputTxt.Text;

            //get the number
            if(int.TryParse(empNumInputTxt.Text, out empNumber))
            {
                worker.EmployeeNumber = empNumber;

                //get shift number
                if(int.TryParse(shiftNumInputTxt.Text, out shiftNumber))
                {
                    worker.ShiftNumber = shiftNumber;

                    //get payrate
                    if(double.TryParse(hourlyPayInputTxt.Text, out payRate))
                    {
                        worker.HourlyPayRate = payRate;
                    }
                    else
                    {
                        MessageBox.Show("Invalid pay rate");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid shift number");
                }
            }
            else
            {
                MessageBox.Show("Invalid emp number");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void createObjectBtn_Click(object sender, EventArgs e)
        {
            //create an object
            ProductionWorker myWorker = new ProductionWorker();

            //get data
            getData(myWorker);

            //display the data back
            empNameOutputLbl.Text = myWorker.EmployeeName;
            empNumOutputLbl.Text = myWorker.EmployeeNumber.ToString();
            shiftNumOutputLbl.Text = myWorker.ShiftNumber.ToString();
            hourlyPayOutputLbl.Text = myWorker.HourlyPayRate.ToString("c");
        }
    }
}
