using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11AustinKingrey
{
    public partial class EmployeeApplication : Form
    {
        public EmployeeApplication()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDataSet);

        }

        private void EmployeeApplication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.SearchName(
                this.employeesDataSet.Employees, searchTextBox.Text);
        }

        private void revealAllBtn_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);
        }
    }
}
