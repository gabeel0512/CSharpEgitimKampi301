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
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory: Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var category = _categoryService.TGetById(id);
            _categoryService.TDelete(category);
            MessageBox.Show("Kategori Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var updatedCategory = _categoryService.TGetById(id);
            updatedCategory.CategoryName = txtCategoryName.Text;
            updatedCategory.CategoryStatus = true;
            _categoryService.TUpdate(updatedCategory);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var category = _categoryService.TGetById(id);
            dataGridView1.DataSource = category;
        }
    }
}
