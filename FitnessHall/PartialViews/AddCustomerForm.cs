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
    public partial class AddCustomerForm : Form
    {
        FitnessEntities111 context;
       
        public AddCustomerForm()
        {
            InitializeComponent();
            context = new FitnessEntities111();
        }
        private async void Button1_Click_1(object sender, EventArgs e)
        {           
            var customer = new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
            };
            var card = new Card();
           
            context.Customers.Add(customer);
            context.Cards.Add(card);
            await  context.SaveChangesAsync();
            MessageBox.Show(string.Format($"new customer succesfully added,Name:{txtName.Text} Surname:{txtSurname.Text}"));
        }
    }
}
