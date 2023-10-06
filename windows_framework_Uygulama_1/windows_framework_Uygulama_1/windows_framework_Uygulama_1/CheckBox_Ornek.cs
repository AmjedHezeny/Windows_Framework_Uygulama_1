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
    public partial class CheckBox_Ornek : Form
    {
        public CheckBox_Ornek()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat = 0, tutar = 0;
            try
            {
                fiyat = double.Parse(txtFiyat.Text);
            }
            catch 
            {
                lblBilgi.Text = "Lütfen Geçerli Bir Değer Giriniz";
                lblBilgi.ForeColor = Color.Red;
                txtFiyat.Clear();
                txtFiyat.Focus(); //TextBox ı seçili hale getiriyor
                
            }
            tutar = fiyat;
            if (checkBox1.Checked)
            {
                tutar = fiyat - (fiyat * 0.15);
            }

            lblBilgi.Text = "Tutar = "+tutar.ToString();
            lblBilgi.ForeColor = Color.Aqua;
        }
    }
}
