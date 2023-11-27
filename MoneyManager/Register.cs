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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        MoneyManagerContext context = new MoneyManagerContext();


        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Email") || txtPass.Text.Equals("Password"))
            {
                MessageBox.Show("Bạn cần điền email và mật khẩu để tạo tài khoản!");
            }
            else if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                if (checkDuplicate(txtEmail.Text))
                {
                    MessageBox.Show("Tài khoản của bạn đã tồn tại");
                }
                else
                {
                    var account = new Account()
                    {
                        Email = txtEmail.Text,
                        Password = txtPass.Text,
                    };
                    context.Accounts.Add(account);
                    context.SaveChanges();
                    MessageBox.Show("Đăng ký thành công!");
                    Login frm = new Login();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền email và mật khẩu để tạo tài khoản!");
            }

        }

        private bool checkDuplicate(string email)
        {
            return context.Accounts.Any(a => a.Email == email);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
