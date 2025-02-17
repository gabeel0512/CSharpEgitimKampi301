using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EfProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void RehberId_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.GuideTbl.Select(x => new 
            {
                fullName = x.GuideName + " " + x.GuideSurname, x.GuideID
            }).ToList();
            cmbGuide.DisplayMember= "fullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.LocationTbl.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LocationTbl location = new LocationTbl();
            location.LocationCity = txtLocationCity.Text;
            location.LocationCountry = txtLocationCountry.Text;
            location.LocationCapacity =byte.Parse( nudLocationCapacity.Value.ToString());
            location.LocationPrice = decimal.Parse(txtLocationPrice.Text);
            location.DayNight = txtLocationDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.LocationTbl.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Eklendi !");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var location = db.LocationTbl.Find(id);
            db.LocationTbl.Remove(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Silindi !");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var location = db.LocationTbl.Find(id);
            location.LocationCity = txtLocationCity.Text;
            location.LocationCountry = txtLocationCountry.Text;
            location.LocationCapacity = byte.Parse(nudLocationCapacity.Value.ToString());
            location.LocationPrice = decimal.Parse(txtLocationPrice.Text);
            location.DayNight = txtLocationDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon Güncellendi !");
        }
    }
}
