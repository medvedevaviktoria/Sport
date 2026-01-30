using Sport.AppControls;
using Sport.AppModels;
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
    public partial class OrderForm : Form
    {
        private List<Order> _orders;
        public OrderForm()
        {
            InitializeComponent();
            ContextManager.orderForm = this;
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContextManager.productForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateUpdateOrderForm createUpdateOrder = new CreateUpdateOrderForm();
            DialogResult saved = createUpdateOrder.ShowDialog();

            if (saved == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            ClearOrders();
            SelectOrders();
            ShowOrders();
        }

        private void SelectOrders()
        {
            _orders = Program.context.Orders.ToList();
        }

        private void ShowOrders()
        {
            foreach (Order order in _orders)
            {
                flowLayoutPanel1.Controls.Add(new OrderUserControl(order));
            }
        }

        private void ClearOrders()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ContextManager.productForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            this.Hide();
            ContextManager.user = null;
            ContextManager.loginForm.Show();
        }

        private void OrderForm_Shown(object sender, EventArgs e)
        {
            SetFullNameAndRole();
        }

        public void SetFullNameAndRole()
        {
            if (ContextManager.user != null)
            {
                labelFIO.Text = $"{ContextManager.user.UserSurname} {ContextManager.user.UserName} {ContextManager.user.UserPatronymic}";
                labelRole.Text = ContextManager.user.Role.RoleName;
            }
        }
    }
}
