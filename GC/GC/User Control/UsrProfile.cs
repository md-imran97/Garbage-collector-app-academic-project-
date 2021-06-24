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
    public partial class UsrProfile : UserControl
    {
        Controler clr;
        string[] zoneArr = { "DHAKA", "CHITTAGONG", "KHULNA" };

        public static string name;
        public static string phone;
        public static string zone;
        public static string type;
        static int r;

        private static UsrProfile _instance;

        public static UsrProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrProfile();
                return _instance;
            }
        }


        public UsrProfile()
        {
            InitializeComponent();
            comboBox1.DataSource = zoneArr;
            clr = new Controler();

            r = 0;

        }

        public static void re()
        {
            
        }
            
        

        public static void pSet(string n,string p,string t,string z)
        {
            name = n;
            phone = p;
            type = t;
            zone = z;
        }
        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsrProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
            textBox1.Enabled = true;
            //textBox2.Enabled = true;
            comboBox1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = phone;
            textBox3.Text = type;
            textBox4.Text = zone;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToString() !="" && textBox2.Text.ToString() !="")
            {
                clr.update(textBox1.Text.ToString(), phone, comboBox1.Text.ToString());

            }
            else
            {
                MessageBox.Show("Fill up every field");
            }
            textBox1.Enabled = false;
           // textBox2.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clr.delete(phone);
            textBox1.Enabled = false;
            // textBox2.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
