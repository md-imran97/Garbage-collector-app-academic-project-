using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GC.User_Control;

namespace GC
{
    public partial class Form3 : Form
    {
        //public Controler clr;

        public Form3()
        {
            //clr = new Controler();
            InitializeComponent();
            pnlMenu1.BackColor = Color.White;
            panel2.BackColor = Color.Transparent;
            this.MaximizeBox = false;

            if (!panel1.Controls.Contains(UsrLogin.Instance))
            {
                panel1.Controls.Add(UsrLogin.Instance);
                UsrLogin.Instance.Dock = DockStyle.Fill;
                UsrLogin.Instance.BringToFront();
            }
            else
            {
                UsrLogin.Instance.BringToFront();
            }
            
        }

        private void usrLogin1_Load(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usrSignup1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.White;
            panel2.BackColor = Color.Transparent;

            if (!panel1.Controls.Contains(UsrLogin.Instance))
            {
                panel1.Controls.Add(UsrLogin.Instance);
                UsrLogin.Instance.Dock = DockStyle.Fill;
                UsrLogin.Instance.BringToFront();
            }
            else
            {
                UsrLogin.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.Transparent;
            panel2.BackColor = Color.White;

            if (!panel1.Controls.Contains(UsrSignup.Instance))
            {
                panel1.Controls.Add(UsrSignup.Instance);
                UsrSignup.Instance.Dock = DockStyle.Fill;
                UsrSignup.Instance.BringToFront();
            }
            else
            {
                UsrSignup.Instance.BringToFront();
            }
        }
    }
}
