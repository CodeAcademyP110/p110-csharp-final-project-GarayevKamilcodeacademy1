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
    public partial class IncomeOutcomeForm : Form
    {
        FitnessEntities111 entites;
        public IncomeOutcomeForm()
        {
            InitializeComponent();
            entites = new FitnessEntities111();
        }

        private void IncomeOutcomeForm_Load(object sender, EventArgs e)
        {
            lblIncome.Text = entites.Incomes.Sum(x => x.Income1).ToString();
            lblIncome.Text = entites.Outcomes.Sum(x => x.Outcome1).ToString();
        }
    }
}
