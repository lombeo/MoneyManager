namespace MoneyManager
{
    partial class addSub
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 136, 77);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(25, 200);
            button2.Name = "button2";
            button2.Size = new Size(88, 44);
            button2.TabIndex = 19;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 136, 77);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(147, 200);
            button1.Name = "button1";
            button1.Size = new Size(88, 44);
            button1.TabIndex = 18;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 17;
            label3.Text = "Loại";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Transparent;
            cbCategory.CustomizableEdges = customizableEdges5;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategory.ItemHeight = 30;
            cbCategory.Location = new Point(25, 144);
            cbCategory.Name = "cbCategory";
            cbCategory.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbCategory.Size = new Size(140, 36);
            cbCategory.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 11);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 15;
            label2.Text = "Thêm danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 14;
            label1.Text = "Tên danh mục";
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(25, 78);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(210, 36);
            txtName.TabIndex = 13;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // addSub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 255);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cbCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addSub";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addSub";
            Load += addSub_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}