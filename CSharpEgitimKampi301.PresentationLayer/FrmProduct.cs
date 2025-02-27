using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi301.BusinessLayer.Abstact;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void txtProductStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            _productService.TDelete(new Product { ProductId = id });
            MessageBox.Show("Silme iþlemi yapýldý");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = txtProductName.Text,
                ProductStock = short.Parse(txtProductStock.Text),
                ProductPrice = decimal.Parse(txtProductPrice.Text),
                ProductDescription = txtProductDescription.Text,
                CategoryId = int.Parse(cmbCategory.SelectedValue.ToString())
            };
            _productService.TInsert(product);
            MessageBox.Show("Ekleme iþlemi yapýldý");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            value.ProductName = txtProductName.Text;
            value.ProductStock = short.Parse(txtProductStock.Text);
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductDescription = txtProductDescription.Text;
            value.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme iþlemi yapýldý");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            txtProductName.Text = value.ProductName;
            txtProductStock.Text = value.ProductStock.ToString();
            txtProductPrice.Text = value.ProductPrice.ToString();
            txtProductDescription.Text = value.ProductDescription;
            cmbCategory.Text = value.CategoryId.ToString();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategory.DataSource = values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = 0;
        }
    }
}
