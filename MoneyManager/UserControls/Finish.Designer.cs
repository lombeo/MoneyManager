namespace MoneyManager.UserControls
{
    partial class Finish
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
            panelCont = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panelTong = new Panel();
            panelHead = new Panel();
            panel1 = new Panel();
            lblTitle = new Label();
            panelButtonCre = new Panel();
            btnAddBud = new Button();
            panelTong.SuspendLayout();
            panelHead.SuspendLayout();
            panelButtonCre.SuspendLayout();
            SuspendLayout();
            // 
            // panelCont
            // 
            panelCont.AutoScroll = true;
            panelCont.BackColor = Color.Transparent;
            panelCont.FillColor = Color.White;
            panelCont.Location = new Point(0, 98);
            panelCont.Name = "panelCont";
            panelCont.ShadowColor = Color.Black;
            panelCont.Size = new Size(908, 494);
            panelCont.TabIndex = 9;
            // 
            // panelTong
            // 
            panelTong.Controls.Add(panelCont);
            panelTong.Controls.Add(panelHead);
            panelTong.Location = new Point(0, 0);
            panelTong.Name = "panelTong";
            panelTong.Size = new Size(908, 592);
            panelTong.TabIndex = 4;
            // 
            // panelHead
            // 
            panelHead.BackColor = Color.Silver;
            panelHead.Controls.Add(panel1);
            panelHead.Controls.Add(lblTitle);
            panelHead.Controls.Add(panelButtonCre);
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(908, 100);
            panelHead.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 494);
            panel1.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(34, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 32);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Hũ ngân sách";
            // 
            // panelButtonCre
            // 
            panelButtonCre.BackColor = Color.White;
            panelButtonCre.BorderStyle = BorderStyle.FixedSingle;
            panelButtonCre.Controls.Add(btnAddBud);
            panelButtonCre.Cursor = Cursors.Hand;
            panelButtonCre.Location = new Point(693, 25);
            panelButtonCre.Name = "panelButtonCre";
            panelButtonCre.Size = new Size(181, 39);
            panelButtonCre.TabIndex = 4;
            // 
            // btnAddBud
            // 
            btnAddBud.BackColor = Color.Silver;
            btnAddBud.FlatAppearance.BorderColor = Color.Black;
            btnAddBud.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAddBud.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAddBud.FlatStyle = FlatStyle.Flat;
            btnAddBud.ForeColor = Color.Black;
            btnAddBud.Image = Properties.Resources.plus__1_;
            btnAddBud.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBud.Location = new Point(-12, -15);
            btnAddBud.Name = "btnAddBud";
            btnAddBud.Padding = new Padding(20, 0, 0, 0);
            btnAddBud.Size = new Size(226, 68);
            btnAddBud.TabIndex = 2;
            btnAddBud.Text = "Tạo hũ ngân sách";
            btnAddBud.UseVisualStyleBackColor = false;
            btnAddBud.Click += btnAddBud_Click;
            // 
            // Finish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTong);
            Name = "Finish";
            Size = new Size(908, 592);
            Load += Finish_Load;
            panelTong.ResumeLayout(false);
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            panelButtonCre.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panelCont;
        private Panel panelTong;
        private Panel panelHead;
        private Panel panel1;
        private Label lblTitle;
        private Panel panelButtonCre;
        private Button btnAddBud;
    }
}
