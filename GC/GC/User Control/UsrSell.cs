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
    public partial class UsrSell : UserControl
    {


        public static string name;
        public static string phone;
        public static string zone;
        public static string type;

        public static string buyerName;
        public static string buyerPhone;

        Controler clr;


        private static UsrSell _instance;

        public static UsrSell Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrSell();
                return _instance;
            }
        }


        public UsrSell()
        {
            InitializeComponent();
            clr = new Controler();
            buyerName = "";
            buyerPhone = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSellRequest_Click(object sender, EventArgs e)
        {
            double amount = 0;

            if(textBox1.Text.ToString() !="")
            {
                try
                {
                    amount = Convert.ToDouble(textBox1.Text.ToString());
                    clr.sell(name, phone, zone, amount.ToString());
                    btnSellRequest.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid amount");
                }
            }
            else
            {
                MessageBox.Show("Fill the amount field");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clr.sellRefresh(phone);
            textBox2.Text = buyerName;
            textBox3.Text = buyerPhone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clr.sellDone(phone);
            btnSellRequest.Enabled = true;
            buyerName = "";
            buyerPhone = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
