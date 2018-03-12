namespace QLThuHocPhiSVnhom11
{
    partial class LopMonHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lopMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet22 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet22();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.txtsiso = new System.Windows.Forms.TextBox();
            this.txtnamhoc = new System.Windows.Forms.TextBox();
            this.txthocki = new System.Windows.Forms.TextBox();
            this.cmbmucthu = new System.Windows.Forms.ComboBox();
            this.cmbmalop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lopMonHocTableAdapter = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet22TableAdapters.LopMonHocTableAdapter();
            this.btnclear = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMucThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maLopMonHocDataGridViewTextBoxColumn,
            this.namHocDataGridViewTextBoxColumn,
            this.hocKiDataGridViewTextBoxColumn,
            this.sisoDataGridViewTextBoxColumn,
            this.maMucThuDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lopMonHocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lopMonHocBindingSource
            // 
            this.lopMonHocBindingSource.DataMember = "LopMonHoc";
            this.lopMonHocBindingSource.DataSource = this.qLThuHocPhiSV1DataSet22;
            // 
            // qLThuHocPhiSV1DataSet22
            // 
            this.qLThuHocPhiSV1DataSet22.DataSetName = "QLThuHocPhiSV1DataSet22";
            this.qLThuHocPhiSV1DataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(137, 50);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(100, 20);
            this.txtmalop.TabIndex = 1;
            // 
            // txtsiso
            // 
            this.txtsiso.Location = new System.Drawing.Point(137, 170);
            this.txtsiso.Name = "txtsiso";
            this.txtsiso.Size = new System.Drawing.Size(100, 20);
            this.txtsiso.TabIndex = 2;
            // 
            // txtnamhoc
            // 
            this.txtnamhoc.Location = new System.Drawing.Point(137, 131);
            this.txtnamhoc.Name = "txtnamhoc";
            this.txtnamhoc.Size = new System.Drawing.Size(100, 20);
            this.txtnamhoc.TabIndex = 3;
            // 
            // txthocki
            // 
            this.txthocki.Location = new System.Drawing.Point(137, 90);
            this.txthocki.Name = "txthocki";
            this.txthocki.Size = new System.Drawing.Size(100, 20);
            this.txthocki.TabIndex = 4;
            // 
            // cmbmucthu
            // 
            this.cmbmucthu.FormattingEnabled = true;
            this.cmbmucthu.Location = new System.Drawing.Point(137, 211);
            this.cmbmucthu.Name = "cmbmucthu";
            this.cmbmucthu.Size = new System.Drawing.Size(121, 21);
            this.cmbmucthu.TabIndex = 5;
            // 
            // cmbmalop
            // 
            this.cmbmalop.FormattingEnabled = true;
            this.cmbmalop.Location = new System.Drawing.Point(137, 239);
            this.cmbmalop.Name = "cmbmalop";
            this.cmbmalop.Size = new System.Drawing.Size(121, 21);
            this.cmbmalop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ma Lớp Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Học kì";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Năm Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sĩ số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Mức Thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thông tin lớp môn học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(491, 120);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 15;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(27, 294);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(137, 294);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(245, 294);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(467, 294);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 19;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(352, 294);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 20;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(369, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lopMonHocTableAdapter
            // 
            this.lopMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(583, 293);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 22;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // maLopMonHocDataGridViewTextBoxColumn
            // 
            this.maLopMonHocDataGridViewTextBoxColumn.DataPropertyName = "MaLopMonHoc";
            this.maLopMonHocDataGridViewTextBoxColumn.HeaderText = "MaLopMonHoc";
            this.maLopMonHocDataGridViewTextBoxColumn.Name = "maLopMonHocDataGridViewTextBoxColumn";
            // 
            // namHocDataGridViewTextBoxColumn
            // 
            this.namHocDataGridViewTextBoxColumn.DataPropertyName = "NamHoc";
            this.namHocDataGridViewTextBoxColumn.HeaderText = "NamHoc";
            this.namHocDataGridViewTextBoxColumn.Name = "namHocDataGridViewTextBoxColumn";
            // 
            // hocKiDataGridViewTextBoxColumn
            // 
            this.hocKiDataGridViewTextBoxColumn.DataPropertyName = "HocKi";
            this.hocKiDataGridViewTextBoxColumn.HeaderText = "HocKi";
            this.hocKiDataGridViewTextBoxColumn.Name = "hocKiDataGridViewTextBoxColumn";
            // 
            // sisoDataGridViewTextBoxColumn
            // 
            this.sisoDataGridViewTextBoxColumn.DataPropertyName = "Siso";
            this.sisoDataGridViewTextBoxColumn.HeaderText = "Siso";
            this.sisoDataGridViewTextBoxColumn.Name = "sisoDataGridViewTextBoxColumn";
            // 
            // maMucThuDataGridViewTextBoxColumn
            // 
            this.maMucThuDataGridViewTextBoxColumn.DataPropertyName = "MaMucThu";
            this.maMucThuDataGridViewTextBoxColumn.HeaderText = "MaMucThu";
            this.maMucThuDataGridViewTextBoxColumn.Name = "maMucThuDataGridViewTextBoxColumn";
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // LopMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 498);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbmalop);
            this.Controls.Add(this.cmbmucthu);
            this.Controls.Add(this.txthocki);
            this.Controls.Add(this.txtnamhoc);
            this.Controls.Add(this.txtsiso);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LopMonHoc";
            this.Text = "LopMonHoc";
            this.Load += new System.EventHandler(this.LopMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txtsiso;
        private System.Windows.Forms.TextBox txtnamhoc;
        private System.Windows.Forms.TextBox txthocki;
        private System.Windows.Forms.ComboBox cmbmucthu;
        private System.Windows.Forms.ComboBox cmbmalop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button button6;
        private QLThuHocPhiSV1DataSet22 qLThuHocPhiSV1DataSet22;
        private System.Windows.Forms.BindingSource lopMonHocBindingSource;
        private QLThuHocPhiSV1DataSet22TableAdapters.LopMonHocTableAdapter lopMonHocTableAdapter;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMucThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
    }
}