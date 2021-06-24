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
    public partial class Form2 : Form
    {
        
        int option = 0;
        Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            pnlMenu.Visible = true;
            
            panel1.Visible = false;
            if (!pnlGround.Controls.Contains(UsrBuy.Instance))
            {
                pnlGround.Controls.Add(UsrBuy.Instance);
                UsrBuy.Instance.Dock = DockStyle.Fill;
                UsrBuy.Instance.BringToFront();
            }
            else
            {
                UsrBuy.Instance.BringToFront();
            }
            pnlMenu1.BackColor = Color.White;
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

        private void btnSell_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.White;
            pnlMenu2.BackColor = Color.Transparent;
            pnlMenu3.BackColor = Color.Transparent;
            pnlMenu4.BackColor = Color.Transparent;
            panel1.Visible = false;
            option = 0;
            //pnlBuy.Visible = true;
            //pnlBuy.BringToFront();

            if(!pnlGround.Controls.Contains(UsrBuy.Instance))
            {
                pnlGround.Controls.Add(UsrBuy.Instance);
                UsrBuy.Instance.Dock = DockStyle.Fill;
                UsrBuy.Instance.BringToFront();
            }
            else
            {
                UsrBuy.Instance.BringToFront();
            }
           
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.Transparent;
            pnlMenu2.BackColor = Color.White;
            pnlMenu3.BackColor = Color.Transparent;
            pnlMenu4.BackColor = Color.Transparent;
            panel1.Visible = false;
            option = 0;

            if (!pnlGround.Controls.Contains(UsrCalculator.Instance))
            {
                pnlGround.Controls.Add(UsrCalculator.Instance);
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
            pnlMenu4.BackColor = Color.Transparent;
            panel1.Visible = false;
            option = 0;

            if (!pnlGround.Controls.Contains(UsrHistory.Instance))
            {
                pnlGround.Controls.Add(UsrHistory.Instance);
                UsrHistory.Instance.Dock = DockStyle.Fill;
                UsrHistory.Instance.BringToFront();
            }
            else
            {
                UsrHistory.Instance.BringToFront();
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            if (option == 0)
            {
                panel1.Visible = true;
                option = 1;
                pnlMenu1.BackColor = Color.Transparent;
                pnlMenu2.BackColor = Color.Transparent;
                pnlMenu3.BackColor = Color.Transparent;
                pnlMenu4.BackColor = Color.Transparent;
            }
            else if (option == 1)
            {
                panel1.Visible = false;
                option = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            pnlMenu1.BackColor = Color.Transparent;
            pnlMenu2.BackColor = Color.Transparent;
            pnlMenu3.BackColor = Color.Transparent;
            pnlMenu4.BackColor = Color.White;

            panel1.Visible = false;
            option = 0;

            if (!pnlGround.Controls.Contains(UsrDeal.Instance))
            {
                pnlGround.Controls.Add(UsrDeal.Instance);
                UsrDeal.Instance.Dock = DockStyle.Fill;
                UsrDeal.Instance.BringToFront();
            }
            else
            {
                UsrDeal.Instance.BringToFront();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            if (!pnlGround.Controls.Contains(UsrProfile.Instance))
            {
                pnlGround.Controls.Add(UsrProfile.Instance);
                UsrProfile.Instance.Dock = DockStyle.Fill;
                UsrProfile.Instance.BringToFront();
            }
            else
            {
                UsrProfile.Instance.BringToFront();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
        }
    }
}
