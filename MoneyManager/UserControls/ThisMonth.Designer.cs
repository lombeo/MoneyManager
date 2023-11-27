namespace MoneyManager.UserControls
{
    partial class ThisMonth
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            panel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panel6 = new Panel();
            lblChenh = new Label();
            lblEnding = new Label();
            lblOpen = new Label();
            label3 = new Label();
            panel7 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(908, 592);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.FillColor = Color.White;
            panel1.Location = new Point(3, 104);
            panel1.Name = "panel1";
            panel1.ShadowColor = Color.Black;
            panel1.Size = new Size(902, 485);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblChenh);
            panel6.Controls.Add(lblEnding);
            panel6.Controls.Add(lblOpen);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(908, 98);
            panel6.TabIndex = 0;
            // 
            // lblChenh
            // 
            lblChenh.AutoSize = true;
            lblChenh.Location = new Point(119, 72);
            lblChenh.Name = "lblChenh";
            lblChenh.Size = new Size(38, 15);
            lblChenh.TabIndex = 6;
            lblChenh.Text = "label6";
            // 
            // lblEnding
            // 
            lblEnding.AutoSize = true;
            lblEnding.Location = new Point(119, 42);
            lblEnding.Name = "lblEnding";
            lblEnding.Size = new Size(38, 15);
            lblEnding.TabIndex = 5;
            lblEnding.Text = "label5";
            // 
            // lblOpen
            // 
            lblOpen.AutoSize = true;
            lblOpen.Location = new Point(119, 12);
            lblOpen.Name = "lblOpen";
            lblOpen.Size = new Size(38, 15);
            lblOpen.TabIndex = 4;
            lblOpen.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Chênh lệch:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Location = new Point(16, 68);
            panel7.Name = "panel7";
            panel7.Size = new Size(205, 1);
            panel7.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 42);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Số dư cuối cùng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Số dư ban đầu:";
            // 
            // ThisMonth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Name = "ThisMonth";
            Size = new Size(908, 592);
            Load += ThisMonth_Load;
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel6;
        private Label lblChenh;
        private Label lblEnding;
        private Label lblOpen;
        private Label label3;
        private Panel panel7;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel1;
    }
}
