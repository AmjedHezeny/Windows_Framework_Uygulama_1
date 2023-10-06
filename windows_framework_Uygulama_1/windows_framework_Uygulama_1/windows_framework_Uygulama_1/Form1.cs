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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox form = new CheckBox();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBox_Ornek form= new CheckBox_Ornek();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RadioButton radio = new RadioButton();
            radio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RadioButton_Ornek form=new RadioButton_Ornek();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.Show();
        }
    }
}
