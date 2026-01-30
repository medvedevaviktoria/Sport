using Sport.AppModels;
using Sport.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Sport.AppForms
{
    public partial class CreateUpdateOrderForm : Form
    {
        private Order _order;
        public CreateUpdateOrderForm()
        {
            InitializeComponent();
            labelTitle.Text = "ООО «Спорт» - Добавление заказа";
            this.Text = "ООО «Спорт» - Добавление заказа";
            _order = new Order();
        }
        public CreateUpdateOrderForm(Order order)
        {
            InitializeComponent();
            labelTitle.Text = "ООО «Спорт» - Редактирование заказа";
            this.Text = "ООО «Спорт» - Редактирование заказа";
            orderCreateDateDateTimePicker.Enabled = false;
            userIDComboBox.Enabled = false;
            pickupPointIDComboBox.Enabled = false;
            buttonDelete.Visible = true;
            _order = order;
        }

        private void CreateUpdateOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.User". При необходимости она может быть перемещена или удалена.
            //this.userTableAdapter.Fill(this.medvedeva_vy_sportDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.PickupPoint". При необходимости она может быть перемещена или удалена.
            this.pickupPointTableAdapter.Fill(this.medvedeva_vy_sportDataSet.PickupPoint);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.OrderStatus". При необходимости она может быть перемещена или удалена.
            this.orderStatusTableAdapter.Fill(this.medvedeva_vy_sportDataSet.OrderStatus);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.Order". При необходимости она может быть перемещена или удалена.
            //this.orderTableAdapter.Fill(this.medvedeva_vy_sportDataSet.Order);

            //из-за того, что тут ФИО поделено на отдельные поля, приходится писать "вручную"
            List<User> users = Program.context.Users.ToList();
            foreach (User user in users)
            {
                userIDComboBox.Items.Add($"{user.UserSurname} {user.UserName} {user.UserPatronymic}");
            }

            //если не новый заказ
            if (!_order.IsNew())
            {
                FillForm();
            }
            else //если заказ новый
            {
                orderStatusIDComboBox.SelectedIndex = 0;
                pickupPointIDComboBox.SelectedIndex = 0;
                userIDComboBox.SelectedIndex = 0;
            }
        }

        private int GenerateNextReceiptCode()
        {
            Order order = Program.context.Orders.OrderByDescending(o => o.OrderGetCode).FirstOrDefault();
            return order.OrderGetCode + 1;
        }

        private void FillForm()
        {
            orderIDLabel1.Text = _order.OrderID.ToString();
            orderCreateDateDateTimePicker.Value = _order.OrderCreateDate;
            orderDeliveryDateDateTimePicker.Value = _order.OrderDeliveryDate;
            pickupPointIDComboBox.SelectedValue = _order.PickupPointID;
            userIDComboBox.SelectedIndex = _order.UserID - 1;
            orderStatusIDComboBox.SelectedValue = _order.OrderStatusID;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateDate())
            {
                MessageBox.Show("Дата выдачи не может быть меньше даты заказа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();
            try
            {
                if (_order.IsNew())
                {
                    Program.context.Orders.Add(_order);
                }
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateDate()
        {
            if (orderDeliveryDateDateTimePicker.Value.Date < orderCreateDateDateTimePicker.Value.Date)
            {
                return false;
            }
            return true;
        }

        private void FillModelFields()
        {
            //я так понимаю, SelectedValue мы пишем в случае, если у нас в конструкторе у комбобоксов используется источник данных, потому что мы там самостоятельно задаём SelectdValue. а если мы вручную писали коллекцию, пишем SlectedIndex, так как SlectedValue у нас нет...
            //а ещё не забывайте, что в комбобоксах отсчёт начинается с 0, а в бд с 1, поэтому при обращении к комбобоксу прибавляем единичку, при обращении к бд - отнимаем.(если что это очень плохой вариант, но что поделать, плюсом ко всему - он работает)
            _order.UserID = (int)userIDComboBox.SelectedIndex + 1;
            _order.OrderCreateDate = orderCreateDateDateTimePicker.Value;
            _order.PickupPointID = (int)pickupPointIDComboBox.SelectedValue;
            _order.OrderDeliveryDate = orderDeliveryDateDateTimePicker.Value;
            _order.OrderStatusID = (int)orderStatusIDComboBox.SelectedValue;
            _order.OrderGetCode = GenerateNextReceiptCode();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (toBeDeleted == DialogResult.OK)
            {
                Order order = Program.context.Orders.Where(o => o.OrderID == _order.OrderID).FirstOrDefault();
                try
                {
                    Program.context.Orders.Remove(_order);
                    Program.context.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Не удалось удалить заказ.", " Не удалось удалить заказ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
