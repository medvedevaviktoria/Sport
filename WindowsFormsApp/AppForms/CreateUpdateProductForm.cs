using Sport.AppModels;
using Sport.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Sport.AppForms
{
    public partial class CreateUpdateProductForm : Form
    {
        private Product _product;
        private string errorMessage; //переменная с сообщением, в чём ошибка валидации(чтобы вывести для пользователя)
        private bool addPhoto = false;//флажок для понимания: добавили мы фото или нет
        private string _newPhotoFileName = null;
        public CreateUpdateProductForm()
        {
            InitializeComponent();
            _product = new Product();
            labelTitle.Text = "ООО «Спорт» - Добавление товара";
            this.Text = "ООО «Спорт» - Добавление товара";
        }

        public CreateUpdateProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
            labelTitle.Text = "ООО «Спорт» - Редактирование товара";
            this.Text = "ООО «Спорт» - Редактирование товара";
            productArticleNumberTextBox.Enabled = false;
            buttonDelete.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (addPhoto && _newPhotoFileName != null)
            {
                DeletePhoto(_newPhotoFileName);
            }
            this.Close();
        }

        private void CreateUpdateProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.ProductCategory". При необходимости она может быть перемещена или удалена.
            this.productCategoryTableAdapter.Fill(this.medvedeva_vy_sportDataSet.ProductCategory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.ProductSupplier". При необходимости она может быть перемещена или удалена.
            this.productSupplierTableAdapter.Fill(this.medvedeva_vy_sportDataSet.ProductSupplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.ProductManufacturer". При необходимости она может быть перемещена или удалена.
            this.productManufacturerTableAdapter.Fill(this.medvedeva_vy_sportDataSet.ProductManufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.UnitType". При необходимости она может быть перемещена или удалена.
            this.unitTypeTableAdapter.Fill(this.medvedeva_vy_sportDataSet.UnitType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.ProductName". При необходимости она может быть перемещена или удалена.
            this.productNameTableAdapter.Fill(this.medvedeva_vy_sportDataSet.ProductName);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_sportDataSet.Product". При необходимости она может быть перемещена или удалена.
            //this.productTableAdapter.Fill(this.medvedeva_vy_sportDataSet.Product);

            productDiscountAmountNumericUpDown.Maximum = (int)_product.ProductMaxDiscountAmount;
            if (_product.IsNew())
            {
                productNameIdComboBox.SelectedIndex = 0;
                unitTypeIDComboBox.SelectedIndex = 0;
                productManufacturerIDComboBox.SelectedIndex = 0;
                productSupplierIDComboBox.SelectedIndex = 0;
                productCategoryIDComboBox.SelectedIndex = 0;
            }
            else
            {
                FillForm();
            }
        }

        private void FillForm()
        {
            productArticleNumberTextBox.Text = _product.ProductArticleNumber;
            productNameIdComboBox.SelectedValue = _product.ProductNameId;
            unitTypeIDComboBox.SelectedValue = _product.UnitTypeID;
            productCostNumericUpDown.Text = _product.ProductCost.ToString();
            productMaxDiscountAmountNumericUpDown.Value = (decimal)_product.ProductMaxDiscountAmount;
            productManufacturerIDComboBox.SelectedValue = _product.ProductManufacturerID;
            productSupplierIDComboBox.SelectedValue = _product.ProductSupplierID;
            productCategoryIDComboBox.SelectedValue = _product.ProductCategoryID;
            productDiscountAmountNumericUpDown.Value = (decimal)_product.ProductDiscountAmount;
            productQuantityInStockNumericUpDown.Value = _product.ProductQuantityInStock;
            productDescriptionTextBox.Text = _product.ProductDescription;
            productPhotoTextBox.Text = _product.ProductPhoto;
        }

        private void FillModelFields()
        {
            _product.ProductArticleNumber = productArticleNumberTextBox.Text;
            _product.ProductNameId = (int)productNameIdComboBox.SelectedValue;
            _product.UnitTypeID = (int)unitTypeIDComboBox.SelectedValue;
            //float.TryParse(productCostTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float val);
            //_product.ProductCost = Math.Round(val, 2);
            _product.ProductCost = Math.Round((float)productCostNumericUpDown.Value, 2);
            _product.ProductMaxDiscountAmount= (int)productMaxDiscountAmountNumericUpDown.Value;
            _product.ProductManufacturerID= (int)productManufacturerIDComboBox.SelectedValue;
            _product.ProductSupplierID= (int)productSupplierIDComboBox.SelectedValue;
            _product.ProductCategoryID= (int)productCategoryIDComboBox.SelectedValue;
            _product.ProductDiscountAmount = (float)productDiscountAmountNumericUpDown.Value;
            _product.ProductQuantityInStock = (int)productQuantityInStockNumericUpDown.Value;
            _product.ProductDescription = productDescriptionTextBox.Text;
            _product.ProductPhoto = productPhotoTextBox.Text;
        }

        /// <summary>
        /// Валидация данных
        /// </summary>
        private bool ValidateInfo()
        {
            //проверка на пустые поля
            if (string.IsNullOrEmpty(productArticleNumberTextBox.Text))
            {
                errorMessage = "Поля не могут быть пустыми.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Сохранение продукта
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInfo())
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string oldPhoto = _product.ProductPhoto; // запомнили старое название фото

                FillModelFields();
                if (_product.IsNew())
                {
                    Program.context.Products.Add(_product);
                }
                Program.context.SaveChanges();

                // сохранилось успешно - удаляем старое фото
                if (addPhoto && !string.IsNullOrEmpty(oldPhoto))
                {
                    DeletePhoto(oldPhoto);  // удаляем старое
                }

                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // при ошибке сохранения - удаляем новое фото
                if (addPhoto && !string.IsNullOrEmpty(_newPhotoFileName))
                {
                    DeletePhoto(_newPhotoFileName);
                }
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Установка максимума скидки
        /// </summary>
        private void productMaxDiscountAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (productMaxDiscountAmountNumericUpDown.Value > productDiscountAmountNumericUpDown.Maximum)
            {
                productDiscountAmountNumericUpDown.Maximum = productMaxDiscountAmountNumericUpDown.Value;
            }
            else if (productMaxDiscountAmountNumericUpDown.Value < productDiscountAmountNumericUpDown.Value)
            {
                productDiscountAmountNumericUpDown.Maximum = productMaxDiscountAmountNumericUpDown.Value;
                productDiscountAmountNumericUpDown.Value = productDiscountAmountNumericUpDown.Maximum;
                
            }
        }

        /// <summary>
        /// Кнопка добавления фотографии
        /// </summary>
        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображения (*.jpg; *.jpeg)|*.jpg;*.jpeg";

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _newPhotoFileName = SaveImageFromDialog(openFileDialog1.FileName);
                productPhotoTextBox.Text = _newPhotoFileName;
                addPhoto = true;
            }
        }

        /// <summary>
        /// Сохранение изображения
        /// </summary>
        private string SaveImageFromDialog(string sourcePath)
        {
            Image originalImage = Image.FromFile(sourcePath);

            Size newImageSize = GetNewImageSize(originalImage);

            // PKGH Создаем изображение не более максимальных размеров.
            Bitmap resizedImage = new Bitmap(originalImage, newImageSize.Width, newImageSize.Height);
            string fileName = Guid.NewGuid().ToString().Substring(0, 8) + ".jpg"; // PKGH Генерация уникального имени файла. Длина - 8 символов.
            string savePath = GetImagePath(fileName);

            // PKGH Сохраняем изображение
            resizedImage.Save(savePath);

            // PKGH Освобождаем ресурсы
            originalImage.Dispose();
            resizedImage.Dispose();

            return fileName;
        }

        /// <summary>
        /// Получение размера изображения
        /// </summary>
        private Size GetNewImageSize(Image originalImage)
        {
            int maxWidth = 300;
            int maxHeight = 200;

            float ratioX = (float)maxWidth / originalImage.Width;
            float ratioY = (float)maxHeight / originalImage.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            return new Size(newWidth, newHeight);
        }

        /// <summary>
        /// Получение полного пути изображения
        /// </summary>
        public static string GetImagePath(string fileName)
        {
            return Path.Combine(Application.StartupPath, "img", fileName);
        }

        /// <summary>
        /// Удаление фотографии продукта
        /// </summary>
        private void DeletePhoto(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    File.Delete(GetImagePath(fileName));
                }
                catch (Exception ex)
                {
                    Debug.Print($"Не удалось удалить файл {fileName}: {ex.Message}"); // PKGH Отладочная печать.
                }
            }
        }

        /// <summary>
        /// Удаление продукта
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (toBeDeleted == DialogResult.OK)
            {
                Product product = Program.context.Products.Where(p => p.ProductId == _product.ProductId).FirstOrDefault();

                try
                {
                    string oldPhoto = _product.ProductPhoto; // запомнили старое
                    Program.context.Products.Remove(_product);
                    Program.context.SaveChanges();
                    ContextManager.productForm.RefreshList();

                    // после успешного удаления из БД - удаляем фото
                    if (!string.IsNullOrEmpty(oldPhoto))
                    {
                        DeletePhoto(oldPhoto);
                    }
                    // если было выбрано новое фото - удаляем и его
                    if (addPhoto && !string.IsNullOrEmpty(_newPhotoFileName))
                    {
                        DeletePhoto(_newPhotoFileName);
                    }

                    DialogResult = DialogResult.OK;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Товар заказан. Его нельзя удалить.", "Товар заказан. Его нельзя удалить.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
