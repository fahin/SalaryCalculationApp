using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPEmployeeApp
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        salaryClass salary =new salaryClass();

        private void salaryButton_Click(object sender, EventArgs e)
        {
            salary.employeeName = employeeNameTextBox.Text;
            salary.basicAmount = Convert.ToDouble(salaryTextBox.Text);
            salary.medicalAmount = Convert.ToDouble(medicalTextBox.Text);
            salary.houseRent = Convert.ToDouble(homeTextBox.Text);
            MessageBox.Show(salary.employeeName+", your  Salary is  :"+salary.totalFunction());

        }
    }
}
