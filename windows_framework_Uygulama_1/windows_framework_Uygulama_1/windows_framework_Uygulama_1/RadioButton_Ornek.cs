using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_framework_Uygulama_1
{
    public partial class RadioButton_Ornek : Form
    {
        public RadioButton_Ornek()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double tutar = 0, fiyat = 0;
            if (string.IsNullOrEmpty(txtFiyat.Text)) 
            {
                lblBilgi.Text = "Fiyatı Boş Bırakmayınız";
                lblBilgi.ForeColor = Color.Red;
                txtFiyat.Focus();
                return;
            }

            try
            {
                fiyat=double.Parse(txtFiyat.Text);
            }
            catch 
            {
                lblBilgi.Text = "Geçerli Bir Değer Giriniz ";
                lblBilgi.ForeColor= Color.Red;
                txtFiyat.Clear();
                txtFiyat.Focus();
                return;
            }

            if (radioButton1.Checked)
            {

                lblBilgi.Text = "Tutar = " + fiyat;
                lblBilgi.ForeColor = Color.Green;
            }
            else if (radioButton2.Checked)
            {
                tutar = fiyat - (fiyat * 0.15);
                lblBilgi.Text = "Tutar = " + tutar;
                lblBilgi.ForeColor = Color.Green;
            }
            else if (radioButton3.Checked)
            {
                tutar = fiyat - (fiyat * 0.30);
                lblBilgi.Text = "Tutar = " + tutar;
                lblBilgi.ForeColor = Color.Green;
            }
            else
            {
                lblBilgi.Text = "Bir İşlem Seçin";
                lblBilgi.ForeColor = Color.Red;
            }
        }
    }
}
