namespace OnTapCK
{
    partial class frmTHONGTIN
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
            this.tHONGTINBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cuoiKyDataSetTHONGTIN = new OnTapCK.CuoiKyDataSetTHONGTIN();
            this.tHONGTINBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cuoiKyDataSet2 = new OnTapCK.CuoiKyDataSet2();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTEN = new System.Windows.Forms.Label();
            this.lblTUOI = new System.Windows.Forms.Label();
            this.lblNOILAMVIEC = new System.Windows.Forms.Label();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtTUOI = new System.Windows.Forms.TextBox();
            this.txtNOILAMVIEC = new System.Windows.Forms.TextBox();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.cuoiKyDataSet1 = new OnTapCK.CuoiKyDataSet1();
            this.tHONGTINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHONGTINTableAdapter = new OnTapCK.CuoiKyDataSet1TableAdapters.THONGTINTableAdapter();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.tHONGTINTableAdapter1 = new OnTapCK.CuoiKyDataSet2TableAdapters.THONGTINTableAdapter();
            this.timeDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tHONGTINTableAdapter2 = new OnTapCK.CuoiKyDataSetTHONGTINTableAdapters.THONGTINTableAdapter();
            this.cuoiKyDataSetTHONGTIN1 = new OnTapCK.CuoiKyDataSetTHONGTIN1();
            this.tHONGTINBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tHONGTINTableAdapter3 = new OnTapCK.CuoiKyDataSetTHONGTIN1TableAdapters.THONGTINTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noilamviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTIM = new System.Windows.Forms.TextBox();
            this.gbTIMKIEM = new System.Windows.Forms.GroupBox();
            this.btnTIM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSetTHONGTIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSetTHONGTIN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource3)).BeginInit();
            this.gbTIMKIEM.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.maNV,
            this.ten,
            this.ngaysinh,
            this.tuoi,
            this.noilamviec});
            this.dataGridView1.DataSource = this.tHONGTINBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(938, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tHONGTINBindingSource2
            // 
            this.tHONGTINBindingSource2.DataMember = "THONGTIN";
            this.tHONGTINBindingSource2.DataSource = this.cuoiKyDataSetTHONGTIN;
            // 
            // cuoiKyDataSetTHONGTIN
            // 
            this.cuoiKyDataSetTHONGTIN.DataSetName = "CuoiKyDataSetTHONGTIN";
            this.cuoiKyDataSetTHONGTIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHONGTINBindingSource1
            // 
            this.tHONGTINBindingSource1.DataMember = "THONGTIN";
            this.tHONGTINBindingSource1.DataSource = this.cuoiKyDataSet2;
            // 
            // cuoiKyDataSet2
            // 
            this.cuoiKyDataSet2.DataSetName = "CuoiKyDataSet2";
            this.cuoiKyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            // 
            // lblTEN
            // 
            this.lblTEN.AutoSize = true;
            this.lblTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTEN.Location = new System.Drawing.Point(23, 334);
            this.lblTEN.Name = "lblTEN";
            this.lblTEN.Size = new System.Drawing.Size(47, 25);
            this.lblTEN.TabIndex = 2;
            this.lblTEN.Text = "Tên";
            // 
            // lblTUOI
            // 
            this.lblTUOI.AutoSize = true;
            this.lblTUOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTUOI.Location = new System.Drawing.Point(23, 387);
            this.lblTUOI.Name = "lblTUOI";
            this.lblTUOI.Size = new System.Drawing.Size(51, 25);
            this.lblTUOI.TabIndex = 3;
            this.lblTUOI.Text = "Tuổi";
            // 
            // lblNOILAMVIEC
            // 
            this.lblNOILAMVIEC.AutoSize = true;
            this.lblNOILAMVIEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNOILAMVIEC.Location = new System.Drawing.Point(23, 436);
            this.lblNOILAMVIEC.Name = "lblNOILAMVIEC";
            this.lblNOILAMVIEC.Size = new System.Drawing.Size(117, 25);
            this.lblNOILAMVIEC.TabIndex = 4;
            this.lblNOILAMVIEC.Text = "Nơi làm việc";
            // 
            // txtTEN
            // 
            this.txtTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTEN.Location = new System.Drawing.Point(149, 334);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(200, 30);
            this.txtTEN.TabIndex = 7;
            // 
            // txtTUOI
            // 
            this.txtTUOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTUOI.Location = new System.Drawing.Point(149, 384);
            this.txtTUOI.Name = "txtTUOI";
            this.txtTUOI.Size = new System.Drawing.Size(200, 30);
            this.txtTUOI.TabIndex = 8;
            // 
            // txtNOILAMVIEC
            // 
            this.txtNOILAMVIEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtNOILAMVIEC.Location = new System.Drawing.Point(149, 436);
            this.txtNOILAMVIEC.Name = "txtNOILAMVIEC";
            this.txtNOILAMVIEC.Size = new System.Drawing.Size(200, 30);
            this.txtNOILAMVIEC.TabIndex = 9;
            // 
            // btnTHEM
            // 
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTHEM.Location = new System.Drawing.Point(421, 301);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(110, 48);
            this.btnTHEM.TabIndex = 12;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXOA.Location = new System.Drawing.Point(555, 301);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(110, 48);
            this.btnXOA.TabIndex = 13;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSUA.Location = new System.Drawing.Point(681, 301);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(110, 48);
            this.btnSUA.TabIndex = 14;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // cuoiKyDataSet1
            // 
            this.cuoiKyDataSet1.DataSetName = "CuoiKyDataSet1";
            this.cuoiKyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHONGTINBindingSource
            // 
            this.tHONGTINBindingSource.DataMember = "THONGTIN";
            this.tHONGTINBindingSource.DataSource = this.cuoiKyDataSet1;
            // 
            // tHONGTINTableAdapter
            // 
            this.tHONGTINTableAdapter.ClearBeforeFill = true;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTHOAT.Location = new System.Drawing.Point(555, 387);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(110, 48);
            this.btnTHOAT.TabIndex = 15;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // tHONGTINTableAdapter1
            // 
            this.tHONGTINTableAdapter1.ClearBeforeFill = true;
            // 
            // timeDOB
            // 
            this.timeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.timeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDOB.Location = new System.Drawing.Point(149, 477);
            this.timeDOB.Name = "timeDOB";
            this.timeDOB.Size = new System.Drawing.Size(200, 30);
            this.timeDOB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(23, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ngày sinh";
            // 
            // tHONGTINTableAdapter2
            // 
            this.tHONGTINTableAdapter2.ClearBeforeFill = true;
            // 
            // cuoiKyDataSetTHONGTIN1
            // 
            this.cuoiKyDataSetTHONGTIN1.DataSetName = "CuoiKyDataSetTHONGTIN1";
            this.cuoiKyDataSetTHONGTIN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHONGTINBindingSource3
            // 
            this.tHONGTINBindingSource3.DataMember = "THONGTIN";
            this.tHONGTINBindingSource3.DataSource = this.cuoiKyDataSetTHONGTIN1;
            // 
            // tHONGTINTableAdapter3
            // 
            this.tHONGTINTableAdapter3.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "maNV";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 125;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "TÊN";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // tuoi
            // 
            this.tuoi.DataPropertyName = "tuoi";
            this.tuoi.HeaderText = "TUỔI";
            this.tuoi.MinimumWidth = 6;
            this.tuoi.Name = "tuoi";
            this.tuoi.Width = 125;
            // 
            // noilamviec
            // 
            this.noilamviec.DataPropertyName = "noilamviec";
            this.noilamviec.HeaderText = "NƠI LÀM VIỆC";
            this.noilamviec.MinimumWidth = 6;
            this.noilamviec.Name = "noilamviec";
            this.noilamviec.Width = 125;
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMANV.Location = new System.Drawing.Point(149, 287);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(200, 30);
            this.txtMANV.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(29, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(83, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã ";
            // 
            // txtTIM
            // 
            this.txtTIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTIM.Location = new System.Drawing.Point(154, 39);
            this.txtTIM.Name = "txtTIM";
            this.txtTIM.Size = new System.Drawing.Size(200, 30);
            this.txtTIM.TabIndex = 21;
            // 
            // gbTIMKIEM
            // 
            this.gbTIMKIEM.Controls.Add(this.btnTIM);
            this.gbTIMKIEM.Controls.Add(this.label3);
            this.gbTIMKIEM.Controls.Add(this.txtTIM);
            this.gbTIMKIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbTIMKIEM.Location = new System.Drawing.Point(12, 41);
            this.gbTIMKIEM.Name = "gbTIMKIEM";
            this.gbTIMKIEM.Size = new System.Drawing.Size(789, 84);
            this.gbTIMKIEM.TabIndex = 22;
            this.gbTIMKIEM.TabStop = false;
            this.gbTIMKIEM.Text = "Tim kiem";
            // 
            // btnTIM
            // 
            this.btnTIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTIM.Location = new System.Drawing.Point(409, 32);
            this.btnTIM.Name = "btnTIM";
            this.btnTIM.Size = new System.Drawing.Size(110, 39);
            this.btnTIM.TabIndex = 23;
            this.btnTIM.Text = "Tìm";
            this.btnTIM.UseVisualStyleBackColor = true;
            this.btnTIM.Click += new System.EventHandler(this.btnTIM_Click);
            // 
            // frmTHONGTIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 592);
            this.Controls.Add(this.gbTIMKIEM);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeDOB);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.txtNOILAMVIEC);
            this.Controls.Add(this.txtTUOI);
            this.Controls.Add(this.txtTEN);
            this.Controls.Add(this.lblNOILAMVIEC);
            this.Controls.Add(this.lblTUOI);
            this.Controls.Add(this.lblTEN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTHONGTIN";
            this.Text = "frmTHONGTIN";
            this.Load += new System.EventHandler(this.frmTHONGTIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSetTHONGTIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuoiKyDataSetTHONGTIN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBindingSource3)).EndInit();
            this.gbTIMKIEM.ResumeLayout(false);
            this.gbTIMKIEM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private CuoiKyDataSet cuoiKyDataSet;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        //private CuoiKyDataSetTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private System.Windows.Forms.Label lblTEN;
        private System.Windows.Forms.Label lblTUOI;
        private System.Windows.Forms.Label lblNOILAMVIEC;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtTUOI;
        private System.Windows.Forms.TextBox txtNOILAMVIEC;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private CuoiKyDataSet1 cuoiKyDataSet1;
        private System.Windows.Forms.BindingSource tHONGTINBindingSource;
        private CuoiKyDataSet1TableAdapters.THONGTINTableAdapter tHONGTINTableAdapter;
        private System.Windows.Forms.Button btnTHOAT;
        private CuoiKyDataSet2 cuoiKyDataSet2;
        private System.Windows.Forms.BindingSource tHONGTINBindingSource1;
        private CuoiKyDataSet2TableAdapters.THONGTINTableAdapter tHONGTINTableAdapter1;
        private System.Windows.Forms.DateTimePicker timeDOB;
        private System.Windows.Forms.Label label1;
        private CuoiKyDataSetTHONGTIN cuoiKyDataSetTHONGTIN;
        private System.Windows.Forms.BindingSource tHONGTINBindingSource2;
        private CuoiKyDataSetTHONGTINTableAdapters.THONGTINTableAdapter tHONGTINTableAdapter2;
        private CuoiKyDataSetTHONGTIN1 cuoiKyDataSetTHONGTIN1;
        private System.Windows.Forms.BindingSource tHONGTINBindingSource3;
        private CuoiKyDataSetTHONGTIN1TableAdapters.THONGTINTableAdapter tHONGTINTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn noilamviec;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTIM;
        private System.Windows.Forms.GroupBox gbTIMKIEM;
        private System.Windows.Forms.Button btnTIM;
    }
}