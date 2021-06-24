using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC.User_Control
{
    public partial class UsrLogin : UserControl
    {
        

        public Controler clr;

        private static UsrLogin _instance;

        public static UsrLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrLogin();
                return _instance;
            }
        }


        

        public UsrLogin()
        {
            clr = new Controler();
            InitializeComponent();
            textBox2.PasswordChar = '*';
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToString() !="" && textBox2.Text.ToString() !="")
            {
                clr.logIn(textBox1.Text.ToString(), textBox2.Text.ToString());
            }
            else
            {
                MessageBox.Show("Fill up every field");
            }
        }
    }
}
