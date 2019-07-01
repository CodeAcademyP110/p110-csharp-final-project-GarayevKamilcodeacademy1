using FitnessHall.PartialViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessHall.Views
{
    public partial class AdminForm : Form
    {
        FitnessEntities111 context;
        public AdminForm()
        {          
            InitializeComponent();
           
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            context = new FitnessEntities111();
            CustomerDatagrid.DataSource = context.Customers.ToList();
            EmployeeDatagrid.DataSource = context.Employees.ToList();
        }

        private void EmployeeDataShow_Click(object sender, EventArgs e)
        {
            CustomerDatagrid.Visible = false;
            EmployeeDatagrid.Visible = true;
        }

        private void CustomersDataShow_Click(object sender, EventArgs e)
        {
            CustomerDatagrid.Visible = true;
            EmployeeDatagrid.Visible = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().ShowDialog();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
          new AddCustomerForm().ShowDialog();
        }

     
        private void Button3_Click(object sender, EventArgs e)
        {
           
            CustomerDatagrid.EndEdit();
            EmployeeDatagrid.EndEdit();
            context.SaveChanges();
            this.Refresh();

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
