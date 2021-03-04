using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTextBox
{
    public partial class Form4 : Form
    {
      //  string posledniPlatnyText1, posledniPlatnyText2;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            try
            {
            a = int.Parse(mujTextBox1.Text);
            b = int.Parse(mujTextBox2.Text);

            }
            catch (Exception)
            {

            if (mujTextBox1.Text == "") { mujTextBox1.Text = "0"; a = 0; } else { a = int.Parse(mujTextBox1.Text); }
                
            if (mujTextBox2.Text == "") { mujTextBox2.Text = "0"; b = 0; } else { b = int.Parse(mujTextBox2.Text); }
              
            }
            Secti(a,b);
        }

        public void Secti(int a, int b) {
            textBox3.Text = (a + b).ToString();
        }

        private void mujTextBox_TextChanged(object sender, EventArgs e)
        {
            MujTextBox tb = (MujTextBox)sender;

           

            try
            {

                int.Parse(tb.Text);
                tb.PosledniPlatnyText = tb.Text;

            }
            catch (Exception)
            {
                tb.Text = tb.PosledniPlatnyText;
                tb.SelectionStart = tb.Text.Length;

            }
        }

        
    }
}
