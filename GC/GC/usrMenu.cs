using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC
{
    public partial class usrMenu : UserControl
    {
        public usrMenu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.White;
            pnlMenu2.BackColor = Color.Transparent;
            pnlMenu3.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.Transparent;
            pnlMenu2.BackColor = Color.White;
            pnlMenu3.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.Transparent;
            pnlMenu2.BackColor = Color.Transparent;
            pnlMenu3.BackColor = Color.White;
        }
    }
}
