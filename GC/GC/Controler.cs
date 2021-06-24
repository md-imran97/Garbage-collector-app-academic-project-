using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System.Windows.Forms;
using GC.User_Control;

namespace GC
{
   public class Controler
    {
        public MySqlConnection con;

        public Controler()
        {
            
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

        public void logIn(string phone, string pass)
        {
            try
            {
                int flag = 0;
                con.Open();

                string q = "Select * from user where phone='"+phone+"' and pass='"+pass+"' ";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr = cmd.ExecuteReader();
                while (mdr.Read())
                {
                    if(mdr["phone"].ToString()==phone.ToString() && mdr["pass"].ToString().Equals(pass))
                    {
                        if(mdr["type"].ToString()=="Seller")
                        {
                            Form1 f1 = new Form1();
                            
                            

                            UsrProfile.name= mdr["name"].ToString();
                            UsrProfile.phone= mdr["phone"].ToString();
                            UsrProfile.type= mdr["type"].ToString();
                            UsrProfile.zone= mdr["zone"].ToString();

                            UsrSell.name = mdr["name"].ToString();
                            UsrSell.phone = mdr["phone"].ToString();
                            UsrSell.type = mdr["type"].ToString();
                            UsrSell.zone = mdr["zone"].ToString();

                            UsrHistory.name = mdr["name"].ToString();
                            UsrHistory.phone = mdr["phone"].ToString();
                            UsrHistory.type = mdr["type"].ToString();
                            UsrHistory.zone = mdr["zone"].ToString();


                            flag = 1;
                            
                            f1.Show();
                            
                            
                            
                            break;

                        }
                        else if(mdr["type"].ToString() == "Buyer")
                        {
                            Form2 f2 = new Form2();

                            UsrProfile.name = mdr["name"].ToString();
                            UsrProfile.phone = mdr["phone"].ToString();
                            UsrProfile.type = mdr["type"].ToString();
                            UsrProfile.zone = mdr["zone"].ToString();

                            UsrBuy.name = mdr["name"].ToString();
                            UsrBuy.phone = mdr["phone"].ToString();
                            UsrBuy.type = mdr["type"].ToString();
                            UsrBuy.zone = mdr["zone"].ToString();

                            UsrDeal.name = mdr["name"].ToString();
                            UsrDeal.phone = mdr["phone"].ToString();
                            UsrDeal.type = mdr["type"].ToString();
                            UsrDeal.zone = mdr["zone"].ToString();

                            UsrHistory.name = mdr["name"].ToString();
                            UsrHistory.phone = mdr["phone"].ToString();
                            UsrHistory.type = mdr["type"].ToString();
                            UsrHistory.zone = mdr["zone"].ToString();

                            flag = 1;

                            f2.Visible = true;
                            break;
                        }
                    }
                }
                if(flag==0)
                {
                    MessageBox.Show("phone or password is incorrect");
                }
                con.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void signUp(string name, string phone,string pass, string type, string zone)
        {
            try
            {
                con.Open();
                string q = "insert into user(name,phone,pass,zone,type) values('" + name + "','" + phone + "','" +pass+ "','" +zone+ "','" +type+ "');";
                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();
                MessageBox.Show("Sign up successfully");
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("This phone number already registered");
            }
        }

        public void update(string name,string phone2, string zone)
        {
            try
            {
                con.Open();
                string q = "update user set name='" +name+ "',phone='" +phone2+ "',zone='" +zone+ "' where phone='" +phone2+ "';";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();
                MessageBox.Show("Update successfully");

                UsrProfile.name = name;
                UsrProfile.phone = phone2;
                
                UsrProfile.zone = zone;

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void delete(string phone)
        {
            try
            {
                con.Open();
                string q = "delete from user where phone='" +phone+ "';";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();
                MessageBox.Show("Account delete successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void sell(string name,string phone,string zone,string amount)
        {
            try
            {
                con.Open();
                string q = "insert into sell(Seller_Name,Seller_Phone,zone,Amount) values('" + name + "','" + phone + "','" + zone + "','" + amount + "');";
                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();
                MessageBox.Show("Request sent seccessfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        public void buyRefresh(string zone,string name, string phone)
        {
            try
            {
                con.Open();
                string sellerPhone = "";
                int flag = 0;

                string q = "Select * from sell where zone='" + zone + "' ";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr = cmd.ExecuteReader();

                while(mdr.Read())
                {
                    if(mdr["status"].ToString()=="1" && mdr["Buyer_Name"].ToString()=="0" )
                    {
                        UsrBuy.amount = mdr["Amount"].ToString();
                        
                        sellerPhone = mdr["Seller_Phone"].ToString();
                        flag = 1;
                        break;
                    }
                }
                con.Close();

                if(flag==1)
                {
                    con.Open();
                    string qt = "update sell set Buyer_Name='" + name + "',Buyer_Phone='" + phone + "' where Seller_Phone='" + sellerPhone + "' and  Buyer_Name='" + 0 + "' ;";

                     cmd = new MySqlCommand(qt, con);
                    
                    mdr = cmd.ExecuteReader();
                    MessageBox.Show("You have a request");

                    
                    con.Close();
                }

            }
            catch (Exception ex)
            {

                
            }
        }

        public void buyAccept(string phone)
        {
            try
            {
                con.Open();
                string qq = "update sell set status='" + 2 + "' where Buyer_Phone='" + phone + "' ;";

                MySqlCommand cmd = new MySqlCommand(qq, con);
                MySqlDataReader mdr = cmd.ExecuteReader();

                
                MessageBox.Show("Request accepted");


                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public void dealRefresh(string phone)
        {
            try
            {
                con.Open();
                

                string q = "Select * from sell where Buyer_Phone='" + phone + "' ";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr = cmd.ExecuteReader();

                while (mdr.Read())
                {
                    if (mdr["status"].ToString()=="2")
                    {
                        UsrDeal.amount = mdr["Amount"].ToString();
                        UsrDeal.sellerPhone = mdr["Seller_Phone"].ToString();
                        UsrDeal.sellerName = mdr["Seller_Name"].ToString();

                        
                        
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void dealDone(string phone)
        {
            try
            {
                con.Open();
                string q = "update sell set status='" + 3 + "' where Buyer_Phone='" + phone + "' and status='" + 2 + "' ;";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr = cmd.ExecuteReader();


                MessageBox.Show("Deal completed");


                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void buyReject(string phone)
        {
            try
            {
                con.Open();
                string q = "update sell set status='" + 1 + "',Buyer_Name='" + 0 + "',Buyer_Phone='" + 0 + "' where Buyer_Phone='" + phone + "' and status='" + 1 + "' ;";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr = cmd.ExecuteReader();


                MessageBox.Show("Request rejected");


                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
       
        public void sellRefresh(string phone)
        {
            try
            {
                con.Open();

                int flag = 0;
                string q = "Select * from sell where Seller_Phone='" + phone + "' ";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr = cmd.ExecuteReader();

                while (mdr.Read())
                {
                    if (mdr["status"].ToString() == "2")
                    {
                        UsrSell.buyerName = mdr["Buyer_Name"].ToString();
                        UsrSell.buyerPhone = mdr["Buyer_Phone"].ToString();

                        flag = 1;

                    }
                }
                if(flag==1)
                {
                    MessageBox.Show("Request accepted");
                }
                
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void sellDone(string phone)
        {
            try
            {
                con.Open();
                string q = "update sell set status='" + 3 + "' where Seller_Phone='" + phone + "' and status='" + 2 + "' ;";

                MySqlCommand cmd = new MySqlCommand(q, con);
                MySqlDataReader mdr = cmd.ExecuteReader();


                MessageBox.Show("Deal completed");


                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
