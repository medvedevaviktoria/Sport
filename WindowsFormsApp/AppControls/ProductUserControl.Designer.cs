namespace Sport.AppControls
{
    partial class ProductUserControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.productDiscountAmountLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOldCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productNameLabel1 = new System.Windows.Forms.Label();
            this.productDescriptionLabel1 = new System.Windows.Forms.Label();
            this.productCostLabel1 = new System.Windows.Forms.Label();
            this.productManufacturerIDLabel1 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productDiscountAmountLabel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(897, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 14;
            this.panel2.Click += new System.EventHandler(this.product_Click);
            // 
            // productDiscountAmountLabel1
            // 
            this.productDiscountAmountLabel1.Location = new System.Drawing.Point(0, 45);
            this.productDiscountAmountLabel1.Name = "productDiscountAmountLabel1";
            this.productDiscountAmountLabel1.Size = new System.Drawing.Size(100, 23);
            this.productDiscountAmountLabel1.TabIndex = 2;
            this.productDiscountAmountLabel1.Text = "%";
            this.productDiscountAmountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productDiscountAmountLabel1.Click += new System.EventHandler(this.product_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер скидки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.product_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelOldCost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productNameLabel1);
            this.panel1.Controls.Add(this.productDescriptionLabel1);
            this.panel1.Controls.Add(this.productCostLabel1);
            this.panel1.Controls.Add(this.productManufacturerIDLabel1);
            this.panel1.Location = new System.Drawing.Point(135, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 100);
            this.panel1.TabIndex = 13;
            this.panel1.Click += new System.EventHandler(this.product_Click);
            // 
            // labelOldCost
            // 
            this.labelOldCost.AutoSize = true;
            this.labelOldCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOldCost.ForeColor = System.Drawing.Color.Red;
            this.labelOldCost.Location = new System.Drawing.Point(136, 80);
            this.labelOldCost.Name = "labelOldCost";
            this.labelOldCost.Size = new System.Drawing.Size(70, 13);
            this.labelOldCost.TabIndex = 12;
            this.labelOldCost.Text = "Старая цена";
            this.labelOldCost.Visible = false;
            this.labelOldCost.Click += new System.EventHandler(this.product_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Производитель:";
            this.label3.Click += new System.EventHandler(this.product_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Цена:";
            this.label2.Click += new System.EventHandler(this.product_Click);
            // 
            // productNameLabel1
            // 
            this.productNameLabel1.AutoSize = true;
            this.productNameLabel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel1.Location = new System.Drawing.Point(9, 9);
            this.productNameLabel1.Name = "productNameLabel1";
            this.productNameLabel1.Size = new System.Drawing.Size(125, 15);
            this.productNameLabel1.TabIndex = 3;
            this.productNameLabel1.Text = "Наименование товара";
            this.productNameLabel1.Click += new System.EventHandler(this.product_Click);
            // 
            // productDescriptionLabel1
            // 
            this.productDescriptionLabel1.AutoSize = true;
            this.productDescriptionLabel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDescriptionLabel1.Location = new System.Drawing.Point(9, 30);
            this.productDescriptionLabel1.Name = "productDescriptionLabel1";
            this.productDescriptionLabel1.Size = new System.Drawing.Size(100, 15);
            this.productDescriptionLabel1.TabIndex = 9;
            this.productDescriptionLabel1.Text = "Описание товара";
            this.productDescriptionLabel1.Click += new System.EventHandler(this.product_Click);
            // 
            // productCostLabel1
            // 
            this.productCostLabel1.AutoSize = true;
            this.productCostLabel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCostLabel1.Location = new System.Drawing.Point(45, 79);
            this.productCostLabel1.Name = "productCostLabel1";
            this.productCostLabel1.Size = new System.Drawing.Size(34, 15);
            this.productCostLabel1.TabIndex = 5;
            this.productCostLabel1.Text = "Цена";
            this.productCostLabel1.Click += new System.EventHandler(this.product_Click);
            // 
            // productManufacturerIDLabel1
            // 
            this.productManufacturerIDLabel1.AutoSize = true;
            this.productManufacturerIDLabel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productManufacturerIDLabel1.Location = new System.Drawing.Point(97, 55);
            this.productManufacturerIDLabel1.Name = "productManufacturerIDLabel1";
            this.productManufacturerIDLabel1.Size = new System.Drawing.Size(92, 15);
            this.productManufacturerIDLabel1.TabIndex = 7;
            this.productManufacturerIDLabel1.Text = "Производитель";
            this.productManufacturerIDLabel1.Click += new System.EventHandler(this.product_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(16, 24);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 12;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.product_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(1011, 148);
            this.Click += new System.EventHandler(this.product_Click);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label productDiscountAmountLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOldCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productNameLabel1;
        private System.Windows.Forms.Label productDescriptionLabel1;
        private System.Windows.Forms.Label productCostLabel1;
        private System.Windows.Forms.Label productManufacturerIDLabel1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}
