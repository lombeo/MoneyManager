using System.Runtime.InteropServices;

namespace MoneyManager
{

    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            linkReg = new LinkLabel();
            label4 = new Label();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(32, 142, 52);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(274, 127);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 2;
            label1.Text = "MoneyLover";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkReg);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(54, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 372);
            panel1.TabIndex = 3;
            // 
            // linkReg
            // 
            linkReg.AutoSize = true;
            linkReg.LinkColor = Color.Green;
            linkReg.Location = new Point(367, 315);
            linkReg.Name = "linkReg";
            linkReg.Size = new Size(102, 15);
            linkReg.TabIndex = 6;
            linkReg.TabStop = true;
            linkReg.Text = "Đăng ký tài khoản";
            linkReg.LinkClicked += linkReg_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 315);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 5;
            label4.Text = "Chưa có tài khoản?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(98, 190, 47);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(98, 190, 47);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(98, 170, 47);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(98, 160, 47);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(178, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(291, 37);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(244, 244, 244);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.FromArgb(244, 244, 244);
            txtPass.Location = new Point(178, 193);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(291, 36);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password";
            txtPass.Enter += TxtPass_Enter;
            txtPass.Leave += TxtPass_Leave;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(244, 244, 244);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(244, 244, 244);
            txtEmail.Location = new Point(178, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 36);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email";
            txtEmail.Enter += TxtEmail_Enter;
            txtEmail.Leave += TxtEmail_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 103);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 1;
            label3.Text = "Sử dụng tài khoản Money Lover";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(250, 24);
            label2.Name = "label2";
            label2.Size = new Size(158, 29);
            label2.TabIndex = 0;
            label2.Text = "Đăng nhập";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._232227;
            pictureBox2.Location = new Point(698, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 142, 52);
            ClientSize = new Size(760, 588);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '●';
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private LinkLabel linkReg;
        private Label label4;
        private Button btnLogin;
        private PictureBox pictureBox2;
    }
}