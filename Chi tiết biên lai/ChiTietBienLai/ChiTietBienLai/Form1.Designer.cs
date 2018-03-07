namespace ChiTietBienLai
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cmbtk = new System.Windows.Forms.ComboBox();
            this.cmbmh = new System.Windows.Forms.ComboBox();
            this.cmbsobl = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLThuHocPhiSV1DataSet = new ChiTietBienLai.QLThuHocPhiSV1DataSet();
            this.chiTietBienLaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietBienLaiTableAdapter = new ChiTietBienLai.QLThuHocPhiSV1DataSetTableAdapters.ChiTietBienLaiTableAdapter();
            this.soBienLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBienLaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.soBienLaiDataGridViewTextBoxColumn,
            this.maMonHocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietBienLaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(494, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 22);
            this.button6.TabIndex = 32;
            this.button6.Text = "tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(469, 221);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 31;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(353, 221);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 30;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(243, 222);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 29;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(137, 222);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 28;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(36, 222);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 27;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cmbtk
            // 
            this.cmbtk.FormattingEnabled = true;
            this.cmbtk.Location = new System.Drawing.Point(353, 110);
            this.cmbtk.Name = "cmbtk";
            this.cmbtk.Size = new System.Drawing.Size(121, 21);
            this.cmbtk.TabIndex = 26;
            // 
            // cmbmh
            // 
            this.cmbmh.FormattingEnabled = true;
            this.cmbmh.Location = new System.Drawing.Point(148, 110);
            this.cmbmh.Name = "cmbmh";
            this.cmbmh.Size = new System.Drawing.Size(121, 21);
            this.cmbmh.TabIndex = 24;
            // 
            // cmbsobl
            // 
            this.cmbsobl.FormattingEnabled = true;
            this.cmbsobl.Location = new System.Drawing.Point(148, 74);
            this.cmbsobl.Name = "cmbsobl";
            this.cmbsobl.Size = new System.Drawing.Size(121, 21);
            this.cmbsobl.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số biên lai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "CHI TIẾT BIÊN LAI";
            // 
            // qLThuHocPhiSV1DataSet
            // 
            this.qLThuHocPhiSV1DataSet.DataSetName = "QLThuHocPhiSV1DataSet";
            this.qLThuHocPhiSV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietBienLaiBindingSource
            // 
            this.chiTietBienLaiBindingSource.DataMember = "ChiTietBienLai";
            this.chiTietBienLaiBindingSource.DataSource = this.qLThuHocPhiSV1DataSet;
            // 
            // chiTietBienLaiTableAdapter
            // 
            this.chiTietBienLaiTableAdapter.ClearBeforeFill = true;
            // 
            // soBienLaiDataGridViewTextBoxColumn
            // 
            this.soBienLaiDataGridViewTextBoxColumn.DataPropertyName = "SoBienLai";
            this.soBienLaiDataGridViewTextBoxColumn.HeaderText = "SoBienLai";
            this.soBienLaiDataGridViewTextBoxColumn.Name = "soBienLaiDataGridViewTextBoxColumn";
            // 
            // maMonHocDataGridViewTextBoxColumn
            // 
            this.maMonHocDataGridViewTextBoxColumn.DataPropertyName = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.HeaderText = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.Name = "maMonHocDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cmbtk);
            this.Controls.Add(this.cmbmh);
            this.Controls.Add(this.cmbsobl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBienLaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cmbtk;
        private System.Windows.Forms.ComboBox cmbmh;
        private System.Windows.Forms.ComboBox cmbsobl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLThuHocPhiSV1DataSet qLThuHocPhiSV1DataSet;
        private System.Windows.Forms.BindingSource chiTietBienLaiBindingSource;
        private QLThuHocPhiSV1DataSetTableAdapters.ChiTietBienLaiTableAdapter chiTietBienLaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBienLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHocDataGridViewTextBoxColumn;
    }
}

