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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            try
            {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);


            }
            catch (Exception)
            {
                textBox1.Text = "neni cislo";
                textBox2.Text = "neni cislo";
                a = 0;
                b = 0;
            }
            Secti(a,b);
        }

        public void Secti(int a, int b) {
            textBox3.Text = (a + b).ToString();
        }
    }
}
