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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin =txtYazi.Text;
            if (string.IsNullOrEmpty(metin))
            {
                MessageBox.Show("Metin Alanı Boş Bırakılamaz"," !!!! UYARI !!!!!");
                txtYazi.Focus();
            }
            else
            {
                //ListBox içerisine bir öğe ekleyelim
                //Syntax
                //<listboxName>.Items.Add(<deger>);

                listBox1.Items.Add(metin);
                txtYazi.Clear();
                MessageBox.Show(string.Format(" ' {0} ' değeri başarı ile eklendi",metin));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliIndex = listBox1.SelectedIndex;//Seçilen itemin index numarasını değişkene atamasını yapıyoruz
            if (seciliIndex!=-1)
            {
                label1.Text = listBox1.Items[seciliIndex].ToString();
            }
            
        }

        private void btnSeciliSil_Click(object sender, EventArgs e)
        {
            int seciliIndex = listBox1.SelectedIndex;
            if (seciliIndex==-1)
            {
                MessageBox.Show("Listeden Silinecek Elemanı Seçin");
            }
            else
            {
                string metin = listBox1.Items[seciliIndex].ToString();
                label1.Text = " ";
                listBox1.Items.RemoveAt(seciliIndex);
                MessageBox.Show(string.Format("' {0} ' Değeri Başarı İle Silindi", metin));
            } 
               
            
          
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Listbox içerisindeki tüm verileri silme işlemi yapıyor
        }
    }
}
