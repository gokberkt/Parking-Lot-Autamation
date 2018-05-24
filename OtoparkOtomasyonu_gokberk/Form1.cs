using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu_gokberk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OtoparkDBEntities db = new OtoparkDBEntities();
        Records rc = new Records();

        private void btnSave_Click(object sender, EventArgs e)
        {
            rc.TC = txtTC.Text;
            rc.Name = txtName.Text;
            rc.LastName = txtLastName.Text;
            rc.PhoneNumber = txtPhoneNo.Text;
            rc.LicencePlate = txtLicensePlate.Text;
            rc.Brand = txtBrand.Text;
            rc.Model = txtModel.Text;
            rc.Color = txtColor.Text;
            rc.EntryDate = DateTime.Now;
            rc.State = true;


            if (string.IsNullOrWhiteSpace(txtTC.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("TC Kimlik , Ad , Soyad ve Telefon Numarası boş olamaz..!");
                return;
            }
            else
            {
                db.Records.Add(rc);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi !");
                FillListView();
            }
        }
        private void FillListView()
        {
            try
            {
                lwRecords.Items.Clear();
                foreach (Records item in db.Records.Where(x=>x.State==true).ToList())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.ID.ToString();
                    lvi.SubItems.Add(item.TC);
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.LastName);
                    lvi.SubItems.Add(item.PhoneNumber);
                    lvi.SubItems.Add(item.LicencePlate);
                    lvi.SubItems.Add(item.Brand);
                    lvi.SubItems.Add(item.Model);
                    lvi.SubItems.Add(item.Color);
                    lvi.SubItems.Add(item.EntryDate.Value.ToString("dd/MM/yyyy hh:mm"));
                    if (item.LeaveDate != null)
                    {
                        lvi.SubItems.Add(item.LeaveDate.Value.ToString("dd/MM/yyyy hh:mm"));
                    }
                    else
                    {
                        lvi.SubItems.Add("-");
                    }
                    lvi.SubItems.Add(item.State.ToString());
                    lwRecords.Items.Add(lvi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lwRecords.Columns.Add("ID", 0);
            lwRecords.Columns.Add("TC", 150);
            lwRecords.Columns.Add("Ad", 100);
            lwRecords.Columns.Add("Soyad", 100);
            lwRecords.Columns.Add("Telefon", 80);
            lwRecords.Columns.Add("Plaka", 80);
            lwRecords.Columns.Add("Marka", 80);
            lwRecords.Columns.Add("Model", 80);
            lwRecords.Columns.Add("Renk", 50);
            lwRecords.Columns.Add("Giriş Tarihi", 150);
            lwRecords.Columns.Add("Çıkış Tarihi", 150);
            lwRecords.Columns.Add("Statu", 50);
            lwRecords.View = View.Details;
            lwRecords.AllowColumnReorder = true;

            FillListView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lwRecords.SelectedItems.Count==0)
            {
                MessageBox.Show("Araç seçmediniz!");
                return;
            }

            Records rc = db.Records.Find(Convert.ToInt32(lwRecords.SelectedItems[0].Text));
            rc.State = false;
            db.SaveChanges();

            FillListView();
        }
    }
}
