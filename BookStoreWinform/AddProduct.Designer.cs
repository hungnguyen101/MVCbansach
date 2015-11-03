namespace BookStoreWinform
{
    partial class AddProduct
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
            this.picThumbnail = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbHoatdong = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiagiam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKhuyenmai = new System.Windows.Forms.ComboBox();
            this.btnThemkhuyenmai = new System.Windows.Forms.Button();
            this.gvDescription = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chbHienthi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // picThumbnail
            // 
            this.picThumbnail.Image = global::BookStoreWinform.Properties.Resources.thumbnail;
            this.picThumbnail.Location = new System.Drawing.Point(10, 31);
            this.picThumbnail.Name = "picThumbnail";
            this.picThumbnail.Size = new System.Drawing.Size(166, 236);
            this.picThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picThumbnail.TabIndex = 0;
            this.picThumbnail.TabStop = false;
            this.picThumbnail.Click += new System.EventHandler(this.picThumbnail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(283, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng:";
            // 
            // numSoluong
            // 
            this.numSoluong.Location = new System.Drawing.Point(283, 69);
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(47, 20);
            this.numSoluong.TabIndex = 4;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(283, 112);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(109, 20);
            this.txtDongia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = " Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " VND";
            // 
            // chbHoatdong
            // 
            this.chbHoatdong.AutoSize = true;
            this.chbHoatdong.Checked = true;
            this.chbHoatdong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHoatdong.Location = new System.Drawing.Point(354, 70);
            this.chbHoatdong.Name = "chbHoatdong";
            this.chbHoatdong.Size = new System.Drawing.Size(77, 17);
            this.chbHoatdong.TabIndex = 8;
            this.chbHoatdong.Text = "Hoạt động";
            this.chbHoatdong.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = " Loại sản phẩm:";
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(283, 155);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(219, 21);
            this.cbLoai.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giá giảm:";
            // 
            // txtGiagiam
            // 
            this.txtGiagiam.Location = new System.Drawing.Point(283, 200);
            this.txtGiagiam.Name = "txtGiagiam";
            this.txtGiagiam.Size = new System.Drawing.Size(109, 20);
            this.txtGiagiam.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = " VND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Khuyến mãi:";
            // 
            // cbKhuyenmai
            // 
            this.cbKhuyenmai.FormattingEnabled = true;
            this.cbKhuyenmai.Location = new System.Drawing.Point(283, 246);
            this.cbKhuyenmai.Name = "cbKhuyenmai";
            this.cbKhuyenmai.Size = new System.Drawing.Size(148, 21);
            this.cbKhuyenmai.TabIndex = 15;
            // 
            // btnThemkhuyenmai
            // 
            this.btnThemkhuyenmai.Location = new System.Drawing.Point(439, 244);
            this.btnThemkhuyenmai.Name = "btnThemkhuyenmai";
            this.btnThemkhuyenmai.Size = new System.Drawing.Size(63, 23);
            this.btnThemkhuyenmai.TabIndex = 16;
            this.btnThemkhuyenmai.Text = "Tạo mới";
            this.btnThemkhuyenmai.UseVisualStyleBackColor = true;
            // 
            // gvDescription
            // 
            this.gvDescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDescription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.value});
            this.gvDescription.Location = new System.Drawing.Point(10, 284);
            this.gvDescription.Name = "gvDescription";
            this.gvDescription.Size = new System.Drawing.Size(492, 174);
            this.gvDescription.TabIndex = 17;
            // 
            // title
            // 
            this.title.HeaderText = "Tiêu đề";
            this.title.Name = "title";
            // 
            // value
            // 
            this.value.HeaderText = "Giá trị";
            this.value.Name = "value";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 468);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(490, 34);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Thêm sản phẩm";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chbHienthi
            // 
            this.chbHienthi.AutoSize = true;
            this.chbHienthi.Checked = true;
            this.chbHienthi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHienthi.Location = new System.Drawing.Point(434, 70);
            this.chbHienthi.Name = "chbHienthi";
            this.chbHienthi.Size = new System.Drawing.Size(62, 17);
            this.chbHienthi.TabIndex = 19;
            this.chbHienthi.Text = "Hiển thị";
            this.chbHienthi.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 514);
            this.Controls.Add(this.chbHienthi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gvDescription);
            this.Controls.Add(this.btnThemkhuyenmai);
            this.Controls.Add(this.cbKhuyenmai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGiagiam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chbHoatdong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.numSoluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picThumbnail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.Text = "Thông tin sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSoluong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbHoatdong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiagiam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKhuyenmai;
        private System.Windows.Forms.Button btnThemkhuyenmai;
        private System.Windows.Forms.DataGridView gvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chbHienthi;
    }
}