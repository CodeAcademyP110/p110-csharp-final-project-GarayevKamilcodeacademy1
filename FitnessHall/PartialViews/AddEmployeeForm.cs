using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessHall.PartialViews
{
    public partial class AddEmployeeForm : Form
    {
        FitnessEntities111 context;
        Employee newEmployee;
        public AddEmployeeForm()
        {
            InitializeComponent();
            context = new FitnessEntities111();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
          

            newEmployee = new Employee
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                HasVerified = rbtnHasVerified.Checked,
                PositionId = context.Positions.FirstOrDefault(x => x.Name == comboBox1.SelectedItem.ToString()).id,
            };

            context.Employees.Add(newEmployee);
            await  context.SaveChangesAsync();
            Close();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            foreach (var item in context?.Positions?.Select(x => x.Name).ToList())
            {
                comboBox1.Items.Add(item);
            }
            
        }
    }
}
