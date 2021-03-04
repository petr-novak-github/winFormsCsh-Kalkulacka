using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Knihovna;

namespace GUI
{
    public partial class Form5 : Form
    {
        //string posledniPlatnyText1, posledniPlatnyText2;
        Hashtable posledniPlatneTexty = new Hashtable();
        Kalkulacka k1 = new Kalkulacka();
        public Form5()
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
            textBox3.Text =Kalkulacka.Secti(a,b);
        }

        

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            try
            {

                int.Parse(tb.Text);
                //tb.PosledniPlatnyText = tb.Text;
                if (!posledniPlatneTexty.ContainsKey(tb)) { posledniPlatneTexty.Add(tb, tb.Text); }
                else { posledniPlatneTexty[tb] = tb.Text; }


            }
            catch (Exception)
            {
                // tb.Text = tb.PosledniPlatnyText;
                if (!posledniPlatneTexty.ContainsKey(tb)) { tb.Text= ""; }
                else { tb.Text = posledniPlatneTexty[tb].ToString(); }


                tb.SelectionStart = tb.Text.Length;

            }
        }


    }
}
