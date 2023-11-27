using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class AddBud : Form
    {
        Account acc;
        public AddBud(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addSub frm = new addSub();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            cbCategory.SelectedIndexChanged += (cbSender, cbEventArgs) =>
            {
                // Lấy category được chọn
                var selectedCategory = (Category)cbCategory.SelectedItem;

                // Load danh sách subCategory tương ứng vào combobox cbSubCategory
                var subCategories = context.SubCategories
                    .Where(sc => sc.CategoryId == selectedCategory.CategoryId)
                    .ToList();
                cbSubCategory.DataSource = subCategories;
                cbSubCategory.DisplayMember = "SCName";
                cbSubCategory.ValueMember = "SCID";
            };
        }

        private void AddBud_Load(object sender, EventArgs e)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            var categories = context.Categories.ToList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.SelectedIndexChanged += (cbSender, cbEventArgs) =>
            {
                // Lấy category được chọn
                var selectedCategory = (Category)cbCategory.SelectedItem;

                // Load danh sách subCategory tương ứng vào combobox cbSubCategory
                var subCategories = context.SubCategories
                    .Where(sc => sc.CategoryId == selectedCategory.CategoryId)
                    .ToList();
                cbSubCategory.DataSource = subCategories;
                cbSubCategory.DisplayMember = "SCName";
                cbSubCategory.ValueMember = "Scid";
            };
            cbWallet.DataSource = context.Wallets.Where(w => w.AccountId == acc.AccountId).ToList();
            cbWallet.DisplayMember = "WalletName";
            cbWallet.ValueMember = "WalletId";
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now.AddMonths(1);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtName.Text))
            {
                Budget budget = new Budget(acc.AccountId, Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(cbSubCategory.SelectedValue), Convert.ToInt32(cbWallet.SelectedValue), DateTime.Parse(dtStart.Text), DateTime.Parse(dtEnd.Text), decimal.Parse(txtAmount.Text), txtNote.Text, txtName.Text);
                context.Budgets.Add(budget);
                context.SaveChanges();
                MessageBox.Show("Thêm hũ mới thành công!");
                Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
                if (homeForm != null)
                {
                    homeForm.btnBudget_Click(new object(), new EventArgs());
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin hũ!");
            }
        }
    }
}
