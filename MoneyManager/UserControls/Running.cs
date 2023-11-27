using Guna.UI2.WinForms.Suite;
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
using System.Windows.Forms;

namespace MoneyManager.UserControls
{
    public partial class Running : UserControl
    {
        Account acc;
        WalletDAO wd = new WalletDAO();
        Wallet wal;
        public Running(Account data, Wallet wal)
        {
            InitializeComponent();
            acc = data;
            this.wal = wal;
        }

        private void Running_Load(object sender, EventArgs e)
        {
            List<Budget> list = wd.GetBudgetsByAccId(acc.AccountId, wal.WalletId);
            if (list != null)
            {
                foreach (Budget b in list)
                {
                    Guna.UI2.WinForms.Guna2ShadowPanel panelSub = new Guna.UI2.WinForms.Guna2ShadowPanel();
                    Label lblCate = new Label();
                    Panel panelDate = new Panel();
                    Label lblDate = new Label();
                    PictureBox picDel = new PictureBox();
                    PictureBox pictureBox1 = new PictureBox();
                    Label lblLeft = new Label();
                    Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
                    Label lblAmount = new Label();
                    Label lblName = new Label();
                    Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                    Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                    panelSub.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
                    panelDate.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)picDel).BeginInit();

                    // 
                    // panelSub
                    // 

                    panelSub.BackColor = Color.Transparent;
                    panelSub.Controls.Add(pictureBox1);
                    panelSub.Controls.Add(lblCate);
                    panelSub.Controls.Add(lblLeft);
                    panelSub.Controls.Add(guna2ProgressBar1);
                    panelSub.Controls.Add(lblAmount);
                    panelSub.Controls.Add(lblName);
                    panelSub.Controls.Add(panelDate);
                    panelSub.Controls.Add(picDel);
                    panelSub.FillColor = Color.White;
                    panelSub.Location = new Point(90, 20);
                    panelSub.Name = "panelSub";
                    panelSub.ShadowColor = Color.Black;
                    panelSub.Size = new Size(714, 100);
                    panelSub.TabIndex = 0;
                    // 
                    // pictureBox1
                    // 
                    pictureBox1.Image = Resources.pngwing_com__1_;
                    pictureBox1.Location = new Point(39, 44);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new Size(41, 39);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.TabIndex = 6;
                    pictureBox1.TabStop = false;
                    // 
                    // lblCate
                    // 
                    lblCate.AutoSize = true;
                    lblCate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    lblCate.Location = new Point(322, 10);
                    lblCate.Name = "lblCate";
                    lblCate.Size = new Size(57, 21);
                    lblCate.TabIndex = 5;
                    lblCate.Text = wd.getSCNameByID(b.Scid);
                    // 
                    // lblLeft
                    // 
                    lblLeft.AutoSize = true;
                    lblLeft.Location = new Point(400, 54);
                    lblLeft.Name = "lblLeft";
                    lblLeft.Size = new Size(38, 15);
                    lblLeft.TabIndex = 4;
                    lblLeft.Text = wd.GetRemainingBudgetAmount(b.BudgetId).Value.ToString("N2", CultureInfo.GetCultureInfo("en-US")) + "₫";
                    lblLeft.TextAlign = ContentAlignment.MiddleLeft;
                    // 
                    // guna2ProgressBar1
                    // 
                    decimal? totalTransactionBalance = wd.GetTotalTransactionBalance(b.BudgetId);
                    decimal? progressPercentage = (totalTransactionBalance / b.Amount) * 100;

                    guna2ProgressBar1.CustomizableEdges = customizableEdges3;
                    guna2ProgressBar1.Location = new Point(119, 73);
                    guna2ProgressBar1.Name = "guna2ProgressBar1";
                    guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges4;
                    guna2ProgressBar1.Size = new Size(510, 10);
                    guna2ProgressBar1.TabIndex = 3;
                    guna2ProgressBar1.Minimum = 0;
                    if(b.Amount < Int32.MaxValue)
                    {
                        guna2ProgressBar1.Maximum = (int)b.Amount;
                    }
                    else
                    {
                        guna2ProgressBar1.Maximum = Int32.MaxValue;
                    }
                    
                    guna2ProgressBar1.Value = (int)totalTransactionBalance;
                    guna2ProgressBar1.Text = progressPercentage.Value.ToString("0.00") + "%";

                    // Thay đổi màu sắc của progressBar dựa trên giá trị balance
                    if (totalTransactionBalance > b.Amount)
                    {
                        guna2ProgressBar1.ProgressColor = Color.Red;
                    }
                    else
                    {
                        guna2ProgressBar1.ProgressColor = Color.FromArgb(139, 201, 77);
                    }

                    guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;


                    // 
                    // lblAmount
                    // 
                    lblAmount.AutoSize = true;
                    lblAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    lblAmount.Location = new Point(400, 37);
                    lblAmount.Name = "lblAmount";
                    lblAmount.Size = new Size(45, 17);
                    lblAmount.TabIndex = 2;
                    lblAmount.Text = b.Amount.Value.ToString("N2", CultureInfo.GetCultureInfo("en-US")) + "₫";
                    lblAmount.TextAlign = ContentAlignment.MiddleLeft;
                    // 
                    // lblName
                    // 
                    lblName.AutoSize = true;
                    lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    lblName.Location = new Point(119, 49);
                    lblName.Name = "lblName";
                    lblName.Size = new Size(57, 21);
                    lblName.TabIndex = 1;
                    lblName.Text = b.BudgetName;
                    // 
                    // panelDate
                    // 
                    panelDate.BackColor = Color.Silver;
                    panelDate.Controls.Add(lblDate);
                    panelDate.Location = new Point(3, 6);
                    panelDate.Name = "panelDate";
                    panelDate.Size = new Size(304, 32);
                    panelDate.TabIndex = 0;
                    // 
                    // lblDate
                    // 
                    lblDate.AutoSize = true;
                    lblDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
                    lblDate.ForeColor = Color.FromArgb(64, 64, 64);
                    lblDate.Location = new Point(10, 5);
                    lblDate.Name = "lblDate";
                    lblDate.Size = new Size(51, 20);
                    lblDate.TabIndex = 0;
                    lblDate.Text = b.From.ToString() + " đến " + b.To.ToString();
                    // 
                    // picDel
                    // 
                    picDel.Image = Resources.delete;
                    picDel.Location = new Point(662, 37);
                    picDel.Name = "picDel";
                    picDel.Size = new Size(35, 27);
                    picDel.SizeMode = PictureBoxSizeMode.Zoom;
                    picDel.TabIndex = 7;
                    picDel.TabStop = false;
                    picDel.Click += (sender, e) =>
                    {
                        int budgetId = b.BudgetId;

                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hũ này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            wd.deleteBudgetByBudgetId(budgetId);
                            Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
                            if (homeForm != null)
                            {
                                homeForm.btnTrans_Click(sender, e);
                            }
                        }

                    };

                    panelSub.ResumeLayout(false);
                    panelSub.PerformLayout();
                    ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
                    panelDate.ResumeLayout(false);
                    panelDate.PerformLayout();
                    ((System.ComponentModel.ISupportInitialize)picDel).EndInit();
                    panelCont.Controls.Add(panelSub);

                }
            }
        }

        private void btnAddBud_Click(object sender, EventArgs e)
        {
            AddBud frm = new AddBud(acc);
            frm.ShowDialog();
        }
    }
}
