using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GC.User_Control
{
    public partial class UsrHistory : UserControl
    {

        private static UsrHistory _instance;

        public static UsrHistory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrHistory();
                return _instance;
            }
        }


        public static string name;
        public static string phone;
        public static string zone;
        public static string type;

        string q;

        public MySqlConnection con;
        public MySqlDataAdapter mda;

        public UsrHistory()
        {
            InitializeComponent();
            try
            {
                string conString = "Server=localhost;Database=gc;Uid=root;Pwd=;";
                con = new MySqlConnection(conString);

                //MessageBox.Show("Yes");
                
            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if(type=="Buyer")
                {
                    q = "Select Seller_name,Seller_phone,Amount from sell where Buyer_phone='" + phone + "' and status='" + 3 + "' order by id desc ";
                }
                else if(type == "Seller")
                {
                    q = "Select Buyer_Name,Buyer_Phone,Amount from sell where Seller_Phone='" + phone + "' and status='" + 3 + "' order by id desc ";
                }
                
                mda = new MySqlDataAdapter(q, con);
                con.Close();
                MySqlCommandBuilder cb = new MySqlCommandBuilder(mda);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            
        }
    }
}
