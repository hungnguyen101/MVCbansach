namespace BookStoreWinform
{
    partial class frmProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTinhtrang = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.gvDescription = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(22, 24);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(125, 23);
            this.btnCapnhat.TabIndex = 0;
            this.btnCapnhat.Text = " Cập nhật dữ liệu";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // gvProduct
            // 
            this.gvProduct.AllowUserToAddRows = false;
            this.gvProduct.AllowUserToDeleteRows = false;
            this.gvProduct.AllowUserToOrderColumns = true;
            this.gvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(22, 53);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.ReadOnly = true;
            this.gvProduct.Size = new System.Drawing.Size(413, 457);
            this.gvProduct.TabIndex = 1;
            this.gvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProduct_CellClick);
            this.gvProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvProduct_MouseClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(570, 53);
            this.lblName.MaximumSize = new System.Drawing.Size(230, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày tạo:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(628, 106);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(35, 13);
            this.lblCreatedBy.TabIndex = 9;
            this.lblCreatedBy.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tình trạng:";
            // 
            // lblTinhtrang
            // 
            this.lblTinhtrang.AutoSize = true;
            this.lblTinhtrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTinhtrang.Location = new System.Drawing.Point(634, 135);
            this.lblTinhtrang.Name = "lblTinhtrang";
            this.lblTinhtrang.Size = new System.Drawing.Size(35, 13);
            this.lblTinhtrang.TabIndex = 11;
            this.lblTinhtrang.Text = "label2";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(153, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gvDescription
            // 
            this.gvDescription.AllowUserToAddRows = false;
            this.gvDescription.AllowUserToDeleteRows = false;
            this.gvDescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDescription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.value});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDescription.Location = new System.Drawing.Point(451, 214);
            this.gvDescription.Name = "gvDescription";
            this.gvDescription.ReadOnly = true;
            this.gvDescription.Size = new System.Drawing.Size(353, 296);
            this.gvDescription.TabIndex = 13;
            // 
            // title
            // 
            this.title.HeaderText = "Tiêu đề";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "Giá trị";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookStoreWinform.Properties.Resources.thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(451, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // menuGridView
            // 
            this.menuGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem,
            this.xoáToolStripMenuItem});
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.Size = new System.Drawing.Size(128, 48);
            this.menuGridView.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuGridView_ItemClicked);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.xoáToolStripMenuItem.Text = "Xoá";
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(263, 26);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(172, 21);
            this.cbLoai.TabIndex = 15;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Loại sản phẩm:";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(655, 164);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(35, 13);
            this.lblLoai.TabIndex = 17;
            this.lblLoai.Text = "label2";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 528);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvDescription);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTinhtrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.btnCapnhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.Text = "Quản lý sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTinhtrang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip menuGridView;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoai;
    }
}

