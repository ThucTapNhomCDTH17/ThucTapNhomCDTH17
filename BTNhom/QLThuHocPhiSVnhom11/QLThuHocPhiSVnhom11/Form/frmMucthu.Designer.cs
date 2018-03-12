namespace QLThuHocPhiSVnhom11
{
    partial class frmMucthu
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien1TinChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucthuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuHocPhiSV1DataSet7 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet7();
            this.mucthuTableAdapter = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet7TableAdapters.MucthuTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.qLThuHocPhiSV1DataSet20 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet20();
            this.mucthuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mucthuTableAdapter1 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet20TableAdapters.MucthuTableAdapter();
            this.qLThuHocPhiSV1DataSet21 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet21();
            this.mucthuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mucthuTableAdapter2 = new QLThuHocPhiSVnhom11.QLThuHocPhiSV1DataSet21TableAdapters.MucthuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucthuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucthuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucthuBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã Mức Thu";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(124, 71);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(111, 19);
            this.txtMa.TabIndex = 42;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(124, 104);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTien.Multiline = true;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(111, 19);
            this.txtSoTien.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số Tiền 1 TC:";
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(575, 83);
            this.txtTk.Margin = new System.Windows.Forms.Padding(2);
            this.txtTk.Multiline = true;
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(111, 28);
            this.txtTk.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tien1TinChiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mucthuBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(14, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 150);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // tien1TinChiDataGridViewTextBoxColumn
            // 
            this.tien1TinChiDataGridViewTextBoxColumn.DataPropertyName = "Tien1TinChi";
            this.tien1TinChiDataGridViewTextBoxColumn.HeaderText = "Tien1TinChi";
            this.tien1TinChiDataGridViewTextBoxColumn.Name = "tien1TinChiDataGridViewTextBoxColumn";
            // 
            // mucthuBindingSource
            // 
            this.mucthuBindingSource.DataMember = "Mucthu";
            this.mucthuBindingSource.DataSource = this.qLThuHocPhiSV1DataSet7;
            // 
            // qLThuHocPhiSV1DataSet7
            // 
            this.qLThuHocPhiSV1DataSet7.DataSetName = "QLThuHocPhiSV1DataSet7";
            this.qLThuHocPhiSV1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mucthuTableAdapter
            // 
            this.mucthuTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 31);
            this.label4.TabIndex = 56;
            this.label4.Text = "Thông tin mức thu";
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(591, 135);
            this.btnTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 46);
            this.btnTK.TabIndex = 53;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nhập mã cần tìm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(398, 164);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 40);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(309, 164);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 40);
            this.btnLuu.TabIndex = 48;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(218, 164);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 40);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(124, 164);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 40);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 164);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 40);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // qLThuHocPhiSV1DataSet20
            // 
            this.qLThuHocPhiSV1DataSet20.DataSetName = "QLThuHocPhiSV1DataSet20";
            this.qLThuHocPhiSV1DataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mucthuBindingSource1
            // 
            this.mucthuBindingSource1.DataMember = "Mucthu";
            this.mucthuBindingSource1.DataSource = this.qLThuHocPhiSV1DataSet20;
            // 
            // mucthuTableAdapter1
            // 
            this.mucthuTableAdapter1.ClearBeforeFill = true;
            // 
            // qLThuHocPhiSV1DataSet21
            // 
            this.qLThuHocPhiSV1DataSet21.DataSetName = "QLThuHocPhiSV1DataSet21";
            this.qLThuHocPhiSV1DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mucthuBindingSource2
            // 
            this.mucthuBindingSource2.DataMember = "Mucthu";
            this.mucthuBindingSource2.DataSource = this.qLThuHocPhiSV1DataSet21;
            // 
            // mucthuTableAdapter2
            // 
            this.mucthuTableAdapter2.ClearBeforeFill = true;
            // 
            // frmMucthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Name = "frmMucthu";
            this.Text = "frmMucthu";
            this.Load += new System.EventHandler(this.frmMucthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucthuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucthuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuHocPhiSV1DataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucthuBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLThuHocPhiSV1DataSet7 qLThuHocPhiSV1DataSet7;
        private System.Windows.Forms.BindingSource mucthuBindingSource;
        private QLThuHocPhiSV1DataSet7TableAdapters.MucthuTableAdapter mucthuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien1TinChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private QLThuHocPhiSV1DataSet20 qLThuHocPhiSV1DataSet20;
        private System.Windows.Forms.BindingSource mucthuBindingSource1;
        private QLThuHocPhiSV1DataSet20TableAdapters.MucthuTableAdapter mucthuTableAdapter1;
        private QLThuHocPhiSV1DataSet21 qLThuHocPhiSV1DataSet21;
        private System.Windows.Forms.BindingSource mucthuBindingSource2;
        private QLThuHocPhiSV1DataSet21TableAdapters.MucthuTableAdapter mucthuTableAdapter2;
    }
}