namespace Sport.AppForms
{
    partial class CreateUpdateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label officeIdLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderIDLabel1 = new System.Windows.Forms.Label();
            this.orderStatusIDComboBox = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medvedeva_vy_sportDataSet = new Sport.medvedeva_vy_sportDataSet();
            this.orderStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pickupPointIDComboBox = new System.Windows.Forms.ComboBox();
            this.pickupPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderCreateDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDeliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.orderTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new Sport.medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager();
            this.orderStatusTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.OrderStatusTableAdapter();
            this.pickupPointTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.PickupPointTableAdapter();
            this.userTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.UserTableAdapter();
            orderIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            officeIdLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(328, 67);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(24, 15);
            orderIDLabel.TabIndex = 47;
            orderIDLabel.Text = "ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(328, 159);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(71, 15);
            orderDateLabel.TabIndex = 60;
            orderDateLabel.Text = "Дата заказа:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(328, 188);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 15);
            label1.TabIndex = 61;
            label1.Text = "Дата доставки заказа:";
            // 
            // officeIdLabel
            // 
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(328, 125);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(125, 15);
            officeIdLabel.TabIndex = 62;
            officeIdLabel.Text = "Адрес пункта выдачи:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(328, 217);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 15);
            label2.TabIndex = 63;
            label2.Text = "Клиент:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(328, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 15);
            label3.TabIndex = 64;
            label3.Text = "Статус заказа:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.splitContainer1.Panel1.Controls.Add(this.buttonBack);
            this.splitContainer1.Panel1.Controls.Add(this.labelTitle);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(orderDateLabel);
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Panel2.Controls.Add(officeIdLabel);
            this.splitContainer1.Panel2.Controls.Add(label2);
            this.splitContainer1.Panel2.Controls.Add(label3);
            this.splitContainer1.Panel2.Controls.Add(orderIDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.orderIDLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.orderStatusIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.pickupPointIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.orderCreateDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.orderDeliveryDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.userIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 573);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonBack.Location = new System.Drawing.Point(870, 25);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 35);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(174, 36);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(81, 15);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "ООО «Спорт»";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sport.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // orderIDLabel1
            // 
            this.orderIDLabel1.AutoSize = true;
            this.orderIDLabel1.Location = new System.Drawing.Point(469, 67);
            this.orderIDLabel1.Name = "orderIDLabel1";
            this.orderIDLabel1.Size = new System.Drawing.Size(15, 15);
            this.orderIDLabel1.TabIndex = 48;
            this.orderIDLabel1.Text = "--";
            // 
            // orderStatusIDComboBox
            // 
            this.orderStatusIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderStatusID", true));
            this.orderStatusIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OrderStatusID", true));
            this.orderStatusIDComboBox.DataSource = this.orderStatusBindingSource;
            this.orderStatusIDComboBox.DisplayMember = "OrderStatusName";
            this.orderStatusIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderStatusIDComboBox.FormattingEnabled = true;
            this.orderStatusIDComboBox.Location = new System.Drawing.Point(469, 93);
            this.orderStatusIDComboBox.Name = "orderStatusIDComboBox";
            this.orderStatusIDComboBox.Size = new System.Drawing.Size(200, 23);
            this.orderStatusIDComboBox.TabIndex = 50;
            this.orderStatusIDComboBox.ValueMember = "OrderStatusID";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // medvedeva_vy_sportDataSet
            // 
            this.medvedeva_vy_sportDataSet.DataSetName = "medvedeva_vy_sportDataSet";
            this.medvedeva_vy_sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderStatusBindingSource
            // 
            this.orderStatusBindingSource.DataMember = "OrderStatus";
            this.orderStatusBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // pickupPointIDComboBox
            // 
            this.pickupPointIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "PickupPointID", true));
            this.pickupPointIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "PickupPointID", true));
            this.pickupPointIDComboBox.DataSource = this.pickupPointBindingSource;
            this.pickupPointIDComboBox.DisplayMember = "Address";
            this.pickupPointIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickupPointIDComboBox.FormattingEnabled = true;
            this.pickupPointIDComboBox.Location = new System.Drawing.Point(469, 122);
            this.pickupPointIDComboBox.Name = "pickupPointIDComboBox";
            this.pickupPointIDComboBox.Size = new System.Drawing.Size(200, 23);
            this.pickupPointIDComboBox.TabIndex = 52;
            this.pickupPointIDComboBox.ValueMember = "PickupPointID";
            // 
            // pickupPointBindingSource
            // 
            this.pickupPointBindingSource.DataMember = "PickupPoint";
            this.pickupPointBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // orderCreateDateDateTimePicker
            // 
            this.orderCreateDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderCreateDate", true));
            this.orderCreateDateDateTimePicker.Location = new System.Drawing.Point(469, 151);
            this.orderCreateDateDateTimePicker.Name = "orderCreateDateDateTimePicker";
            this.orderCreateDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.orderCreateDateDateTimePicker.TabIndex = 54;
            // 
            // orderDeliveryDateDateTimePicker
            // 
            this.orderDeliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDeliveryDate", true));
            this.orderDeliveryDateDateTimePicker.Location = new System.Drawing.Point(469, 180);
            this.orderDeliveryDateDateTimePicker.Name = "orderDeliveryDateDateTimePicker";
            this.orderDeliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.orderDeliveryDateDateTimePicker.TabIndex = 56;
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(469, 209);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(200, 23);
            this.userIDComboBox.TabIndex = 58;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonDelete.Location = new System.Drawing.Point(408, 346);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(178, 31);
            this.buttonDelete.TabIndex = 47;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonSave.Location = new System.Drawing.Point(331, 252);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(338, 31);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            // orderStatusTableAdapter
            // 
            this.orderStatusTableAdapter.ClearBeforeFill = true;
            // 
            // pickupPointTableAdapter
            // 
            this.pickupPointTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // CreateUpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 573);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateUpdateOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUpdateOrderForm";
            this.Load += new System.EventHandler(this.CreateUpdateOrderForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private medvedeva_vy_sportDataSet medvedeva_vy_sportDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label orderIDLabel1;
        private System.Windows.Forms.ComboBox orderStatusIDComboBox;
        private System.Windows.Forms.ComboBox pickupPointIDComboBox;
        private System.Windows.Forms.DateTimePicker orderCreateDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker orderDeliveryDateDateTimePicker;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.BindingSource orderStatusBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.OrderStatusTableAdapter orderStatusTableAdapter;
        private System.Windows.Forms.BindingSource pickupPointBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.PickupPointTableAdapter pickupPointTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.UserTableAdapter userTableAdapter;
    }
}