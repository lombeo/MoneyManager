namespace MoneyManager
{
    partial class AddTrans
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            cbSubCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            cbWallet = new Guna.UI2.WinForms.Guna2ComboBox();
            txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label7 = new Label();
            cbBudget = new Guna.UI2.WinForms.Guna2ComboBox();
            button2 = new Button();
            txtNote = new RichTextBox();
            label6 = new Label();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 126);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Số tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 198);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 273);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "Sub Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 350);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 9;
            label5.Text = "Ví";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 136, 77);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(205, 668);
            button1.Name = "button1";
            button1.Size = new Size(88, 44);
            button1.TabIndex = 10;
            button1.Text = "Lưu giao dịch";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Transparent;
            cbCategory.CustomizableEdges = customizableEdges1;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategory.ItemHeight = 30;
            cbCategory.Location = new Point(93, 216);
            cbCategory.Name = "cbCategory";
            cbCategory.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbCategory.Size = new Size(200, 36);
            cbCategory.TabIndex = 12;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cbSubCategory
            // 
            cbSubCategory.BackColor = Color.Transparent;
            cbSubCategory.CustomizableEdges = customizableEdges3;
            cbSubCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbSubCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSubCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSubCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbSubCategory.ItemHeight = 30;
            cbSubCategory.Location = new Point(93, 291);
            cbSubCategory.Name = "cbSubCategory";
            cbSubCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbSubCategory.Size = new Size(200, 36);
            cbSubCategory.TabIndex = 13;
            // 
            // cbWallet
            // 
            cbWallet.BackColor = Color.Transparent;
            cbWallet.CustomizableEdges = customizableEdges5;
            cbWallet.DrawMode = DrawMode.OwnerDrawFixed;
            cbWallet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWallet.FocusedColor = Color.FromArgb(94, 148, 255);
            cbWallet.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbWallet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbWallet.ForeColor = Color.FromArgb(68, 88, 112);
            cbWallet.ItemHeight = 30;
            cbWallet.Location = new Point(93, 368);
            cbWallet.Name = "cbWallet";
            cbWallet.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbWallet.Size = new Size(200, 36);
            cbWallet.TabIndex = 15;
            // 
            // txtAmount
            // 
            txtAmount.CustomizableEdges = customizableEdges7;
            txtAmount.DefaultText = "";
            txtAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAmount.Location = new Point(93, 144);
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.PlaceholderText = "";
            txtAmount.SelectedText = "";
            txtAmount.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtAmount.Size = new Size(200, 36);
            txtAmount.TabIndex = 16;
            txtAmount.KeyPress += guna2TextBox1_KeyPress;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2CircleButton1);
            guna2ShadowPanel1.Controls.Add(label7);
            guna2ShadowPanel1.Controls.Add(cbBudget);
            guna2ShadowPanel1.Controls.Add(button2);
            guna2ShadowPanel1.Controls.Add(txtNote);
            guna2ShadowPanel1.Controls.Add(label6);
            guna2ShadowPanel1.Controls.Add(button1);
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Controls.Add(cbWallet);
            guna2ShadowPanel1.Controls.Add(txtAmount);
            guna2ShadowPanel1.Controls.Add(label1);
            guna2ShadowPanel1.Controls.Add(cbSubCategory);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.Controls.Add(cbCategory);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(407, 739);
            guna2ShadowPanel1.TabIndex = 17;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(299, 296);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(28, 27);
            guna2CircleButton1.TabIndex = 22;
            guna2CircleButton1.Text = "+";
            guna2CircleButton1.TextOffset = new Point(1, -2);
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 425);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 21;
            label7.Text = "Hũ";
            // 
            // cbBudget
            // 
            cbBudget.BackColor = Color.Transparent;
            cbBudget.CustomizableEdges = customizableEdges10;
            cbBudget.DrawMode = DrawMode.OwnerDrawFixed;
            cbBudget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBudget.FocusedColor = Color.FromArgb(94, 148, 255);
            cbBudget.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBudget.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbBudget.ForeColor = Color.FromArgb(68, 88, 112);
            cbBudget.ItemHeight = 30;
            cbBudget.Location = new Point(93, 443);
            cbBudget.Name = "cbBudget";
            cbBudget.ShadowDecoration.CustomizableEdges = customizableEdges11;
            cbBudget.Size = new Size(200, 36);
            cbBudget.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 136, 77);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(93, 668);
            button2.Name = "button2";
            button2.Size = new Size(88, 44);
            button2.TabIndex = 19;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(93, 500);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(200, 118);
            txtNote.TabIndex = 18;
            txtNote.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 59);
            label6.Name = "label6";
            label6.Size = new Size(288, 40);
            label6.TabIndex = 17;
            label6.Text = "Thêm mới giao dịch";
            // 
            // AddTrans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 736);
            Controls.Add(guna2ShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTrans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTrans";
            FormClosing += AddTrans_FormClosing;
            Load += AddTrans_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbWallet;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label6;
        private RichTextBox txtNote;
        private Button button2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbBudget;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}