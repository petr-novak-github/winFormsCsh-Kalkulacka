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
    public partial class Form3 : Form
    {
        string posledniPlatnyText1, posledniPlatnyText2;
        public Form3()
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

            if (textBox1.Text == "") { textBox1.Text = "0"; a = 0; } else { a = int.Parse(textBox1.Text); }
                
            if (textBox2.Text == "") { textBox2.Text = "0"; b = 0; } else { b = int.Parse(textBox2.Text); }
                

            }
            Secti(a,b);
        }

        public void Secti(int a, int b) {
            textBox3.Text = (a + b).ToString();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
               
                int.Parse(textBox1.Text);
                posledniPlatnyText1 = textBox1.Text;

            }
            catch (Exception)
            {
                textBox1.Text = posledniPlatnyText1;
                textBox1.SelectionStart=textBox1.Text.Length;
            
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                int.Parse(textBox2.Text);
                posledniPlatnyText2 = textBox1.Text;

            }
            catch (Exception)
            {
                textBox2.Text = posledniPlatnyText2;
                textBox2.SelectionStart = textBox2.Text.Length;

            }
        }

        
    }
}
