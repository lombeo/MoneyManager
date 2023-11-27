namespace MoneyManager
{
    partial class AddWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWallet));
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnAdd = new Button();
            label3 = new Label();
            txtBalance = new TextBox();
            txtWname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBalance);
            panel1.Controls.Add(txtWname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 420);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(52, 291);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 8;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 1);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(326, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(303, 220);
            label4.Name = "label4";
            label4.Size = new Size(27, 30);
            label4.TabIndex = 6;
            label4.Text = "₫";
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(277, 291);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 197);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Số dư";
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBalance.Location = new Point(52, 215);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(245, 35);
            txtBalance.TabIndex = 3;
            txtBalance.TextChanged += txtBalance_TextChanged;
            txtBalance.KeyPress += txtBalance_KeyPress;
            // 
            // txtWname
            // 
            txtWname.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtWname.Location = new Point(52, 130);
            txtWname.Name = "txtWname";
            txtWname.Size = new Size(321, 35);
            txtWname.TabIndex = 2;
            txtWname.TextChanged += txtWname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 112);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 1;
            label2.Text = "Ví này của bạn tên là gì?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "Thêm một ví";
            // 
            // AddWallet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 397);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddWallet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Wallet";
            FormClosing += AddWallet_FormClosing;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtWname;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtBalance;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private Button button1;
    }
}