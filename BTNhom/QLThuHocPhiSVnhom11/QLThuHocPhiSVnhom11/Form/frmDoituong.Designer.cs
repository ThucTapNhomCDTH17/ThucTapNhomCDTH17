namespace QLThuHocPhiSVnhom11
{
    partial class frmDoituong
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMG = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDoiTuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoiTuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mienGiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doiTuongMienGiamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet11 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet11();
            this.doiTuongMienGiamTableAdapter = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet11TableAdapters.DoiTuongMienGiamTableAdapter();
            this.qLThuHocPhiSV1DataSet16 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet16();
            this.doiTuongMienGiamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doiTuongMienGiamTableAdapter1 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet16TableAdapters.DoiTuongMienGiamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongMienGiamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongMienGiamBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Miễn Giảm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên DT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã DT";
            // 
            // txtMG
            // 
            this.txtMG.Location = new System.Drawing.Point(89, 153);
            this.txtMG.Margin = new System.Windows.Forms.Padding(2);
            this.txtMG.Multiline = true;
            this.txtMG.Name = "txtMG";
            this.txtMG.Size = new System.Drawing.Size(121, 25);
            this.txtMG.TabIndex = 25;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(89, 113);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(121, 25);
            this.txtTen.TabIndex = 24;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(89, 76);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(121, 25);
            this.txtMa.TabIndex = 23;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 200);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 40);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(215, 200);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 40);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(414, 200);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 40);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 200);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 40);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(318, 200);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 40);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(308, 125);
            this.btnTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(71, 32);
            this.btnTK.TabIndex = 36;
            this.btnTK.Text = "Seach";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(270, 101);
            this.txtTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(138, 20);
            this.txtTK.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nhập mã cần tìm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maDoiTuongDataGridViewTextBoxColumn,
            this.tenDoiTuongDataGridViewTextBoxColumn,
            this.mienGiamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doiTuongMienGiamBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // maDoiTuongDataGridViewTextBoxColumn
            // 
            this.maDoiTuongDataGridViewTextBoxColumn.DataPropertyName = "MaDoiTuong";
            this.maDoiTuongDataGridViewTextBoxColumn.HeaderText = "MaDoiTuong";
            this.maDoiTuongDataGridViewTextBoxColumn.Name = "maDoiTuongDataGridViewTextBoxColumn";
            // 
            // tenDoiTuongDataGridViewTextBoxColumn
            // 
            this.tenDoiTuongDataGridViewTextBoxColumn.DataPropertyName = "TenDoiTuong";
            this.tenDoiTuongDataGridViewTextBoxColumn.HeaderText = "TenDoiTuong";
            this.tenDoiTuongDataGridViewTextBoxColumn.Name = "tenDoiTuongDataGridViewTextBoxColumn";
            // 
            // mienGiamDataGridViewTextBoxColumn
            // 
            this.mienGiamDataGridViewTextBoxColumn.DataPropertyName = "MienGiam";
            this.mienGiamDataGridViewTextBoxColumn.HeaderText = "MienGiam";
            this.mienGiamDataGridViewTextBoxColumn.Name = "mienGiamDataGridViewTextBoxColumn";
            // 
            // doiTuongMienGiamBindingSource
            // 
            this.doiTuongMienGiamBindingSource.DataMember = "DoiTuongMienGiam";
            this.doiTuongMienGiamBindingSource.DataSource = this.qLThuHocPhiSV1DataSet11;
            // 
            // qLThuHocPhiSV1DataSet11
            // 
            this.qLThuHocPhiSV1DataSet11.DataSetName = "QLThuHocPhiSV1DataSet11";
            this.qLThuHocPhiSV1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doiTuongMienGiamTableAdapter
            // 
            this.doiTuongMienGiamTableAdapter.ClearBeforeFill = true;
            // 
            // qLThuHocPhiSV1DataSet16
            // 
            this.qLThuHocPhiSV1DataSet16.DataSetName = "QLThuHocPhiSV1DataSet16";
            this.qLThuHocPhiSV1DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doiTuongMienGiamBindingSource1
            // 
            this.doiTuongMienGiamBindingSource1.DataMember = "DoiTuongMienGiam";
            this.doiTuongMienGiamBindingSource1.DataSource = this.qLThuHocPhiSV1DataSet16;
            // 
            // doiTuongMienGiamTableAdapter1
            // 
            this.doiTuongMienGiamTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDoituong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMG);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Name = "frmDoituong";
            this.Text = "frmDoituong";
            this.Load += new System.EventHandler(this.frmDoituong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongMienGiamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongMienGiamBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMG;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private QLThuHocPhiSV1DataSet11 qLThuHocPhiSV1DataSet11;
        private System.Windows.Forms.BindingSource doiTuongMienGiamBindingSource;
        private QLThuHocPhiSV1DataSet11TableAdapters.DoiTuongMienGiamTableAdapter doiTuongMienGiamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoiTuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoiTuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mienGiamDataGridViewTextBoxColumn;
        private QLThuHocPhiSV1DataSet16 qLThuHocPhiSV1DataSet16;
        private System.Windows.Forms.BindingSource doiTuongMienGiamBindingSource1;
        private QLThuHocPhiSV1DataSet16TableAdapters.DoiTuongMienGiamTableAdapter doiTuongMienGiamTableAdapter1;
    }
}