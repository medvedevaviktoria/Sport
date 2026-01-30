namespace Sport.AppControls
{
    partial class OrderUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderStatusIDLabel;
            System.Windows.Forms.Label pickupPointIDLabel;
            System.Windows.Forms.Label orderCreateDateLabel;
            System.Windows.Forms.Label orderDeliveryDateLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label orderGetCodeLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderDeliveryDateLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderIDLabel1 = new System.Windows.Forms.Label();
            this.orderStatusIDLabel1 = new System.Windows.Forms.Label();
            this.pickupPointIDLabel1 = new System.Windows.Forms.Label();
            this.orderCreateDateLabel1 = new System.Windows.Forms.Label();
            this.userIDLabel1 = new System.Windows.Forms.Label();
            this.orderGetCodeLabel1 = new System.Windows.Forms.Label();
            this.medvedeva_vy_sportDataSet = new Sport.medvedeva_vy_sportDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new Sport.medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager();
            orderIDLabel = new System.Windows.Forms.Label();
            orderStatusIDLabel = new System.Windows.Forms.Label();
            pickupPointIDLabel = new System.Windows.Forms.Label();
            orderCreateDateLabel = new System.Windows.Forms.Label();
            orderDeliveryDateLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            orderGetCodeLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(6, 5);
            orderIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(24, 15);
            orderIDLabel.TabIndex = 0;
            orderIDLabel.Text = "ID:";
            orderIDLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // orderStatusIDLabel
            // 
            orderStatusIDLabel.AutoSize = true;
            orderStatusIDLabel.Location = new System.Drawing.Point(6, 24);
            orderStatusIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderStatusIDLabel.Name = "orderStatusIDLabel";
            orderStatusIDLabel.Size = new System.Drawing.Size(81, 15);
            orderStatusIDLabel.TabIndex = 2;
            orderStatusIDLabel.Text = "Статус заказа:";
            orderStatusIDLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // pickupPointIDLabel
            // 
            pickupPointIDLabel.AutoSize = true;
            pickupPointIDLabel.Location = new System.Drawing.Point(6, 45);
            pickupPointIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pickupPointIDLabel.Name = "pickupPointIDLabel";
            pickupPointIDLabel.Size = new System.Drawing.Size(125, 15);
            pickupPointIDLabel.TabIndex = 4;
            pickupPointIDLabel.Text = "Адрес пункта выдачи:";
            pickupPointIDLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // orderCreateDateLabel
            // 
            orderCreateDateLabel.AutoSize = true;
            orderCreateDateLabel.Location = new System.Drawing.Point(6, 68);
            orderCreateDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderCreateDateLabel.Name = "orderCreateDateLabel";
            orderCreateDateLabel.Size = new System.Drawing.Size(71, 15);
            orderCreateDateLabel.TabIndex = 6;
            orderCreateDateLabel.Text = "Дата заказа:";
            orderCreateDateLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // orderDeliveryDateLabel
            // 
            orderDeliveryDateLabel.AutoSize = true;
            orderDeliveryDateLabel.Location = new System.Drawing.Point(16, 24);
            orderDeliveryDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderDeliveryDateLabel.Name = "orderDeliveryDateLabel";
            orderDeliveryDateLabel.Size = new System.Drawing.Size(87, 15);
            orderDeliveryDateLabel.TabIndex = 8;
            orderDeliveryDateLabel.Text = "Дата доставки:";
            orderDeliveryDateLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(6, 90);
            userIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(57, 15);
            userIDLabel.TabIndex = 10;
            userIDLabel.Text = "Заказчик:";
            userIDLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // orderGetCodeLabel
            // 
            orderGetCodeLabel.AutoSize = true;
            orderGetCodeLabel.Location = new System.Drawing.Point(6, 111);
            orderGetCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderGetCodeLabel.Name = "orderGetCodeLabel";
            orderGetCodeLabel.Size = new System.Drawing.Size(92, 15);
            orderGetCodeLabel.TabIndex = 12;
            orderGetCodeLabel.Text = "Код получения:";
            orderGetCodeLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(orderDeliveryDateLabel);
            this.panel2.Controls.Add(this.orderDeliveryDateLabel1);
            this.panel2.Location = new System.Drawing.Point(728, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 136);
            this.panel2.TabIndex = 17;
            this.panel2.Click += new System.EventHandler(this.order_Click);
            // 
            // orderDeliveryDateLabel1
            // 
            this.orderDeliveryDateLabel1.AutoSize = true;
            this.orderDeliveryDateLabel1.Location = new System.Drawing.Point(38, 68);
            this.orderDeliveryDateLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderDeliveryDateLabel1.Name = "orderDeliveryDateLabel1";
            this.orderDeliveryDateLabel1.Size = new System.Drawing.Size(38, 15);
            this.orderDeliveryDateLabel1.TabIndex = 9;
            this.orderDeliveryDateLabel1.Text = "label2";
            this.orderDeliveryDateLabel1.Click += new System.EventHandler(this.order_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(orderIDLabel);
            this.panel1.Controls.Add(this.orderIDLabel1);
            this.panel1.Controls.Add(orderStatusIDLabel);
            this.panel1.Controls.Add(this.orderStatusIDLabel1);
            this.panel1.Controls.Add(pickupPointIDLabel);
            this.panel1.Controls.Add(this.pickupPointIDLabel1);
            this.panel1.Controls.Add(orderCreateDateLabel);
            this.panel1.Controls.Add(this.orderCreateDateLabel1);
            this.panel1.Controls.Add(userIDLabel);
            this.panel1.Controls.Add(this.userIDLabel1);
            this.panel1.Controls.Add(orderGetCodeLabel);
            this.panel1.Controls.Add(this.orderGetCodeLabel1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 136);
            this.panel1.TabIndex = 16;
            this.panel1.Click += new System.EventHandler(this.order_Click);
            // 
            // orderIDLabel1
            // 
            this.orderIDLabel1.AutoSize = true;
            this.orderIDLabel1.Location = new System.Drawing.Point(156, 5);
            this.orderIDLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderIDLabel1.Name = "orderIDLabel1";
            this.orderIDLabel1.Size = new System.Drawing.Size(38, 15);
            this.orderIDLabel1.TabIndex = 1;
            this.orderIDLabel1.Text = "label2";
            this.orderIDLabel1.Click += new System.EventHandler(this.order_Click);
            // 
            // orderStatusIDLabel1
            // 
            this.orderStatusIDLabel1.AutoSize = true;
            this.orderStatusIDLabel1.Location = new System.Drawing.Point(156, 24);
            this.orderStatusIDLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderStatusIDLabel1.Name = "orderStatusIDLabel1";
            this.orderStatusIDLabel1.Size = new System.Drawing.Size(38, 15);
            this.orderStatusIDLabel1.TabIndex = 3;
            this.orderStatusIDLabel1.Text = "label2";
            this.orderStatusIDLabel1.Click += new System.EventHandler(this.order_Click);
            // 
            // pickupPointIDLabel1
            // 
            this.pickupPointIDLabel1.AutoSize = true;
            this.pickupPointIDLabel1.Location = new System.Drawing.Point(156, 45);
            this.pickupPointIDLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pickupPointIDLabel1.Name = "pickupPointIDLabel1";
            this.pickupPointIDLabel1.Size = new System.Drawing.Size(38, 15);
            this.pickupPointIDLabel1.TabIndex = 5;
            this.pickupPointIDLabel1.Text = "label2";
            this.pickupPointIDLabel1.Click += new System.EventHandler(this.order_Click);
            // 
            // orderCreateDateLabel1
            // 
            this.orderCreateDateLabel1.AutoSize = true;
            this.orderCreateDateLabel1.Location = new System.Drawing.Point(156, 68);
            this.orderCreateDateLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderCreateDateLabel1.Name = "orderCreateDateLabel1";
            this.orderCreateDateLabel1.Size = new System.Drawing.Size(38, 15);
            this.orderCreateDateLabel1.TabIndex = 7;
            this.orderCreateDateLabel1.Text = "label2";
            this.orderCreateDateLabel1.Click += new System.EventHandler(this.order_Click);
            // 
            // userIDLabel1
            // 
            this.userIDLabel1.AutoSize = true;
            this.userIDLabel1.Location = new System.Drawing.Point(156, 90);
            this.userIDLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIDLabel1.Name = "userIDLabel1";
            this.userIDLabel1.Size = new System.Drawing.Size(38, 15);
            this.userIDLabel1.TabIndex = 11;
            this.userIDLabel1.Text = "label2";
            this.userIDLabel1.Click += new System.EventHandler(this.order_Click);
            // 
            // orderGetCodeLabel1
            // 
            this.orderGetCodeLabel1.AutoSize = true;
            this.orderGetCodeLabel1.Location = new System.Drawing.Point(156, 111);
            this.orderGetCodeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderGetCodeLabel1.Name = "orderGetCodeLabel1";
            this.orderGetCodeLabel1.Size = new System.Drawing.Size(38, 15);
            this.orderGetCodeLabel1.TabIndex = 13;
            this.orderGetCodeLabel1.Text = "label2";
            this.orderGetCodeLabel1.Click += new System.EventHandler(this.order_Click);
            // 
            // medvedeva_vy_sportDataSet
            // 
            this.medvedeva_vy_sportDataSet.DataSetName = "medvedeva_vy_sportDataSet";
            this.medvedeva_vy_sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderStatusTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.PickupPointTableAdapter = null;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductSupplierTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UnitTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sport.medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(849, 144);
            this.Click += new System.EventHandler(this.order_Click);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private medvedeva_vy_sportDataSet medvedeva_vy_sportDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label orderDeliveryDateLabel1;
        private System.Windows.Forms.Label orderIDLabel1;
        private System.Windows.Forms.Label orderStatusIDLabel1;
        private System.Windows.Forms.Label pickupPointIDLabel1;
        private System.Windows.Forms.Label orderCreateDateLabel1;
        private System.Windows.Forms.Label userIDLabel1;
        private System.Windows.Forms.Label orderGetCodeLabel1;
    }
}
