using Sport.AppForms;
using Sport.AppModels;
using Sport.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport.AppControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;
        public ProductUserControl(Product product)
        {
            InitializeComponent();
            _product = product;
            SetProductInfo();
            HighlightGreatDiscount();
            HighlightAbsent();
        }

        private void HighlightAbsent()
        {
            if (_product.ProductQuantityInStock == 0)
            {
                this.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        private void HighlightGreatDiscount()
        {
            //скидка более 15
            if (_product.ProductDiscountAmount >= 15) 
            { 
                this.BackColor = ColorTranslator.FromHtml("#7fff00"); 
            }

        }

        public void SetProductInfo()
        {
            productNameLabel1.Text = _product.ProductName.ProductName1;
            productDescriptionLabel1.Text = _product.ProductDescription;
            productManufacturerIDLabel1.Text = _product.ProductManufacturer.ProductManufacturerName;
            productDiscountAmountLabel1.Text = $"{_product.ProductDiscountAmount} %";
            pictureBoxImage.Image = GetImage();
            
            //проверка на количество действующей скидки
            if (_product.ProductDiscountAmount != 0)
            {
                labelOldCost.Text = $"{_product.ProductCost} руб.";
                labelOldCost.Visible = true;
                productCostLabel1.Text = $"{(_product.ProductCost * ((100 - _product.ProductDiscountAmount) / 100))} руб.";
            }
            else productCostLabel1.Text = $"{_product.ProductCost} руб.";
        }

        private Image GetImage()
        {
            Image img;
            try
            {
                img = new Bitmap(Image.FromFile(Path.Combine(Application.StartupPath, "img", $"{_product.ProductPhoto}")));
            }
            catch (FileNotFoundException)
            {
                img = Image.FromFile(Path.Combine(Application.StartupPath, "img", "picture.png"));
            }
            return img;
        }

        private void product_Click(object sender, EventArgs e)
        {
            //если пользователь АВТОРИЗОВАН(т.е. НЕ ГОСТЬ) -> проводим проверку, является ли он администратором
            if (ContextManager.user != null)
            {
                //если пользователь авторизован, но НЕ АДМИН -> ничего не происходит
                if (!ContextManager.user.IsAdmin())
                {
                    return;
                }
            }
            else//если пользователь НЕАВТОРИЗОВАН
            {
                return;
            }

                //если админ -> переходим к форме редактирования продукта
                CreateUpdateProductForm createUpdateProductForm = new CreateUpdateProductForm(_product);
            DialogResult saved = createUpdateProductForm.ShowDialog();

            //если товар отредактирован -> обновляем список на форме продуктов
            if (saved == DialogResult.OK)
            {
                ContextManager.productForm.RefreshList();
            }
        }
    }
}
