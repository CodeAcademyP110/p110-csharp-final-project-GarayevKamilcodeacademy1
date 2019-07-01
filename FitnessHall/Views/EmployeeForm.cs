using FitnessHall.PartialViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessHall.Views
{
    public partial class EmployeeForm : Form
    {
      
      
        public EmployeeForm()
        {
            InitializeComponent();
        }

      
      
        private void Button3_Click(object sender, EventArgs e)
        {
            new SaleForm().ShowDialog();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new AddCustomerForm().ShowDialog();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
         //   new AddOutcomeForm().ShowDialog();
        }
    }
}
