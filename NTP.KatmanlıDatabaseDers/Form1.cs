using Katmanlı.BLL;
using Katmanlı.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP.KatmanlıDatabaseDers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            OgrenciBL obl = new OgrenciBL();
            try
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ad = txtAd.Text.Trim();
                ogrenci.Soyad = txtSoyad.Text.Trim();
                ogrenci.Numara = txtNumara.Text.Trim();
                MessageBox.Show(obl.OgrenciEkle(ogrenci) ? "Başarılı" : "Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 245:
                        MessageBox.Show("Numara girişinde hata");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası!" + ex.Number);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu..");
            }
            finally
            {
                obl.Dispose();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
                frmOgrenciAra frm = new frmOgrenciAra(this);
                frm.Show();
           
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

