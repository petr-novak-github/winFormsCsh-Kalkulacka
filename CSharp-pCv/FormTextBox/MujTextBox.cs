using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTextBox
{
    class MujTextBox:TextBox
    {
        private string posledniPlatnyText;

        public string PosledniPlatnyText { get => posledniPlatnyText; set => posledniPlatnyText = value; }

        public string GetPosledniPlatnyText()
        {
            return PosledniPlatnyText;
        }

        public void SetPosledniPlatnyText(string value)
        {
            PosledniPlatnyText = value;
        }
    }
}
