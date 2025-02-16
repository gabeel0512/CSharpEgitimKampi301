using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace CSharpEgitimKampi301.EfProject
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'egitimKampiEfTravelDbDataSet.GuideTbl' table. You can move, or remove it, as needed.
            this.guideTblTableAdapter.Fill(this.egitimKampiEfTravelDbDataSet.GuideTbl);

        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.GuideTbl.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GuideTbl guide = new GuideTbl();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.GuideTbl.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Baþarýyla Eklendi ");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var value = db.GuideTbl.Find(id);
            db.GuideTbl.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Rehber Baþarýyla Silindi ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var value = db.GuideTbl.Find(id);
            value.GuideName = txtName.Text;
            value.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Baþarýyla Güncellendi ","Uyarý" ,MessageBoxButton.OK , MessageBoxImage.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var value = db.GuideTbl.Where(x => x.GuideID == id).ToList();
            dataGridView1.DataSource = value;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
