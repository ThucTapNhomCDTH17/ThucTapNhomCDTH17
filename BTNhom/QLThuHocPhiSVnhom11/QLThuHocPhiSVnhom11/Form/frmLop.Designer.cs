namespace QLThuHocPhiSVnhom11
{
    partial class frmLop
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet5 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet5();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet1 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet1();
            this.cmbmakhoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsiso = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lopTableAdapter = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet1TableAdapters.LopTableAdapter();
            this.lopTableAdapter1 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet5TableAdapters.LopTableAdapter();
            this.qLThuHocPhiSV1DataSet18 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet18();
            this.lopBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter2 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet18TableAdapters.LopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(469, 217);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 41);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(148, 219);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 39);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(352, 220);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 39);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(248, 219);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 40);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(57, 218);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 40);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lopBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(46, 263);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 176);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            this.siSoDataGridViewTextBoxColumn.HeaderText = "SiSo";
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "Lop";
            this.lopBindingSource1.DataSource = this.qLThuHocPhiSV1DataSet5;
            // 
            // qLThuHocPhiSV1DataSet5
            // 
            this.qLThuHocPhiSV1DataSet5.DataSetName = "QLThuHocPhiSV1DataSet5";
            this.qLThuHocPhiSV1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLThuHocPhiSV1DataSet1;
            // 
            // qLThuHocPhiSV1DataSet1
            // 
            this.qLThuHocPhiSV1DataSet1.DataSetName = "QLThuHocPhiSV1DataSet1";
            this.qLThuHocPhiSV1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbmakhoa
            // 
            this.cmbmakhoa.FormattingEnabled = true;
            this.cmbmakhoa.Location = new System.Drawing.Point(137, 157);
            this.cmbmakhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbmakhoa.Name = "cmbmakhoa";
            this.cmbmakhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbmakhoa.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nhập mã cần tìm";
            // 
            // txtsiso
            // 
            this.txtsiso.Location = new System.Drawing.Point(137, 104);
            this.txtsiso.Margin = new System.Windows.Forms.Padding(2);
            this.txtsiso.Multiline = true;
            this.txtsiso.Name = "txtsiso";
            this.txtsiso.Size = new System.Drawing.Size(121, 25);
            this.txtsiso.TabIndex = 31;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(380, 65);
            this.txtTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(138, 20);
            this.txtTK.TabIndex = 32;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(421, 104);
            this.btnTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(56, 19);
            this.btnTK.TabIndex = 33;
            this.btnTK.Text = "Seach";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "SI So";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ten Lop";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(137, 61);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(121, 25);
            this.txtTen.TabIndex = 20;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(137, 20);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(121, 25);
            this.txtMa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ma khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ma Lop";
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter1
            // 
            this.lopTableAdapter1.ClearBeforeFill = true;
            // 
            // qLThuHocPhiSV1DataSet18
            // 
            this.qLThuHocPhiSV1DataSet18.DataSetName = "QLThuHocPhiSV1DataSet18";
            this.qLThuHocPhiSV1DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource2
            // 
            this.lopBindingSource2.DataMember = "Lop";
            this.lopBindingSource2.DataSource = this.qLThuHocPhiSV1DataSet18;
            // 
            // lopTableAdapter2
            // 
            this.lopTableAdapter2.ClearBeforeFill = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 463);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbmakhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsiso);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.ComboBox cmbmakhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsiso;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private QLThuHocPhiSV1DataSet1 qLThuHocPhiSV1DataSet1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLThuHocPhiSV1DataSet1TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private QLThuHocPhiSV1DataSet5 qLThuHocPhiSV1DataSet5;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private QLThuHocPhiSV1DataSet5TableAdapters.LopTableAdapter lopTableAdapter1;
        private QLThuHocPhiSV1DataSet18 qLThuHocPhiSV1DataSet18;
        private System.Windows.Forms.BindingSource lopBindingSource2;
        private QLThuHocPhiSV1DataSet18TableAdapters.LopTableAdapter lopTableAdapter2;
    }
}