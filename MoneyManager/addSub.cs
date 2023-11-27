using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class addSub : Form
    {
        public addSub()
        {
            InitializeComponent();
        }

        private void addSub_Load(object sender, EventArgs e)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            cbCategory.DataSource = context.Categories.ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                MoneyManagerContext context = new MoneyManagerContext();
                context.SubCategories.Add(new SubCategory(txtName.Text, (int)cbCategory.SelectedValue));
                context.SaveChanges();
                MessageBox.Show("Thêm danh mục thành công!");
                AddTrans homeForm = Application.OpenForms.OfType<AddTrans>().FirstOrDefault();
                if(homeForm != null)
                {
                    homeForm.AddTrans_Load(sender, e);
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần nhập tên danh mục!");
            }
        }
    }
}
