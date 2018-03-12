namespace QLThuHocPhiSVnhom11
{
    partial class frmCTBL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsobl = new System.Windows.Forms.ComboBox();
            this.cmblhp = new System.Windows.Forms.ComboBox();
            this.cmbmasv = new System.Windows.Forms.ComboBox();
            this.cmbtk = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBienLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopHocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietBienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet12 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet12();
            this.chiTietBienLaiTableAdapter = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet12TableAdapters.ChiTietBienLaiTableAdapter();
            this.txtsoien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBienLaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT BIÊN LAI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số biên lai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã lớp học phần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sinh viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm";
            // 
            // cmbsobl
            // 
            this.cmbsobl.FormattingEnabled = true;
            this.cmbsobl.Location = new System.Drawing.Point(128, 60);
            this.cmbsobl.Name = "cmbsobl";
            this.cmbsobl.Size = new System.Drawing.Size(121, 21);
            this.cmbsobl.TabIndex = 5;
            // 
            // cmblhp
            // 
            this.cmblhp.FormattingEnabled = true;
            this.cmblhp.Location = new System.Drawing.Point(128, 96);
            this.cmblhp.Name = "cmblhp";
            this.cmblhp.Size = new System.Drawing.Size(121, 21);
            this.cmblhp.TabIndex = 6;
            // 
            // cmbmasv
            // 
            this.cmbmasv.FormattingEnabled = true;
            this.cmbmasv.Location = new System.Drawing.Point(128, 131);
            this.cmbmasv.Name = "cmbmasv";
            this.cmbmasv.Size = new System.Drawing.Size(121, 21);
            this.cmbmasv.TabIndex = 7;
            // 
            // cmbtk
            // 
            this.cmbtk.FormattingEnabled = true;
            this.cmbtk.Location = new System.Drawing.Point(333, 96);
            this.cmbtk.Name = "cmbtk";
            this.cmbtk.Size = new System.Drawing.Size(121, 21);
            this.cmbtk.TabIndex = 8;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(16, 208);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(117, 208);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(223, 208);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(333, 207);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(449, 207);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(474, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 22);
            this.button6.TabIndex = 14;
            this.button6.Text = "tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.soBienLaiDataGridViewTextBoxColumn,
            this.maLopHocphanDataGridViewTextBoxColumn,
            this.maSVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietBienLaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // maLopHocphanDataGridViewTextBoxColumn
            // 
            this.maLopHocphanDataGridViewTextBoxColumn.DataPropertyName = "MaLopHocphan";
            this.maLopHocphanDataGridViewTextBoxColumn.HeaderText = "MaLopHocphan";
            this.maLopHocphanDataGridViewTextBoxColumn.Name = "maLopHocphanDataGridViewTextBoxColumn";
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            // 
            // chiTietBienLaiBindingSource
            // 
            this.chiTietBienLaiBindingSource.DataMember = "ChiTietBienLai";
            this.chiTietBienLaiBindingSource.DataSource = this.qLThuHocPhiSV1DataSet12;
            // 
            // qLThuHocPhiSV1DataSet12
            // 
            this.qLThuHocPhiSV1DataSet12.DataSetName = "QLThuHocPhiSV1DataSet12";
            this.qLThuHocPhiSV1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietBienLaiTableAdapter
            // 
            this.chiTietBienLaiTableAdapter.ClearBeforeFill = true;
            // 
            // txtsoien
            // 
            this.txtsoien.Location = new System.Drawing.Point(128, 168);
            this.txtsoien.Name = "txtsoien";
            this.txtsoien.Size = new System.Drawing.Size(121, 20);
            this.txtsoien.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số tiền";
            // 
            // frmCTBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 427);
            this.Controls.Add(this.txtsoien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cmbtk);
            this.Controls.Add(this.cmbmasv);
            this.Controls.Add(this.cmblhp);
            this.Controls.Add(this.cmbsobl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCTBL";
            this.Text = "frmCTBL";
            this.Load += new System.EventHandler(this.frmCTBL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBienLaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbsobl;
        private System.Windows.Forms.ComboBox cmblhp;
        private System.Windows.Forms.ComboBox cmbmasv;
        private System.Windows.Forms.ComboBox cmbtk;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private QLThuHocPhiSV1DataSet12 qLThuHocPhiSV1DataSet12;
        private System.Windows.Forms.BindingSource chiTietBienLaiBindingSource;
        private QLThuHocPhiSV1DataSet12TableAdapters.ChiTietBienLaiTableAdapter chiTietBienLaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBienLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsoien;
        private System.Windows.Forms.Label label6;
    }
}