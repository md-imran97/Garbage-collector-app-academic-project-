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
    public partial class UsrSignup : UserControl
    {
        public Controler clr;

        string[] typeArr = { "Seller", "Buyer" };
        string[] zoneArr = { "DHAKA", "CHITTAGONG", "KHULNA" };

        private static UsrSignup _instance;

        public static UsrSignup Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrSignup();
                return _instance;
            }
        }


        public UsrSignup()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            comboBox1.DataSource = typeArr;
            comboBox2.DataSource = zoneArr;
            clr = new Controler();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToString() !="" && textBox2.Text.ToString() !="" && textBox3.Text.ToString() !="")
            {
                clr.signUp(textBox3.Text.ToString(), textBox1.Text.ToString(), textBox2.Text.ToString(), comboBox1.Text.ToString(), comboBox2.Text.ToString());
            }
            else
            {
                MessageBox.Show("Fill up every field");
            }
        }
    }
}
