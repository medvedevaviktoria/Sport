using Sport.AppControls;
using Sport.AppModels;
using Sport.AppServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Sport.AppForms
{
    public partial class ProductForm : Form
    {
        private List<Product> _products;
        public ProductForm()
        {
            InitializeComponent();
            ContextManager.productForm = this;
            comboBoxDiscount.SelectedIndex = 0;
            if (ContextManager.user != null)
            {
                ShowAddProductButton();
                ShowOrderButton();
                ShowAdvancedPanel();
            }
        }
        public void SetFullNameAndRole()
        {
            if (ContextManager.user != null)
            {
                labelFIO.Text = $"{ContextManager.user.UserSurname} {ContextManager.user.UserName} {ContextManager.user.UserPatronymic}";
                labelRole.Text = ContextManager.user.Role.RoleName;
            }
        }

        private void ShowAdvancedPanel()
        {
            advancedPanel.Visible = (ContextManager.user.IsAdmin() || ContextManager.user.IsManager());
        }

        private void ShowOrderButton()
        {
            buttonOrders.Visible = (ContextManager.user.IsAdmin() || ContextManager.user.IsManager());
        }

        private void ShowAddProductButton()
        {
            buttonAdd.Visible = ContextManager.user.IsAdmin();
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void RefreshList()
        {
            ClearProducts();
            SelectProducts();
            ShowProducts();
        }

        private void SelectProducts()
        {
            string searchInput = textBoxSearch.Text.Trim();
            bool lessInput = radioButtonLess.Checked;

            IQueryable<Product> tmpProducts = Program.context.Products;

            if (!String.IsNullOrEmpty(searchInput))
            {
                tmpProducts = tmpProducts.Where(obj => DbFunctions.Like(obj.ProductName.ProductName1, "%" + searchInput + "%"));
            }

            if (lessInput)
            {
                tmpProducts = tmpProducts.OrderBy(p => p.ProductCost);
            }
            else
            {
                tmpProducts = tmpProducts.OrderByDescending(p => p.ProductCost);
            }

            if (comboBoxDiscount.SelectedIndex > 0)
            {
                switch (comboBoxDiscount.SelectedIndex)
                {
                    case 1:
                        tmpProducts = tmpProducts.Where(p => p.ProductDiscountAmount < 10);
                        break;
                    case 2:
                        tmpProducts = tmpProducts.Where(p => p.ProductDiscountAmount >= 10 && p.ProductDiscountAmount < 15);
                        break;
                    case 3:
                        tmpProducts = tmpProducts.Where(p => p.ProductDiscountAmount >= 15);
                        break;
                }
            }

            labelCount.Text = $"Найдено: {tmpProducts.Count()} из {Program.context.Products.Count()}";

            _products = tmpProducts.ToList();
        }

        private void ShowProducts()
        {
            foreach (Product product in _products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }
        }

        private void ClearProducts()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateUpdateProductForm createUpdateProductForm = new CreateUpdateProductForm();
            DialogResult saved = createUpdateProductForm.ShowDialog();
            if (saved == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            ContextManager.orderForm.Show();
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

        private void ProductForm_Shown(object sender, EventArgs e)
        {
            SetFullNameAndRole();
        }

        private void radioButtonMore_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void radioButtonLess_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
