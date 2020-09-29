using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiSpeak
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnErmodgerise_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTextInput.Text)) return;

            txtTextOutput.Text = toErmodgie(txtTextInput.Text);
        }

        private void txtHello_Click(object sender, EventArgs e)
        {
            this.txtTextInput.Text = "Hello";
        }

        private void btnHiDen_Click(object sender, EventArgs e)
        {
            this.txtTextInput.Text = "Hi Den";
        }

        private string toErmodgie(string text)
        {
            StringBuilder sb = new StringBuilder();

            sb.Clear();

            foreach (char c in text.ToCharArray())
            {
                if(Char.Equals(c, ' ')) {
                    sb.Append(" ");
                }

                if (!Char.IsLetter(c)) continue;

                char s = Char.ToLower(c);
                sb.Append($":regional_indicator_{s}: ");
            }

            return sb.ToString();
        }
    }
}
