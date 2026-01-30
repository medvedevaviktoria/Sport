namespace Sport.AppForms
{
    partial class CreateUpdateProductForm
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
            System.Windows.Forms.Label articleLabel;
            System.Windows.Forms.Label productNameIdLabel;
            System.Windows.Forms.Label unitOfMeasureIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label maxProductDiscountAmountLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medvedeva_vy_sportDataSet = new Sport.medvedeva_vy_sportDataSet();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.productArticleNumberTextBox = new System.Windows.Forms.TextBox();
            this.productNameIdComboBox = new System.Windows.Forms.ComboBox();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.unitTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productMaxDiscountAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productManufacturerIDComboBox = new System.Windows.Forms.ComboBox();
            this.productManufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.productSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDiscountAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productQuantityInStockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productPhotoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.productTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Sport.medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager();
            this.productNameTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.ProductNameTableAdapter();
            this.unitTypeTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.UnitTypeTableAdapter();
            this.productManufacturerTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.ProductManufacturerTableAdapter();
            this.productSupplierTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.ProductSupplierTableAdapter();
            this.productCategoryTableAdapter = new Sport.medvedeva_vy_sportDataSetTableAdapters.ProductCategoryTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            articleLabel = new System.Windows.Forms.Label();
            productNameIdLabel = new System.Windows.Forms.Label();
            unitOfMeasureIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            maxProductDiscountAmountLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaxDiscountAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDiscountAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityInStockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // articleLabel
            // 
            articleLabel.AutoSize = true;
            articleLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            articleLabel.Location = new System.Drawing.Point(269, 42);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(68, 19);
            articleLabel.TabIndex = 34;
            articleLabel.Text = "Артикул:";
            // 
            // productNameIdLabel
            // 
            productNameIdLabel.AutoSize = true;
            productNameIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            productNameIdLabel.Location = new System.Drawing.Point(269, 72);
            productNameIdLabel.Name = "productNameIdLabel";
            productNameIdLabel.Size = new System.Drawing.Size(160, 19);
            productNameIdLabel.TabIndex = 35;
            productNameIdLabel.Text = "Наименование товара:";
            // 
            // unitOfMeasureIdLabel
            // 
            unitOfMeasureIdLabel.AutoSize = true;
            unitOfMeasureIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            unitOfMeasureIdLabel.Location = new System.Drawing.Point(269, 104);
            unitOfMeasureIdLabel.Name = "unitOfMeasureIdLabel";
            unitOfMeasureIdLabel.Size = new System.Drawing.Size(148, 19);
            unitOfMeasureIdLabel.TabIndex = 36;
            unitOfMeasureIdLabel.Text = "Единица измерения:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            priceLabel.Location = new System.Drawing.Point(269, 131);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 19);
            priceLabel.TabIndex = 37;
            priceLabel.Text = "Цена:";
            // 
            // maxProductDiscountAmountLabel
            // 
            maxProductDiscountAmountLabel.AutoSize = true;
            maxProductDiscountAmountLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            maxProductDiscountAmountLabel.Location = new System.Drawing.Point(269, 160);
            maxProductDiscountAmountLabel.Name = "maxProductDiscountAmountLabel";
            maxProductDiscountAmountLabel.Size = new System.Drawing.Size(280, 19);
            maxProductDiscountAmountLabel.TabIndex = 38;
            maxProductDiscountAmountLabel.Text = "Размер максимально возможной скидки:";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            manufacturerIdLabel.Location = new System.Drawing.Point(269, 191);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(119, 19);
            manufacturerIdLabel.TabIndex = 39;
            manufacturerIdLabel.Text = "Производитель:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            supplierIdLabel.Location = new System.Drawing.Point(269, 219);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(89, 19);
            supplierIdLabel.TabIndex = 40;
            supplierIdLabel.Text = "Поставщик:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            categoryIdLabel.Location = new System.Drawing.Point(269, 250);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(129, 19);
            categoryIdLabel.TabIndex = 41;
            categoryIdLabel.Text = "Категория товара:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            discountLabel.Location = new System.Drawing.Point(269, 281);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(156, 19);
            discountLabel.TabIndex = 42;
            discountLabel.Text = "Действующая скидка:";
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            productQuantityInStockLabel.Location = new System.Drawing.Point(269, 313);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(128, 19);
            productQuantityInStockLabel.TabIndex = 43;
            productQuantityInStockLabel.Text = "Кол-во на складе:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            descriptionLabel.Location = new System.Drawing.Point(269, 344);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(81, 19);
            descriptionLabel.TabIndex = 44;
            descriptionLabel.Text = "Описание:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            photoLabel.Location = new System.Drawing.Point(269, 374);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(101, 19);
            photoLabel.TabIndex = 45;
            photoLabel.Text = "Изображение:";
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
            this.splitContainer1.Panel2.Controls.Add(this.productCostNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel2.Controls.Add(this.buttonOpenFileDialog);
            this.splitContainer1.Panel2.Controls.Add(articleLabel);
            this.splitContainer1.Panel2.Controls.Add(productNameIdLabel);
            this.splitContainer1.Panel2.Controls.Add(unitOfMeasureIdLabel);
            this.splitContainer1.Panel2.Controls.Add(priceLabel);
            this.splitContainer1.Panel2.Controls.Add(maxProductDiscountAmountLabel);
            this.splitContainer1.Panel2.Controls.Add(manufacturerIdLabel);
            this.splitContainer1.Panel2.Controls.Add(supplierIdLabel);
            this.splitContainer1.Panel2.Controls.Add(categoryIdLabel);
            this.splitContainer1.Panel2.Controls.Add(discountLabel);
            this.splitContainer1.Panel2.Controls.Add(productQuantityInStockLabel);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.productArticleNumberTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.productNameIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.unitTypeIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.productMaxDiscountAmountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.productManufacturerIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.productSupplierIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.productCategoryIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.productDiscountAmountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.productQuantityInStockNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.productDescriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.productPhotoTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 690);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
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
            // productCostNumericUpDown
            // 
            this.productCostNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ProductCost", true));
            this.productCostNumericUpDown.DecimalPlaces = 2;
            this.productCostNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.productCostNumericUpDown.Location = new System.Drawing.Point(556, 127);
            this.productCostNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.productCostNumericUpDown.Name = "productCostNumericUpDown";
            this.productCostNumericUpDown.Size = new System.Drawing.Size(239, 26);
            this.productCostNumericUpDown.TabIndex = 48;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // medvedeva_vy_sportDataSet
            // 
            this.medvedeva_vy_sportDataSet.DataSetName = "medvedeva_vy_sportDataSet";
            this.medvedeva_vy_sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonDelete.Location = new System.Drawing.Point(443, 481);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(178, 31);
            this.buttonDelete.TabIndex = 47;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(704, 371);
            this.buttonOpenFileDialog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(91, 26);
            this.buttonOpenFileDialog.TabIndex = 46;
            this.buttonOpenFileDialog.Text = "Файл";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = false;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // productArticleNumberTextBox
            // 
            this.productArticleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductArticleNumber", true));
            this.productArticleNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productArticleNumberTextBox.Location = new System.Drawing.Point(556, 35);
            this.productArticleNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productArticleNumberTextBox.Name = "productArticleNumberTextBox";
            this.productArticleNumberTextBox.Size = new System.Drawing.Size(239, 26);
            this.productArticleNumberTextBox.TabIndex = 11;
            // 
            // productNameIdComboBox
            // 
            this.productNameIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductNameId", true));
            this.productNameIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductNameId", true));
            this.productNameIdComboBox.DataSource = this.productNameBindingSource;
            this.productNameIdComboBox.DisplayMember = "ProductName";
            this.productNameIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameIdComboBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameIdComboBox.FormattingEnabled = true;
            this.productNameIdComboBox.Location = new System.Drawing.Point(556, 65);
            this.productNameIdComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productNameIdComboBox.Name = "productNameIdComboBox";
            this.productNameIdComboBox.Size = new System.Drawing.Size(239, 26);
            this.productNameIdComboBox.TabIndex = 13;
            this.productNameIdComboBox.ValueMember = "ProductNameId";
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // unitTypeIDComboBox
            // 
            this.unitTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "UnitTypeID", true));
            this.unitTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "UnitTypeID", true));
            this.unitTypeIDComboBox.DataSource = this.unitTypeBindingSource;
            this.unitTypeIDComboBox.DisplayMember = "UnitTypeName";
            this.unitTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitTypeIDComboBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitTypeIDComboBox.FormattingEnabled = true;
            this.unitTypeIDComboBox.Location = new System.Drawing.Point(556, 97);
            this.unitTypeIDComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitTypeIDComboBox.Name = "unitTypeIDComboBox";
            this.unitTypeIDComboBox.Size = new System.Drawing.Size(239, 26);
            this.unitTypeIDComboBox.TabIndex = 15;
            this.unitTypeIDComboBox.ValueMember = "UnitTypeID";
            // 
            // unitTypeBindingSource
            // 
            this.unitTypeBindingSource.DataMember = "UnitType";
            this.unitTypeBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // productMaxDiscountAmountNumericUpDown
            // 
            this.productMaxDiscountAmountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ProductMaxDiscountAmount", true));
            this.productMaxDiscountAmountNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productMaxDiscountAmountNumericUpDown.Location = new System.Drawing.Point(556, 158);
            this.productMaxDiscountAmountNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productMaxDiscountAmountNumericUpDown.Name = "productMaxDiscountAmountNumericUpDown";
            this.productMaxDiscountAmountNumericUpDown.ReadOnly = true;
            this.productMaxDiscountAmountNumericUpDown.Size = new System.Drawing.Size(240, 26);
            this.productMaxDiscountAmountNumericUpDown.TabIndex = 19;
            this.productMaxDiscountAmountNumericUpDown.ValueChanged += new System.EventHandler(this.productMaxDiscountAmountNumericUpDown_ValueChanged);
            // 
            // productManufacturerIDComboBox
            // 
            this.productManufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductManufacturerID", true));
            this.productManufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductManufacturerID", true));
            this.productManufacturerIDComboBox.DataSource = this.productManufacturerBindingSource;
            this.productManufacturerIDComboBox.DisplayMember = "ProductManufacturerName";
            this.productManufacturerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productManufacturerIDComboBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productManufacturerIDComboBox.FormattingEnabled = true;
            this.productManufacturerIDComboBox.Location = new System.Drawing.Point(556, 188);
            this.productManufacturerIDComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productManufacturerIDComboBox.Name = "productManufacturerIDComboBox";
            this.productManufacturerIDComboBox.Size = new System.Drawing.Size(239, 26);
            this.productManufacturerIDComboBox.TabIndex = 21;
            this.productManufacturerIDComboBox.ValueMember = "ProductManufacturerID";
            // 
            // productManufacturerBindingSource
            // 
            this.productManufacturerBindingSource.DataMember = "ProductManufacturer";
            this.productManufacturerBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // productSupplierIDComboBox
            // 
            this.productSupplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductSupplierID", true));
            this.productSupplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductSupplierID", true));
            this.productSupplierIDComboBox.DataSource = this.productSupplierBindingSource;
            this.productSupplierIDComboBox.DisplayMember = "ProductSupplierName";
            this.productSupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productSupplierIDComboBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productSupplierIDComboBox.FormattingEnabled = true;
            this.productSupplierIDComboBox.Location = new System.Drawing.Point(556, 219);
            this.productSupplierIDComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productSupplierIDComboBox.Name = "productSupplierIDComboBox";
            this.productSupplierIDComboBox.Size = new System.Drawing.Size(239, 26);
            this.productSupplierIDComboBox.TabIndex = 23;
            this.productSupplierIDComboBox.ValueMember = "ProductSupplierID";
            // 
            // productSupplierBindingSource
            // 
            this.productSupplierBindingSource.DataMember = "ProductSupplier";
            this.productSupplierBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // productCategoryIDComboBox
            // 
            this.productCategoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCategoryID", true));
            this.productCategoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductCategoryID", true));
            this.productCategoryIDComboBox.DataSource = this.productCategoryBindingSource;
            this.productCategoryIDComboBox.DisplayMember = "ProductCategoryName";
            this.productCategoryIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoryIDComboBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategoryIDComboBox.FormattingEnabled = true;
            this.productCategoryIDComboBox.Location = new System.Drawing.Point(556, 250);
            this.productCategoryIDComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productCategoryIDComboBox.Name = "productCategoryIDComboBox";
            this.productCategoryIDComboBox.Size = new System.Drawing.Size(239, 26);
            this.productCategoryIDComboBox.TabIndex = 25;
            this.productCategoryIDComboBox.ValueMember = "ProductCategoryID";
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.medvedeva_vy_sportDataSet;
            // 
            // productDiscountAmountNumericUpDown
            // 
            this.productDiscountAmountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ProductDiscountAmount", true));
            this.productDiscountAmountNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDiscountAmountNumericUpDown.Location = new System.Drawing.Point(556, 281);
            this.productDiscountAmountNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productDiscountAmountNumericUpDown.Name = "productDiscountAmountNumericUpDown";
            this.productDiscountAmountNumericUpDown.ReadOnly = true;
            this.productDiscountAmountNumericUpDown.Size = new System.Drawing.Size(240, 26);
            this.productDiscountAmountNumericUpDown.TabIndex = 27;
            // 
            // productQuantityInStockNumericUpDown
            // 
            this.productQuantityInStockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ProductQuantityInStock", true));
            this.productQuantityInStockNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQuantityInStockNumericUpDown.Location = new System.Drawing.Point(556, 311);
            this.productQuantityInStockNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productQuantityInStockNumericUpDown.Name = "productQuantityInStockNumericUpDown";
            this.productQuantityInStockNumericUpDown.ReadOnly = true;
            this.productQuantityInStockNumericUpDown.Size = new System.Drawing.Size(240, 26);
            this.productQuantityInStockNumericUpDown.TabIndex = 29;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDescription", true));
            this.productDescriptionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDescriptionTextBox.Location = new System.Drawing.Point(556, 341);
            this.productDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(239, 26);
            this.productDescriptionTextBox.TabIndex = 31;
            // 
            // productPhotoTextBox
            // 
            this.productPhotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductPhoto", true));
            this.productPhotoTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPhotoTextBox.Location = new System.Drawing.Point(556, 371);
            this.productPhotoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productPhotoTextBox.Name = "productPhotoTextBox";
            this.productPhotoTextBox.ReadOnly = true;
            this.productPhotoTextBox.Size = new System.Drawing.Size(140, 26);
            this.productPhotoTextBox.TabIndex = 33;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonSave.Location = new System.Drawing.Point(273, 416);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(522, 31);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderStatusTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickupPointTableAdapter = null;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductSupplierTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UnitTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sport.medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // unitTypeTableAdapter
            // 
            this.unitTypeTableAdapter.ClearBeforeFill = true;
            // 
            // productManufacturerTableAdapter
            // 
            this.productManufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // productSupplierTableAdapter
            // 
            this.productSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 690);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateUpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО «Спорт»";
            this.Load += new System.EventHandler(this.CreateUpdateProductForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaxDiscountAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDiscountAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityInStockNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private medvedeva_vy_sportDataSet medvedeva_vy_sportDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private medvedeva_vy_sportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productArticleNumberTextBox;
        private System.Windows.Forms.ComboBox productNameIdComboBox;
        private System.Windows.Forms.ComboBox unitTypeIDComboBox;
        private System.Windows.Forms.NumericUpDown productMaxDiscountAmountNumericUpDown;
        private System.Windows.Forms.ComboBox productManufacturerIDComboBox;
        private System.Windows.Forms.ComboBox productSupplierIDComboBox;
        private System.Windows.Forms.ComboBox productCategoryIDComboBox;
        private System.Windows.Forms.NumericUpDown productDiscountAmountNumericUpDown;
        private System.Windows.Forms.NumericUpDown productQuantityInStockNumericUpDown;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productPhotoTextBox;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.BindingSource unitTypeBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.UnitTypeTableAdapter unitTypeTableAdapter;
        private System.Windows.Forms.BindingSource productManufacturerBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.ProductManufacturerTableAdapter productManufacturerTableAdapter;
        private System.Windows.Forms.BindingSource productSupplierBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.ProductSupplierTableAdapter productSupplierTableAdapter;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private medvedeva_vy_sportDataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown productCostNumericUpDown;
    }
}