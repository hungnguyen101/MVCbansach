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
    public partial class frmCategory : Form
    {
        private CategoryClient svCategory = null;
        Category[] categories;
        public frmCategory()
        {
            InitializeComponent();
            svCategory = new CategoryClient();

            bindData();
            
        }

        private void bindData()
        {
            List<string> catName = new List<string>();
            categories = svCategory.findAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tiêu đề", typeof(string));
            dt.Columns.Add("Hiển thị", typeof(bool));
            dt.Columns.Add("Thuộc thể loại", typeof(string));

            foreach (var cat in categories)
            {
                dt.Rows.Add(cat.Name, cat.Status, 
                    (cat.ParentID > 0) ? categories.SingleOrDefault(c => c.id == cat.ParentID).Name : "");
            }
            foreach (DataGridViewRow row in gvLoaiSP.Rows)
                row.Cells[2].ReadOnly = true;
            gvLoaiSP.DataSource = dt;
            

            //DataGridViewComboBoxColumn dccParent = new DataGridViewComboBoxColumn();
            //dccParent.HeaderText = "Loại cha";
            //dccParent.ValueMember = "Value";
            //dccParent.Name = "parent";
            //dccParent.Items.AddRange(catName.ToArray());
            //dccParent.MaxDropDownItems = 4;
            //gvLoaiSP.Columns.Add(dccParent);
            //(gvLoaiSP.Rows[1].Cells[2] as DataGridViewComboBoxCell).Value = dccParent.Items[1];

            //string name = "";
            //for (int i = 0; i < catName.Count; i++)
            //{
            //    if (categories[i].ParentID > 0)
            //    {
            //        name = categories.First(c => c.id == categories[i].ParentID).Name;
            //        gvLoaiSP.Rows[i].Cells[dccParent.Name].Value = name;
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gvLoaiSP.DataSource = null;
            bindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCategory frm = new AddCategory();
            frm.Show();
        }

        private void gvLoaiSP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menuGribView.Show(Cursor.Position);
            }
        }

        private void menuGribView_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Chỉnh sửa":
                    AddCategory frm = new AddCategory(categories[gvLoaiSP.CurrentRow.Index].id);
                    frm.Show();
                    break;
                case "Xoá":
                    DialogResult rs = MessageBox.Show("Chắc chắn xoá? Sẽ ảnh hướng đến các sản phẩm thuộc thể loại này?",
                        "Cảnh báo", MessageBoxButtons.OKCancel);
                    if (rs == System.Windows.Forms.DialogResult.OK)
                    {
                        if (svCategory.delete(categories[gvLoaiSP.CurrentRow.Index].id))
                            MessageBox.Show("Thành công");
                        else
                            MessageBox.Show("Thất bại");
                    }
                    break;
            }
        }
    }
}
