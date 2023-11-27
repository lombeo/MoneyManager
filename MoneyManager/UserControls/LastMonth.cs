using MoneyManager.Controllers;
using MoneyManager.Models;
using MoneyManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MoneyManager.UserControls
{
    public partial class LastMonth : UserControl
    {
        MoneyManagerContext context = new MoneyManagerContext();
        Account acc;
        Wallet wallet;
        WalletDAO wd = new WalletDAO();
        public LastMonth(Account data, Wallet data2)
        {
            InitializeComponent();
            acc = data;
            wallet = data2;
        }

        private void LastMonth_Load(object sender, EventArgs e)
        {
            var list = wd.GetTransactionsBeforeCurrentMonth(acc.AccountId, wallet.WalletId);
            if (list != null && list.Count >= 2)
            {
                lblOpen.Text = list[0].Opening.Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";
                lblEnding.Text = list[list.Count - 1].Ending.Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";
                lblChenh.Text = (list[list.Count - 1].Ending - list[0].Opening).Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";
            }
            else if (list != null && list.Count == 1)
            {
                lblOpen.Text = list[0].Opening.Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";
                lblEnding.Text = list[0].Ending.Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";
                lblChenh.Text = (list[0].Ending - list[0].Opening).Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";
            }
            else
            {
                lblOpen.Text = "N/A";
                lblEnding.Text = "N/A";
                lblChenh.Text = "N/A";
            }
            int Py = 0;
            //int Sy = 95;
            int totalHeight = 0; // Tổng kích thước của các panel2

            var uniqueDates = list.Select(t => t.TransDate.Value.Date).Distinct();

            foreach (var dateOnly in uniqueDates)
            {
                Panel panel2 = new Panel();
                panel2.BackColor = Color.Gray;
                panel2.Location = new Point(5, Py);
                panel2.TabIndex = 0;

                Label lblDate = new Label();
                lblDate.AutoSize = true;
                lblDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                lblDate.Location = new Point(12, 9);
                lblDate.Size = new Size(65, 25);
                lblDate.Text = dateOnly.ToString("dd/MM/yyyy");

                Label lblhu = new Label();
                lblhu.AutoSize = true;
                lblhu.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
                lblhu.Location = new Point(200, 13);
                lblhu.Size = new Size(65, 25);
                lblhu.Text = "Hũ ngân sách";

                Label lblopen = new Label();
                lblopen.AutoSize = true;
                lblopen.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
                lblopen.Location = new Point(365, 13);
                lblopen.Size = new Size(65, 25);
                lblopen.Text = "Ban đầu";

                Label lblend = new Label();
                lblend.AutoSize = true;
                lblend.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
                lblend.Location = new Point(500, 13);
                lblend.Size = new Size(65, 25);
                lblend.Text = "Cuối cùng";

                Label lblTong = new Label();
                lblTong.AutoSize = true;
                lblTong.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
                lblTong.Location = new Point(675, 13);
                lblTong.Size = new Size(65, 25);
                lblTong.Text = "Số tiền";

                var trans1 = wd.getTransactionsByDate(acc.AccountId, dateOnly, wallet);
                int Py2 = 43;

                foreach (var trans2 in trans1)
                {
                    Panel panel3Sub = new Panel();
                    Label lblCateSub = new Label();
                    Label lblAmountSub = new Label();

                    panel3Sub.BackColor = Color.WhiteSmoke;
                    panel3Sub.Location = new Point(0, Py2);
                    panel3Sub.Size = new Size(892, 47);
                    panel3Sub.TabIndex = 3;

                    lblAmountSub.AutoSize = true;
                    lblAmountSub.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
                    lblAmountSub.Location = new Point(675, 9);
                    lblAmountSub.Size = new Size(50, 20);
                    lblAmountSub.TabIndex = 2;
                    lblAmountSub.Text = trans2.Balance.Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";

                    lblCateSub.AutoSize = true;
                    lblCateSub.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point);
                    lblCateSub.Location = new Point(16, 9);
                    lblCateSub.Size = new Size(50, 20);
                    lblCateSub.TabIndex = 1;
                    lblCateSub.Text = wd.getSCNameByID(trans2.Scid);


                    Label lblhuif = new Label();
                    lblhuif.AutoSize = true;
                    lblhuif.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point);
                    lblhuif.Location = new Point(200, 9);
                    lblhuif.Size = new Size(50, 20);
                    lblhuif.TabIndex = 1;

                    if (trans2.BudgetId != null)
                    {
                        lblhuif.ForeColor = Color.Black;
                        lblhuif.Text = context.Budgets.FirstOrDefault(b => b.BudgetId == trans2.BudgetId).BudgetName;
                    }
                    else
                    {
                        lblhuif.ForeColor = Color.Red;
                        lblhuif.Text = "Không gán";
                    }

                    PictureBox picDel = new PictureBox();
                    picDel.Image = Resources.delete;
                    picDel.Location = new Point(800, 9);
                    picDel.Size = new Size(30, 20);
                    picDel.SizeMode = PictureBoxSizeMode.Zoom;

                    picDel.Click += (sender, e) =>
                    {
                        int transID = trans2.TransactionId;

                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        { 
                            wd.deleteTransaction(transID);
                            Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
                            if (homeForm != null)
                            {
                                homeForm.btnTrans_Click(sender, e);
                            }
                        }

                    };


                    Label lblopenif = new Label();
                    lblopenif.AutoSize = true;
                    lblopenif.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point);
                    lblopenif.Location = new Point(365, 9);
                    lblopenif.Size = new Size(50, 20);
                    lblopenif.TabIndex = 1;
                    lblopenif.Text = trans2.Opening.Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";


                    Label lblendif = new Label();
                    lblendif.AutoSize = true;
                    lblendif.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point);
                    lblendif.Location = new Point(500, 9);
                    lblendif.Size = new Size(50, 20);
                    lblendif.TabIndex = 1;
                    lblendif.Text = trans2.Ending.Value.ToString("N2", CultureInfo.GetCultureInfo("vi-VN")) + "₫";

                    panel3Sub.Controls.Add(picDel);
                    panel3Sub.Controls.Add(lblAmountSub);
                    panel3Sub.Controls.Add(lblCateSub);
                    panel3Sub.Controls.Add(lblhuif);
                    panel3Sub.Controls.Add(lblopenif);
                    panel3Sub.Controls.Add(lblendif);
                    panel2.Controls.Add(panel3Sub);
                    Py2 += 47;
                }
                panel2.Controls.Add(lblTong);
                panel2.Controls.Add(lblDate);
                panel2.Controls.Add(lblhu);
                panel2.Controls.Add(lblopen);
                panel2.Controls.Add(lblend);
                panel2.Size = new Size(892, Py2);
                totalHeight += Py2;
                panel1.Controls.Add(panel2);
                Py += Py2;
                //Sy += Py2 + 10;
            }

            panel1.Size = new Size(902, totalHeight);
        }

    }
}

