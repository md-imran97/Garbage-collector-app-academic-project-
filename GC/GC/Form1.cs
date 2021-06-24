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
    public partial class Form1 : Form
    {
        
        public string name;
        public string phone;
        public string zone;
        public string type;

        int option = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            
            
            this.MaximizeBox = false;
            panel1.Visible = false;
            pnlMenu1.BackColor = Color.White;

            if (!pnlSeller.Controls.Contains(UsrSell.Instance))
            {
                pnlSeller.Controls.Add(UsrSell.Instance);
                UsrSell.Instance.Dock = DockStyle.Fill;
                UsrSell.Instance.BringToFront();
            }
            else
            {
                UsrSell.Instance.BringToFront();
            }

            
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.White;
            pnlMenu2.BackColor = Color.Transparent;
            pnlMenu3.BackColor = Color.Transparent;
            panel1.Visible = false;
            option = 0;

            if (!pnlSeller.Controls.Contains(UsrSell.Instance))
            {
                pnlSeller.Controls.Add(UsrSell.Instance);
                UsrSell.Instance.Dock = DockStyle.Fill;
                UsrSell.Instance.BringToFront();
            }
            else
            {
                UsrSell.Instance.BringToFront();
            }


        }

        private void setting_Click(object sender, EventArgs e)
        {
            if(option==0)
            {
                panel1.Visible = true;
                option = 1;
                pnlMenu1.BackColor = Color.Transparent;
                pnlMenu2.BackColor = Color.Transparent;
                pnlMenu3.BackColor = Color.Transparent;
            }
           else if (option == 1)
            {
                panel1.Visible = false;
                option = 0;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.Transparent;
            pnlMenu2.BackColor = Color.White;
            pnlMenu3.BackColor = Color.Transparent;
            panel1.Visible = false;
            option = 0;

            if (!pnlSeller.Controls.Contains(UsrCalculator.Instance))
            {
                pnlSeller.Controls.Add(UsrCalculator.Instance);
                UsrCalculator.Instance.Dock = DockStyle.Fill;
                UsrCalculator.Instance.BringToFront();
            }
            else
            {
                UsrCalculator.Instance.BringToFront();
            }

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.Transparent;
            pnlMenu2.BackColor = Color.Transparent;
            pnlMenu3.BackColor = Color.White;
            panel1.Visible = false;
            option = 0;

            if (!pnlSeller.Controls.Contains(UsrHistory.Instance))
            {
                pnlSeller.Controls.Add(UsrHistory.Instance);
                UsrHistory.Instance.Dock = DockStyle.Fill;
                UsrHistory.Instance.BringToFront();
            }
            else
            {
                UsrHistory.Instance.BringToFront();
            }

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (!pnlSeller.Controls.Contains(UsrProfile.Instance))
            {
                pnlSeller.Controls.Add(UsrProfile.Instance);
                UsrProfile.Instance.Dock = DockStyle.Fill;
                UsrProfile.Instance.BringToFront();
            }
            else
            {
                UsrProfile.Instance.BringToFront();
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UsrProfile.name = "";
            UsrProfile.phone ="";
            UsrProfile.type = "";
            UsrProfile.zone = "";
            this.Hide();
        }
    }
}
