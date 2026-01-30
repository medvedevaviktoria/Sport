using Sport.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Sport.AppForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ContextManager.loginForm = this;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login(textBoxLogin.Text.Trim(), textBoxPassword.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Введите данные правильно", "Введите данные правильно", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Login(string login, string password)
        {
            var user = Program.context.Users
                .Where(u => u.UserLogin == login && u.UserPassword == password)
                .FirstOrDefault();

            if (user == null)
            {
                throw new Exception();
            }

            ContextManager.user = user;
            var productForm = new ProductForm();
            ContextManager.productForm.Show();
            ContextManager.loginForm.Hide();
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            ContextManager.productForm.Show();
            ContextManager.loginForm.Hide();
        }
    }
}
