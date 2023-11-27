using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyManager.Controllers;
using MoneyManager.Models;

namespace MoneyManager
{
    public partial class AddWallet : Form
    {
        private Account acc;

        public AddWallet(Account data)
        {
            InitializeComponent();
            acc = data;
        }
        WalletDAO walletDAO = new WalletDAO();
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void AddWallet_FormClosing(object sender, FormClosingEventArgs e)
        {
            WalletDAO walletDAO = new WalletDAO();
            if (walletDAO.GetWallet(acc.AccountId) == null)
            {
                this.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private void txtWname_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        private void CheckEnableButton()
        {
            if (!string.IsNullOrEmpty(txtWname.Text) && !string.IsNullOrEmpty(txtBalance.Text))
            {
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(45, 184, 76);
                btnAdd.FlatAppearance.BorderColor = Color.FromArgb(45, 184, 76);
                btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
                btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                btnAdd.ForeColor = Color.White;
                btnAdd.Location = new Point(277, 291);
                btnAdd.Name = "btnAdd";
                btnAdd.Size = new Size(96, 44);
                btnAdd.TabIndex = 5;
                btnAdd.Text = "Thêm";
                btnAdd.UseVisualStyleBackColor = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                btnAdd.ForeColor = Color.Black;
                btnAdd.FlatAppearance.BorderColor = Color.Black;
                btnAdd.FlatAppearance.BorderColor = Color.Black;
                btnAdd.FlatAppearance.BorderColor = Color.Black;
                btnAdd.BackColor = Color.White;
                btnAdd.FlatStyle = FlatStyle.Standard;
                btnAdd.Location = new Point(277, 291);
                btnAdd.Name = "btnAdd";
                btnAdd.Size = new Size(96, 44);
                btnAdd.TabIndex = 5;
                btnAdd.Text = "Thêm";
                btnAdd.UseVisualStyleBackColor = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            walletDAO.AddWallet(acc.AccountId, txtWname.Text, decimal.Parse(txtBalance.Text));

            bool homeFormVisible = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Home)
                {
                    homeFormVisible = true;
                    break;
                }
            }

            if (homeFormVisible)
            {
                Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
                if (homeForm != null)
                {
                    homeForm.btnMWallet_Click(sender, e);
                }
                this.Hide();

            }
            else
            {
                Home frm = new Home(acc);
                frm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddWallet_FormClosing(sender, new FormClosingEventArgs(CloseReason.None, false));
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }
    }
}
