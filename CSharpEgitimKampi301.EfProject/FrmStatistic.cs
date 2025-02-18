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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistic_Load(object sender, EventArgs e)
        {

            lblLocation.Text = db.LocationTbl.Count().ToString();

            lblCapasity.Text = db.LocationTbl.Sum(x => x.LocationCapacity).ToString();

            label5.Text = db.GuideTbl.Count().ToString();

            lblAvgCapasity.Text = String.Format("{0:0.00}", db.LocationTbl.Average(x => x.LocationCapacity), 2);

            label13.Text = String.Format("{0:0.00}", db.LocationTbl.Average(x => x.LocationPrice), 2) + "TL";

            lblLastCountry.Text = db.LocationTbl.OrderByDescending(x => x.LocationID).FirstOrDefault().LocationCountry;

            lblTokyoCapacity.Text = db.LocationTbl.Where(x => x.LocationCity == "Tokyo").Sum(x => x.LocationCapacity).ToString();

            lblTurkeyAvgCapacity.Text = String.Format("{0:0.00}", db.LocationTbl.Where(x => x.LocationCountry == "Türkiye").Average(x => x.LocationCapacity), 2);
            
            //Santa Cruz turundaki rehberlerin isimlerini getir
            int santaCruzID = db.LocationTbl.Where(x => x.LocationCity == "Santa Cruz").FirstOrDefault().LocationID;
            lblSCGuideName.Text = db.GuideTbl.Where(x => x.GuideID == santaCruzID)
                .Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            lblMaxCapacityLocation.Text = db.LocationTbl.OrderByDescending(x => x.LocationCapacity).FirstOrDefault().LocationCity;

            lblMaxPriceLocation.Text = db.LocationTbl.OrderByDescending(x => x.LocationPrice).FirstOrDefault().LocationCity;

            //Selda Baðcan'ýn rehber olduðu þehirler Sayýsý
            int seldaID = db.GuideTbl.Where(x => x.GuideName == "Selda" && x.GuideSurname == "Baðcan").FirstOrDefault().GuideID;
            label7.Text = db.LocationTbl.Where(x => x.GuideId == seldaID).Count().ToString();

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
