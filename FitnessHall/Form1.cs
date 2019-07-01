using FitnessHall.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FitnessHall
{
    public partial class Form1 : Form
    {
        private readonly FitnessEntities111 context;
        public Form1()
        {
            InitializeComponent();
            context = new FitnessEntities111();
        }

        private void BtnSingIn_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username == string.Empty || password == string.Empty)
            {
                Warning("Error", "Username and password fields should be filled");
                return;
            }
            var loginer = context.Employees.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
            if (loginer == null)
            {
                Warning("Error", "Username or password is invalid");
                return;
            }
            if (password != loginer.Password)
            {
                Warning("Error", "Username or password is invalid");
                return;
            }
            
            if (loginer.HasVerified)
                new AdminForm().ShowDialog();
            else new EmployeeForm().ShowDialog();          
            Close();
        }

        private void Warning(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSingIn;
        }
    }
}
