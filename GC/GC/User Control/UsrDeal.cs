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
    public partial class UsrDeal : UserControl
    {
        Controler clr;

        public static string name;
        public static string phone;
        public static string zone;
        public static string type;

        public static string amount;
        public static string sellerName;
        public static string sellerPhone;



        private static UsrDeal _instance;

        public static UsrDeal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrDeal();
                return _instance;
            }
        }

        public UsrDeal()
        {
            InitializeComponent();
            clr = new Controler();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clr.dealRefresh(phone);
            textBox1.Text = sellerName;
            textBox2.Text = sellerPhone;
            textBox3.Text = amount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clr.dealDone(phone);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
