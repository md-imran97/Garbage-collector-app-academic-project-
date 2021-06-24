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
    public partial class UsrCalculator : UserControl
    {
        int iron = 0;
        int plastic = 0;
        int paper = 0;
        int cooper = 0;
        int aluminium = 0;
        int sum = 0;

        private static UsrCalculator _instance;

        public static UsrCalculator Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsrCalculator();
                return _instance;
            }
        }

        public UsrCalculator()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                iron = Convert.ToInt32(numericUpDown1.Value)*35;
                plastic = Convert.ToInt32(numericUpDown2.Value)*25;
                paper = Convert.ToInt32(numericUpDown3.Value)*15;
                cooper = Convert.ToInt32(numericUpDown4.Value)*200;
                aluminium = Convert.ToInt32(numericUpDown5.Value)*105;


                sum = iron + plastic + paper + cooper + aluminium;
                txtResult.Text = "";
                txtResult.Text = sum.ToString();
                 iron = 0;
                 plastic = 0;
                 paper = 0;
                 cooper = 0;
                 aluminium = 0;
                 sum = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            txtResult.Text = "";



        }

    }
}
