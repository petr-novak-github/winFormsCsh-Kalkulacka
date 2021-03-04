using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using System.Windows.Forms;

namespace Aplikace
{
    class Program
    {
        static void Main(string[] args)
        {

            var form = new Form5();
            // Application.Run(new Form5());
            form.ShowDialog();
        }
    }
}
