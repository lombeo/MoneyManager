namespace MoneyManager
{
    partial class StartUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(32, 142, 52);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 228);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 1;
            label1.Text = "MoneyLover";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(32, 142, 52);
            button1.Location = new Point(12, 495);
            button1.Name = "button1";
            button1.Size = new Size(736, 33);
            button1.TabIndex = 2;
            button1.Text = "LẦN ĐẦU SỬ DỤNG MONEY LOVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 50, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 543);
            button2.Name = "button2";
            button2.Size = new Size(736, 33);
            button2.TabIndex = 3;
            button2.Text = "ĐÃ SỬ DỤNG MONEY LOVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 463);
            label2.Name = "label2";
            label2.Size = new Size(559, 15);
            label2.TabIndex = 4;
            label2.Text = "Mẹo đầu tiên: Bạn cần đăng nhập để có thể theo dõi quá trình quản lý chi tiêu một cách thuận tiện nhất!";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._232227;
            pictureBox2.Location = new Point(698, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 142, 52);
            ClientSize = new Size(760, 588);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += StartUp_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox2;
    }
}