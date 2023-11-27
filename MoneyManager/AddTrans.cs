using MoneyManager.Controllers;
using MoneyManager.Models;
using MoneyManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class AddTrans : Form
    {
        Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
        MoneyManagerContext context = new MoneyManagerContext();
        Account acc;
        WalletDAO wd = new WalletDAO();
        Wallet wal = new Wallet();
        public AddTrans(Account data, Wallet wal)
        {
            InitializeComponent();
            acc = data;
            this.wal = wal;
        }

        private void AddTrans_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void AddTrans_Load(object sender, EventArgs e)
        {
            var categories = context.Categories.ToList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.SelectedIndexChanged += (cbSender, cbEventArgs) =>
            {
                
                var selectedCategory = (Category)cbCategory.SelectedItem;

                
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

            var budget = context.Budgets.Where(b => b.AccountId == acc.AccountId && b.WalletId == wal.WalletId).ToList();
            budget.Insert(0, new Budget { BudgetName = "-", BudgetId = 0 });
            cbBudget.DataSource = budget;
            cbBudget.DisplayMember = "BudgetName";
            cbBudget.ValueMember = "BudgetId";
            cbBudget.SelectedIndex = 0;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategory.SelectedIndexChanged += (cbSender, cbEventArgs) =>
            {
                
                var selectedCategory = (Category)cbCategory.SelectedItem;

                
                var subCategories = context.SubCategories
                    .Where(sc => sc.CategoryId == selectedCategory.CategoryId)
                    .ToList();
                cbSubCategory.DataSource = subCategories;
                cbSubCategory.DisplayMember = "SCName";
                cbSubCategory.ValueMember = "SCID";
            };
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Bạn cần nhập số tiền!");
            }
            else if (cbBudget.SelectedItem == null || Int32.Parse(cbBudget.SelectedValue.ToString()) == 0)
            {
                if (int.TryParse(cbWallet.SelectedValue.ToString(), out int walletId) &&
                    int.TryParse(cbCategory.SelectedValue.ToString(), out int categoryId) &&
                    int.TryParse(cbSubCategory.SelectedValue.ToString(), out int subCategoryId))
                {


                    if (categoryId == 1 || categoryId == 2)
                    {
                        var wallet = context.Wallets.FirstOrDefault(w => w.WalletId == walletId);
                        if (wallet != null)
                        {
                            if (categoryId == 1)
                            {
                                DateTime now = DateTime.Now;
                                context.Transactions.Add(new Transaction(acc.AccountId, walletId, categoryId, subCategoryId, null, wd.GetWalletById(walletId).Balance, (wd.GetWalletById(walletId).Balance - int.Parse(txtAmount.Text)), decimal.Parse(txtAmount.Text), now, txtNote.Text));
                                if(wallet.Balance< decimal.Parse(txtAmount.Text))
                                {
                                    MessageBox.Show("Ví của bạn không đủ tiền!");
                                    return;
                                }
                                wallet.Balance -= decimal.Parse(txtAmount.Text);
                            }
                            else if (categoryId == 2)
                            {
                                DateTime now = DateTime.Now;
                                context.Transactions.Add(new Transaction(acc.AccountId, walletId, categoryId, subCategoryId, null, wd.GetWalletById(walletId).Balance, (wd.GetWalletById(walletId).Balance + int.Parse(txtAmount.Text)), decimal.Parse(txtAmount.Text), now, txtNote.Text));
                                wallet.Balance += decimal.Parse(txtAmount.Text);
                            }
                            homeForm.UpdateUI(wallet);
                            context.SaveChanges();
                        }
                    }
                    MessageBox.Show("Thêm giao dịch thành công!");
                    if (homeForm != null)
                    {
                        homeForm.Home_Load(sender, e);
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lỗi chuyển đổi dữ liệu!");
                }
            }
            else
            {
                Budget bud = wd.GetBudgetByBudID(Int32.Parse(cbBudget.SelectedValue.ToString()));
                if (int.TryParse(cbWallet.SelectedValue.ToString(), out int walletId) &&
                    int.TryParse(cbCategory.SelectedValue.ToString(), out int categoryId) &&
                    int.TryParse(cbSubCategory.SelectedValue.ToString(), out int subCategoryId) &&
                    int.TryParse(cbBudget.SelectedValue.ToString(), out int budgetId))
                {


                    if (categoryId == 1 || categoryId == 2)
                    {
                        var wallet = context.Wallets.FirstOrDefault(w => w.WalletId == walletId);
                        if (wallet != null)
                        {
                            if (categoryId == 1)
                            {
                                DateTime now = DateTime.Now;
                                context.Transactions.Add(new Transaction(acc.AccountId, bud.WalletId, bud.CategoryId, bud.Scid, budgetId, wd.GetWalletById(walletId).Balance, (wd.GetWalletById(walletId).Balance - int.Parse(txtAmount.Text)), decimal.Parse(txtAmount.Text), now, txtNote.Text));
                                if (wallet.Balance < decimal.Parse(txtAmount.Text))
                                {
                                    MessageBox.Show("Ví của bạn không đủ tiền!");
                                    return;
                                }
                                wallet.Balance -= decimal.Parse(txtAmount.Text);
                            }
                            else if (categoryId == 2)
                            {
                                DateTime now = DateTime.Now;
                                context.Transactions.Add(new Transaction(acc.AccountId, bud.WalletId, bud.CategoryId, bud.Scid, budgetId, wd.GetWalletById(walletId).Balance, (wd.GetWalletById(walletId).Balance + int.Parse(txtAmount.Text)), decimal.Parse(txtAmount.Text), now, txtNote.Text));
                                wallet.Balance += decimal.Parse(txtAmount.Text);
                            }
                            homeForm.UpdateUI(wallet);
                            context.SaveChanges();

                        }
                    }
                    MessageBox.Show("Thêm giao dịch thành công!");

                    if (homeForm != null)
                    {
                        homeForm.Home_Load(sender, e);
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lỗi chuyển đổi dữ liệu!");
                }
            }
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addSub frm = new addSub();
            frm.ShowDialog();
        }
    }
}
