using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreWinform.ProductSV;
using BookStoreWinform.CategoryService;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;

namespace BookStoreWinform
{
    public partial class AddProduct : Form
    {
        private int mode;
        ProductSV.Product entity = new ProductSV.Product();
        Category[] cats = null;
        string filename = "";
        string existThumbnail = "";

        public AddProduct(int mode, long product = 0)
        {
            InitializeComponent();
            CategoryService.CategoryClient catSV = new CategoryClient();
            cats = catSV.findAll();
            List<string> catName = new List<string>();
            foreach (Category c in cats)
                catName.Add(c.Name);
            cbLoai.DataSource = catName;
            this.mode = mode;
            if (mode == 1)
                btnUpdate.Text = "Thêm sản phẩm";
            if (mode == 2)
            {
                entity.id = product;
                btnUpdate.Text = "Cập nhật sản phẩm";
                ProductClient sv = new ProductClient();
                Product p = sv.findById(product);
                if (p.Thumbnail != null)
                {
                    picThumbnail.Load(p.Thumbnail);
                    existThumbnail = p.Thumbnail;
                }
                    
                txtName.Text = p.Name;
                txtDongia.Text = p.Price.Value.ToString();
                txtGiagiam.Text = p.PromotionPrice.HasValue ? p.PromotionPrice.Value.ToString() : "";
                numSoluong.Value = p.Quantity.Value;
                chbHienthi.Checked = p.ShowOnHome.Value;
                chbHoatdong.Checked = p.Status.Value;

                for (int i = 0; i < cats.Length; i++)
                {
                    if (cats[i].id == p.Category)
                    {
                        cbLoai.SelectedIndex = i;
                        break;
                    }
                }

                foreach (var element in p.DescriptionXML.Elements())
                {
                    gvDescription.Rows.Add(element.Attribute("title").Value, element.Value);
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            ProductClient sv;
            switch (mode)
            {
                case 1:
                    // Thêm sản phẩm
                    LoadEntity();
                    if (filename != "")
                        entity.Thumbnail = UploadImage();
                    sv = new ProductClient();

                    if (sv.insert(entity) > -1)
                        MessageBox.Show("Thành công");
                    else
                        MessageBox.Show("Thất bại");
                    btnUpdate.Enabled = true;
                    break;
                case 2:
                    LoadEntity();
                    if (filename != "")
                        entity.Thumbnail = UploadImage();
                    sv = new ProductClient();
                    if (sv.update(entity))
                        MessageBox.Show("Thành công");
                    else
                        MessageBox.Show("Thất bại");
                    btnUpdate.Enabled = true;
                    break;
            }
        }

        private void LoadEntity()
        {
            entity.Category = cats[cbLoai.SelectedIndex].id;
            entity.Name = txtName.Text;
            entity.Price = Convert.ToDecimal(txtDongia.Text);
            entity.Promotion = Convert.ToInt32(cbKhuyenmai.SelectedValue);
            entity.PromotionPrice = Convert.ToDecimal(txtGiagiam.Text);
            entity.Quantity = Convert.ToInt32(numSoluong.Value);
            entity.Status = chbHoatdong.Checked;
            entity.ShowOnHome = chbHienthi.Checked;
            entity.CreatedAt = DateTime.Now;
            entity.Thumbnail = (existThumbnail.Trim().Length > 0) ? existThumbnail : null;

            StringBuilder sb = new StringBuilder();
            sb.Append("<detail>");
            for (int i = 0; i < gvDescription.Rows.Count - 1; i++)
                sb.Append(String.Format("<item title='{0}'>{1}</item>",
                    gvDescription.Rows[i].Cells[0].Value.ToString(),
                    gvDescription.Rows[i].Cells[1].Value.ToString()));
            sb.Append("</detail>");

            entity.Description = sb.ToString();
            XElement xmlTree = XElement.Parse(sb.ToString());
            entity.DescriptionXML = xmlTree;
        }

        private void picThumbnail_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            dialog.Multiselect = false;
            DialogResult rs = dialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                filename = dialog.FileName;
                picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
                picThumbnail.Image = Image.FromFile(filename);
            }
        }

        private string UploadImage()
        {
            string url = @"https://api.imgur.com/3/image";
            string key = @"Client-ID 453ed82ac0c751b";
            WebRequest req = WebRequest.Create(url);
            req.Headers.Add(HttpRequestHeader.Authorization, key);
            req.Method = "POST";
            byte[] data = File.ReadAllBytes(filename);
            using (var stream = req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)req.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            JObject json = JObject.Parse(responseString);
            string link = json["data"]["link"].ToString();
            return link;
        }
    }
}
