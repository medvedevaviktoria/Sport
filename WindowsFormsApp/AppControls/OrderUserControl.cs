using Sport.AppForms;
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

namespace Sport.AppControls
{
    public partial class OrderUserControl : UserControl
    {
        private Order _order;
        public OrderUserControl(Order order)
        {
            InitializeComponent();
            _order = order;
            FillInfo();
        }

        private void FillInfo()
        {
            orderIDLabel1.Text = _order.OrderID.ToString();
            orderStatusIDLabel1.Text = _order.OrderStatu.OrderStatusName;
            pickupPointIDLabel1.Text = Program.context.PickupPoints.Where(o => o.PickupPointID == _order.PickupPointID).FirstOrDefault().Address;
            orderCreateDateLabel1.Text = string.Format("{0:dd.MM.yyyy}", _order.OrderCreateDate);
            userIDLabel1.Text = $"{_order.User.UserSurname} {_order.User.UserName} {_order.User.UserPatronymic}";
            orderGetCodeLabel1.Text = _order.OrderGetCode.ToString();
            orderDeliveryDateLabel1.Text = string.Format("{0:dd.MM.yyyy}", _order.OrderDeliveryDate);
        }

        private void order_Click(object sender, EventArgs e)
        {

            CreateUpdateOrderForm createUpdateOrderForm = new CreateUpdateOrderForm(_order);

            DialogResult saved = createUpdateOrderForm.ShowDialog();
            if (saved == DialogResult.OK)
            {
                ContextManager.orderForm.RefreshList();
            }
        }
    }
}
