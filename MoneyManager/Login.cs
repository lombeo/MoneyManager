using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class Login : Form
    {
        MoneyManagerContext context = new MoneyManagerContext();
        public Login()
        {
            InitializeComponent();
        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Email") && txtPass.Text.Equals("Password"))
            {
                MessageBox.Show("Bạn cần điền email và mật khẩu để đăng nhập!");
            }
            else if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                Account acc = checkLogin(txtEmail.Text, txtPass.Text);
                if (acc != null)
                {
                    if (context.Wallets.Any(w => w.AccountId == acc.AccountId))
                    {
                        Home frm = new Home(acc);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        AddWallet frm = new AddWallet(acc);
                        frm.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền email và mật khẩu để đăng nhập!");
            }
        }

        public Account checkLogin(string email, string password)
        {
            var account = context.Accounts.FirstOrDefault(a => a.Email == email && a.Password == password);
            return account;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
