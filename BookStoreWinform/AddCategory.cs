using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreWinform.CategoryService;

namespace BookStoreWinform
{
    public partial class AddCategory : Form
    {
        CategoryClient sv = null;
        List<Category> parents = null;
        Category cat = null;
        public AddCategory(int catId = 0)
        {
            InitializeComponent();
            sv = new CategoryClient();
            initComboBox();

            if (catId > 0)
            {

                cat = sv.findById(catId);
                txtName.Text = cat.Name;
                chbStatus.Checked = cat.Status.Value;
                for (int i = 0; i < parents.Count; i++)
                    if (parents[i].id == cat.ParentID)
                    {
                        cbParent.SelectedIndex = i;
                        break;
                    }
            }
        }

        private void initComboBox()
        {
            parents = sv.findAll().ToList();
            foreach (Category item in parents)
                cbParent.Items.Add(item.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cat == null)
            {
                cat = new Category();
                cat.CreatedAt = DateTime.Now;
                cat.CreatedBy = null;
                cat.Name = txtName.Text;
                cat.ParentID = parents[cbParent.SelectedIndex].id;
                cat.Status = chbStatus.Checked;
                if (sv.insert(cat) > 0)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            else
            {
                cat.Name = txtName.Text;
                cat.ParentID = parents[cbParent.SelectedIndex].id;
                cat.Status = chbStatus.Checked;
                if (sv.update(cat))
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}
