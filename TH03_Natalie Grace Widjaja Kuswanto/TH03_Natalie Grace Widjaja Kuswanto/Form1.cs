using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TH03_Natalie_Grace_Widjaja_Kuswanto
{
    public partial class Form1 : Form
    {
        List<string> datausername = new List<string>();
        List<string> datapassword = new List<string>();
        List<int> uang = new List<int>();
        int jumlahaccount = 0;
        int acclogin = 0; 
        CultureInfo culture = new CultureInfo("id-ID");
        public Form1()
        {
            InitializeComponent();
            panel_register.Visible = false;
            panel_mainview.Visible = false;
            panel_deposit.Visible = false;
            panel_withdraww.Visible = false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_register.Visible = true;
        }

        private void btn_register2_Click(object sender, EventArgs e)
        {
            string username = tb_username2.Text;
            string password = tb_password2.Text;
            panel_login.Visible = true;
            panel_register.Visible = false;
            int account = 0;
            for (int i = 0; i < datausername.Count; i++)
            {
                if (datausername[i] == username)
                {
                    account++;
                }
            }
            if (account == 0)
            {
                MessageBox.Show("Register Successful");
                tb_username2.Clear();
                tb_password2.Clear();
                datausername.Add(username);
                datapassword.Add(password);
                jumlahaccount++;
                uang.Add(0);
            }
            else if (account > 0)
            {
                MessageBox.Show("Username and Password has been used");
                tb_username2.Clear();
                tb_password2.Clear();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (jumlahaccount == 0)
            {
                MessageBox.Show("Username and password not found");
                tb_username1.Clear();
                tb_password1.Clear();

            }
            else if (jumlahaccount > 0)
            {
                for (int i = 0; i < datausername.Count; i++)
                {
                    if (tb_username1.Text == datausername[i] )
                    {
                        if (tb_password1.Text == datapassword[i] )
                        {
                            MessageBox.Show("Login Successful");
                            panel_mainview.Visible = true; 
                            panel_login.Visible = false;
                            acclogin = i;
                            lb_balance.Text = uang[acclogin].ToString("C", culture);
                            lb_deposit.Text = uang[acclogin].ToString("C", culture);
                            lb_withdraw.Text = uang[acclogin].ToString("C", culture);
                        }
                        else
                        {
                            MessageBox.Show("Username and Password not found");
                        }
                    }
                    else
                    {
                        if (datausername.Contains(tb_username1.Text))
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Username and Password not found");
                        }
                    }
                }
                tb_username1.Clear();
                tb_password1.Clear();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            panel_login.Visible = true;
            panel_mainview.Visible = false;
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            panel_deposit.Visible = true;
            panel_mainview.Visible = false;
        }

        private void btn_deposit2_Click(object sender, EventArgs e)
        {
            int depo = Convert.ToInt32(tb_deposit.Text);
            if (depo > 0)
            {
                MessageBox.Show("Succesfully add deposit");
                uang[acclogin] += depo;
                lb_balance.Text = uang[acclogin].ToString("C", culture);
                lb_deposit.Text = uang[acclogin].ToString("C", culture);
                lb_withdraw.Text = uang[acclogin].ToString("C", culture);
                tb_deposit.Clear();
                panel_deposit.Visible = false;
                panel_mainview.Visible = true;
            }
            else
            {
                MessageBox.Show("Deposit amount can't be less than one!");
                tb_deposit.Clear();
                panel_deposit.Visible = false;
                panel_mainview.Visible = true;
            }
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            panel_withdraww.Visible = true;
            panel_mainview.Visible = false;
        }

        private void btn_withdraw2_Click(object sender, EventArgs e)
        {
            int withdraw = Convert.ToInt32(tb_withdraw.Text);
            if (withdraw <= uang[acclogin] && withdraw > 0)
            {
                MessageBox.Show("Succesfully withdraw balance");
                uang[acclogin] -= withdraw;
                lb_balance.Text = uang[acclogin].ToString("C", culture);
                lb_deposit.Text = uang[acclogin].ToString("C", culture);
                lb_withdraw.Text = uang[acclogin].ToString("C", culture);
                tb_withdraw.Clear();
                panel_withdraww.Visible = false;
                panel_mainview.Visible = true;
            }
            else if (withdraw > uang[acclogin])
            {
                MessageBox.Show("Withdraw failed! Balance not enough!");
                tb_withdraw.Clear();
                panel_withdraww.Visible = false;
                panel_mainview.Visible = true;
            }
            else if (withdraw <= 0)
            {
                MessageBox.Show("Withdraw failed! Can't withdraw less than one");
                tb_withdraw.Clear();
                panel_withdraww.Visible = false;
                panel_mainview.Visible = true;
            }
        }

        private void btn_logout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            panel_login.Visible = true;
            panel_deposit.Visible = false;
        }

        private void btn_logout3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            panel_login.Visible = true;
            panel_withdraww.Visible = false;
        }
    }
}
