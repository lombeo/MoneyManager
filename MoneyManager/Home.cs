using Guna.UI2.WinForms.Suite;
using MoneyManager.Controllers;
using MoneyManager.Models;
using MoneyManager.Properties;
using MoneyManager.UserControls;
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

namespace MoneyManager
{
    public partial class Home : Form
    {
        MoneyManagerContext context = new MoneyManagerContext();
        Account acc;
        WalletDAO wd = new WalletDAO();
        Wallet wlet;
        List<Wallet> list;
        public Home(Account data)
        {
            InitializeComponent();
            acc = data;
        }

        public void Home_Load(object sender, EventArgs e)
        {
            if (wlet == null)
            {
                wlet = wd.GetWallet(acc.AccountId);
            }

            lblWName.Text = wlet.WalletName;
            string balance = wlet.Balance.Value.ToString("N2", CultureInfo.GetCultureInfo("en-US")) + "VNĐ";
            lblBalance.Text = balance;
            btnTrans_Click(sender, e);
        }

        public void UpdateUI(Wallet w)
        {
            EventArgs e = new EventArgs();
            wlet = w;
            lblWName.Text = w.WalletName;
            string balance = w.Balance.Value.ToString("N2", CultureInfo.GetCultureInfo("en-US")) + "VNĐ";
            lblBalance.Text = balance;
        }

        public void btnMWallet_Click(object sender, EventArgs e)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            list = context.Wallets.Where(w => w.AccountId == acc.AccountId).ToList();
            panel8.Controls.Clear();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Panel panel3 = new Panel();
            Panel panel4 = new Panel();
            Panel panel6 = new Panel();
            Button button1 = new Button();
            Label lblBalanceTotal = new Label();
            Label lblTotal = new Label();
            PictureBox pictureBox2 = new PictureBox();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(85, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 514);
            panel3.TabIndex = 1;

            int y = 150; // Vị trí dọc ban đầu của các điều khiển trên form

            foreach (Wallet wallet in list)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.Silver;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(196, y);
                panel.Size = new Size(530, 58);

                panel.Click += (sender, e) =>
                {
                    // Lấy WalletID của Wallet tương ứng
                    int walletID = wallet.WalletId;
                    // Xử lý logic với WalletID
                    wlet = wd.GetWalletById(walletID);
                    MessageBox.Show("Ví đã được chuyển sang " + wlet.WalletName);
                    Home_Load(sender, e);
                };

                Label label4 = new Label();
                label4.AutoSize = true;
                label4.Location = new Point(71, 30);
                label4.Text = wallet.WalletName;

                Label label3 = new Label();
                label3.AutoSize = true;
                label3.BackColor = Color.Transparent;
                label3.ForeColor = Color.FromArgb(64, 64, 64);
                label3.Location = new Point(71, 10);
                label3.Text = wallet.Balance.Value.ToString("N2", CultureInfo.GetCultureInfo("en-US")) + "VNĐ";

                PictureBox pictureBox3 = new PictureBox();
                pictureBox3.Image = (Image)resources.GetObject("pictureBox1.Image");
                pictureBox3.Location = new Point(20, 11);
                pictureBox3.Size = new Size(45, 38);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

                PictureBox picDel = new PictureBox();
                picDel.Image = Resources.delete;
                picDel.Location = new Point(480, 18);
                picDel.Size = new Size(30, 20);
                picDel.SizeMode = PictureBoxSizeMode.Zoom;

                picDel.Click += (sender, e) =>
                {
                    // Lấy WalletID của Wallet tương ứng
                    int walletID = wallet.WalletId;
                    // Xử lý logic với WalletID
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ví này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Xử lý xóa Wallet
                        if (list.Count == 1)
                        {
                            MessageBox.Show("Không thể xóa ví bởi vì bạn cần ít nhất một ví để sử dụng!");
                        }
                        else
                        {
                            var transactionsToDelete = context.Transactions.Where(t => t.WalletId == walletID);
                            context.Transactions.RemoveRange(transactionsToDelete);
                            var budgetToDelete = context.Budgets.Where(t => t.WalletId == walletID);
                            context.Budgets.RemoveRange(budgetToDelete);
                            context.SaveChanges();
                            wd.DeleteWallet(walletID);
                            btnMWallet_Click(sender, e);
                        }

                    }

                };

                panel.Controls.Add(label4);
                panel.Controls.Add(label3);
                panel.Controls.Add(pictureBox3);
                panel.Controls.Add(picDel);
                panel8.Controls.Add(panel);
                y += 70;
            }

            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(lblBalanceTotal);
            panel4.Controls.Add(lblTotal);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(-1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(750, 64);
            panel4.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Location = new Point(627, 11);
            panel6.Name = "panel6";
            panel6.Size = new Size(117, 38);
            panel6.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Image = Resources.plus_button__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-5, -12);
            button1.Name = "button1";
            button1.Size = new Size(126, 65);
            button1.TabIndex = 2;
            button1.Text = "Add wallet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblBalanceTotal
            // 
            lblBalanceTotal.AutoSize = true;
            lblBalanceTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalanceTotal.Location = new Point(72, 34);
            lblBalanceTotal.Name = "lblBalanceTotal";
            lblBalanceTotal.Size = new Size(38, 15);
            lblBalanceTotal.TabIndex = 2;
            lblBalanceTotal.Text = wd.GetBalance(acc.AccountId).Value.ToString("N2", CultureInfo.GetCultureInfo("en-US")) + "VNĐ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(69, 3);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 21);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.global1;
            pictureBox2.Location = new Point(19, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;

            panel8.Controls.Add(panel3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (context.Wallets.Where(w => w.AccountId == acc.AccountId).ToList().Count >= 6)
            {
                MessageBox.Show("Số lượng ví của bạn đã đạt tối đa!");
            }
            else
            {
                AddWallet frm = new AddWallet(acc);
                frm.ShowDialog();
            }
        }

        public void btnTrans_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();

            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(9, 72);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(917, 601);
            panelContainer.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(guna2Button2);
            panel3.Controls.Add(guna2Button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(929, 66);
            panel3.TabIndex = 0;
            // 
            // guna2Button2
            // 
            guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button2.Checked = true;
            guna2Button2.CheckedState.CustomBorderColor = Color.DimGray;
            guna2Button2.CheckedState.FillColor = Color.White;
            guna2Button2.CustomBorderColor = Color.Transparent;
            guna2Button2.CustomBorderThickness = new Padding(0, 0, 0, 4);
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.HoverState.CustomBorderColor = Color.DimGray;
            guna2Button2.Location = new Point(466, 0);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(466, 66);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Tháng này";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button1.CheckedState.CustomBorderColor = Color.DimGray;
            guna2Button1.CheckedState.FillColor = Color.White;
            guna2Button1.CustomBorderColor = Color.Transparent;
            guna2Button1.CustomBorderThickness = new Padding(0, 0, 0, 4);
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.HoverState.CustomBorderColor = Color.DimGray;
            guna2Button1.Location = new Point(3, 0);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(466, 66);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Quá khứ";
            guna2Button1.Click += guna2Button1_Click;

            panel8.Controls.Add(panelContainer);
            panel8.Controls.Add(panel3);
            guna2Button2_Click(sender, e);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LastMonth lastMonth = new LastMonth(acc, wlet);
            addUserControl(lastMonth);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ThisMonth thisMonth = new ThisMonth(acc, wlet);
            addUserControl(thisMonth);
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            AddTrans frm = new AddTrans(acc, wlet);
            frm.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            btnMWallet_Click(sender, e);
        }



        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartUp frm = new StartUp();
                frm.Show();
                this.Hide();
            }
        }

        public void btnBudget_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            guna2Button4_Click(sender, e);
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Guna2Button btnFinish = new Guna.UI2.WinForms.Guna2Button();
            Guna.UI2.WinForms.Guna2Button btnRunning = new Guna.UI2.WinForms.Guna2Button();
            Panel panel6 = new Panel();
            // 
            // btnFinish
            // 
            btnFinish.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnFinish.CheckedState.CustomBorderColor = Color.Gray;
            btnFinish.CustomBorderColor = Color.Transparent;
            btnFinish.CustomBorderThickness = new Padding(0, 0, 0, 4);
            btnFinish.CustomizableEdges = customizableEdges1;
            btnFinish.DisabledState.BorderColor = Color.DarkGray;
            btnFinish.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFinish.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFinish.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFinish.FillColor = Color.White;
            btnFinish.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinish.ForeColor = Color.Black;
            btnFinish.HoverState.CustomBorderColor = Color.Transparent;
            btnFinish.Location = new Point(460, 0);
            btnFinish.Name = "btnFinish";
            btnFinish.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFinish.Size = new Size(466, 83);
            btnFinish.TabIndex = 1;
            btnFinish.Text = "Đã hoàn thành";
            btnFinish.Click += guna2Button5_Click;
            // 
            // btnRunning
            // 
            btnRunning.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnRunning.Checked = true;
            btnRunning.CheckedState.CustomBorderColor = Color.Gray;
            btnRunning.CustomBorderColor = Color.Transparent;
            btnRunning.CustomBorderThickness = new Padding(0, 0, 0, 4);
            btnRunning.CustomizableEdges = customizableEdges3;
            btnRunning.DisabledState.BorderColor = Color.DarkGray;
            btnRunning.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRunning.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRunning.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRunning.FillColor = Color.White;
            btnRunning.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRunning.ForeColor = Color.Black;
            btnRunning.HoverState.CustomBorderColor = Color.Transparent;
            btnRunning.Location = new Point(0, 0);
            btnRunning.Name = "btnRunning";
            btnRunning.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRunning.Size = new Size(461, 83);
            btnRunning.TabIndex = 0;
            btnRunning.Text = "Đang chạy";
            btnRunning.Click += guna2Button4_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnFinish);
            panel6.Controls.Add(btnRunning);
            panel6.Location = new Point(3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(926, 83);
            panel6.TabIndex = 1;
            //
            //panelContainer
            //
            panelContainer.Location = new Point(9, 84);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(917, 601);
            panelContainer.TabIndex = 1;
            panel8.Controls.Add(panelContainer);
            panel8.Controls.Add(panel6);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Running running = new Running(acc, wlet);
            addUserControl(running);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Finish frm = new Finish(acc, wlet);
            addUserControl(frm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
