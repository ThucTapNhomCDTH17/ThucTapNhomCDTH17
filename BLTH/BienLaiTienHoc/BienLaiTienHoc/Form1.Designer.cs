namespace BienLaiTienHoc
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.soBienLaiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietBienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet1 = new BienLaiTienHoc.QLThuHocPhiSV1DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBienLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienLaiTienHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet = new BienLaiTienHoc.QLThuHocPhiSV1DataSet();
            this.cmbsobl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtnguoithu = new System.Windows.Forms.TextBox();
            this.txtngaythu = new System.Windows.Forms.TextBox();
            this.txtsobl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bienLaiTienHocTableAdapter = new BienLaiTienHoc.QLThuHocPhiSV1DataSetTableAdapters.BienLaiTienHocTableAdapter();
            this.chiTietBienLaiTableAdapter = new BienLaiTienHoc.QLThuHocPhiSV1DataSet1TableAdapters.ChiTietBienLaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBienLaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienLaiTienHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soBienLaiDataGridViewTextBoxColumn1,
            this.maMonHocDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.chiTietBienLaiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(663, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(232, 150);
            this.dataGridView2.TabIndex = 39;
            // 
            // soBienLaiDataGridViewTextBoxColumn1
            // 
            this.soBienLaiDataGridViewTextBoxColumn1.DataPropertyName = "SoBienLai";
            this.soBienLaiDataGridViewTextBoxColumn1.HeaderText = "SoBienLai";
            this.soBienLaiDataGridViewTextBoxColumn1.Name = "soBienLaiDataGridViewTextBoxColumn1";
            // 
            // maMonHocDataGridViewTextBoxColumn
            // 
            this.maMonHocDataGridViewTextBoxColumn.DataPropertyName = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.HeaderText = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.Name = "maMonHocDataGridViewTextBoxColumn";
            // 
            // chiTietBienLaiBindingSource
            // 
            this.chiTietBienLaiBindingSource.DataMember = "ChiTietBienLai";
            this.chiTietBienLaiBindingSource.DataSource = this.qLThuHocPhiSV1DataSet1;
            // 
            // qLThuHocPhiSV1DataSet1
            // 
            this.qLThuHocPhiSV1DataSet1.DataSetName = "QLThuHocPhiSV1DataSet1";
            this.qLThuHocPhiSV1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.soBienLaiDataGridViewTextBoxColumn,
            this.ngayThuDataGridViewTextBoxColumn,
            this.nguoiThuDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn,
            this.maSVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bienLaiTienHocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // soBienLaiDataGridViewTextBoxColumn
            // 
            this.soBienLaiDataGridViewTextBoxColumn.DataPropertyName = "SoBienLai";
            this.soBienLaiDataGridViewTextBoxColumn.HeaderText = "SoBienLai";
            this.soBienLaiDataGridViewTextBoxColumn.Name = "soBienLaiDataGridViewTextBoxColumn";
            // 
            // ngayThuDataGridViewTextBoxColumn
            // 
            this.ngayThuDataGridViewTextBoxColumn.DataPropertyName = "NgayThu";
            this.ngayThuDataGridViewTextBoxColumn.HeaderText = "NgayThu";
            this.ngayThuDataGridViewTextBoxColumn.Name = "ngayThuDataGridViewTextBoxColumn";
            // 
            // nguoiThuDataGridViewTextBoxColumn
            // 
            this.nguoiThuDataGridViewTextBoxColumn.DataPropertyName = "NguoiThu";
            this.nguoiThuDataGridViewTextBoxColumn.HeaderText = "NguoiThu";
            this.nguoiThuDataGridViewTextBoxColumn.Name = "nguoiThuDataGridViewTextBoxColumn";
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "Tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "Tongtien";
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            // 
            // bienLaiTienHocBindingSource
            // 
            this.bienLaiTienHocBindingSource.DataMember = "BienLaiTienHoc";
            this.bienLaiTienHocBindingSource.DataSource = this.qLThuHocPhiSV1DataSet;
            // 
            // qLThuHocPhiSV1DataSet
            // 
            this.qLThuHocPhiSV1DataSet.DataSetName = "QLThuHocPhiSV1DataSet";
            this.qLThuHocPhiSV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbsobl
            // 
            this.cmbsobl.FormattingEnabled = true;
            this.cmbsobl.Location = new System.Drawing.Point(707, 254);
            this.cmbsobl.Name = "cmbsobl";
            this.cmbsobl.Size = new System.Drawing.Size(121, 21);
            this.cmbsobl.TabIndex = 37;
            this.cmbsobl.SelectionChangeCommitted += new System.EventHandler(this.cmbsobl_SelectionChangeCommitted_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(703, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Chi tiết biên lai";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(251, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Tim kiếm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(403, 240);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 34;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(311, 240);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 33;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(220, 240);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 32;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(121, 239);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 31;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(26, 240);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 30;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tìm kiếm";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(339, 138);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(100, 20);
            this.txttk.TabIndex = 28;
            // 
            // txtnguoithu
            // 
            this.txtnguoithu.Location = new System.Drawing.Point(96, 188);
            this.txtnguoithu.Name = "txtnguoithu";
            this.txtnguoithu.Size = new System.Drawing.Size(100, 20);
            this.txtnguoithu.TabIndex = 27;
            // 
            // txtngaythu
            // 
            this.txtngaythu.Location = new System.Drawing.Point(96, 155);
            this.txtngaythu.Name = "txtngaythu";
            this.txtngaythu.Size = new System.Drawing.Size(100, 20);
            this.txtngaythu.TabIndex = 26;
            // 
            // txtsobl
            // 
            this.txtsobl.Location = new System.Drawing.Point(96, 126);
            this.txtsobl.Name = "txtsobl";
            this.txtsobl.Size = new System.Drawing.Size(100, 20);
            this.txtsobl.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Người thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày Thu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số Biên lai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "THÔNG TIN BIÊN LAI";
            // 
            // bienLaiTienHocTableAdapter
            // 
            this.bienLaiTienHocTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietBienLaiTableAdapter
            // 
            this.chiTietBienLaiTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 456);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbsobl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtnguoithu);
            this.Controls.Add(this.txtngaythu);
            this.Controls.Add(this.txtsobl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBienLaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienLaiTienHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.ComboBox cmbsobl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtnguoithu;
        private System.Windows.Forms.TextBox txtngaythu;
        private System.Windows.Forms.TextBox txtsobl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLThuHocPhiSV1DataSet qLThuHocPhiSV1DataSet;
        private System.Windows.Forms.BindingSource bienLaiTienHocBindingSource;
        private QLThuHocPhiSV1DataSetTableAdapters.BienLaiTienHocTableAdapter bienLaiTienHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBienLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private QLThuHocPhiSV1DataSet1 qLThuHocPhiSV1DataSet1;
        private System.Windows.Forms.BindingSource chiTietBienLaiBindingSource;
        private QLThuHocPhiSV1DataSet1TableAdapters.ChiTietBienLaiTableAdapter chiTietBienLaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBienLaiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHocDataGridViewTextBoxColumn;
    }
}

