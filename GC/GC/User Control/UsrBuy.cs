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
    public partial class UsrBuy : UserControl
    {
        Controler clr;

        public static string name;
        public static string phone;
        public static string zone;
        public static string type;

        public static string amount;
        public static string sellerName;
        public static string sellerPhone;


        private static UsrBuy _instance;

        public static UsrBuy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrBuy();
                return _instance;
            }
        }

        public UsrBuy()
        {
            InitializeComponent();
            amount = "0";
            clr = new Controler();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            clr.buyAccept(phone);
            txtAmount.Text = "";
            amount = "0";
            button1.Enabled = true;
            btnAccept.Enabled = false;
            btnReject.Enabled = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clr.buyRefresh(zone, name, phone);
            if(amount !="0")
            {
                txtAmount.Text = amount;
                btnAccept.Enabled = true;
                btnReject.Enabled = true;

                button1.Enabled = false;
                
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            clr.buyReject(phone);

            txtAmount.Text = "";
            amount = "0";
            button1.Enabled = true;
            btnAccept.Enabled = false;
            btnReject.Enabled = false;
        }
    }
}
