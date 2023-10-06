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
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked  ) 
            {
                label1.Text = "CheckBox Seçili";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "CheckBox Seçili DEĞİL";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
