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
    public partial class SaleForm : Form
    {
        FitnessEntities111 context;
        Order newOrder;
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            context = new FitnessEntities111();
            foreach (var item in context.Customers.Select(x => x.Name))
            {
                cmbCustomer.Items.Add(item);
            }
            foreach (var item in context.Packages.Select(x => x.Name))
            {
                cmbPackages.Items.Add(item);
            }
            foreach (var item in context.Times.Select(x => x.Hours))
            {
                cmbTimes.Items.Add(item);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }
        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            if (rbtnPool.Checked) services.Add(context.Services.FirstOrDefault(x => x.Name == "Pool"));
            else if(rbtnFitness.Checked) services.Add(context.Services.FirstOrDefault(x => x.Name == "Fitness"));
            else if (rbtnMassage.Checked) services.Add(context.Services.FirstOrDefault(x => x.Name == "Massage"));
            return services;
        }
    }
}
