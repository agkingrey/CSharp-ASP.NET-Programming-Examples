using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarKingrey
{
    public partial class Form1 : Form
    {
        private Car car = new Car(1995,"Honda");
        public Form1()
        {
            InitializeComponent();
        }

        private void accelerateBtn_Click(object sender, EventArgs e)
        {

            car.Accelerate();
            speedLbl.Text = car.Speed.ToString();

        }

        private void brakeBtn_Click(object sender, EventArgs e)
        {
            car.Brake();
            speedLbl.Text = car.Speed.ToString();
        }
    }
}
