namespace ADONet_DataSet
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorKursiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tujuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.travelDatabaseDataSet2 = new ADONet_DataSet.travelDatabaseDataSet2();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.travelDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxJenis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxTujuan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxKursi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textNIK = new System.Windows.Forms.TextBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTanggal = new System.Windows.Forms.DateTimePicker();
            this.travelDataTableAdapter1 = new ADONet_DataSet.travelDatabaseDataSet2TableAdapters.travelDataTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Location = new System.Drawing.Point(534, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(640, 448);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Penumpang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodeBookingDataGridViewTextBoxColumn,
            this.nomorKursiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.nIKDataGridViewTextBoxColumn,
            this.tujuanDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.travelDataBindingSource1, "Id", true));
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("DataMember", this.travelDataBindingSource1, "Id", true));
            this.dataGridView1.DataSource = this.travelDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(40, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(594, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // kodeBookingDataGridViewTextBoxColumn
            // 
            this.kodeBookingDataGridViewTextBoxColumn.DataPropertyName = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn.HeaderText = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeBookingDataGridViewTextBoxColumn.Name = "kodeBookingDataGridViewTextBoxColumn";
            this.kodeBookingDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomorKursiDataGridViewTextBoxColumn
            // 
            this.nomorKursiDataGridViewTextBoxColumn.DataPropertyName = "NomorKursi";
            this.nomorKursiDataGridViewTextBoxColumn.HeaderText = "Kursi";
            this.nomorKursiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomorKursiDataGridViewTextBoxColumn.Name = "nomorKursiDataGridViewTextBoxColumn";
            this.nomorKursiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nIKDataGridViewTextBoxColumn
            // 
            this.nIKDataGridViewTextBoxColumn.DataPropertyName = "NIK";
            this.nIKDataGridViewTextBoxColumn.HeaderText = "NIK";
            this.nIKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIKDataGridViewTextBoxColumn.Name = "nIKDataGridViewTextBoxColumn";
            this.nIKDataGridViewTextBoxColumn.Width = 150;
            // 
            // tujuanDataGridViewTextBoxColumn
            // 
            this.tujuanDataGridViewTextBoxColumn.DataPropertyName = "Tujuan";
            this.tujuanDataGridViewTextBoxColumn.HeaderText = "Tujuan";
            this.tujuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tujuanDataGridViewTextBoxColumn.Name = "tujuanDataGridViewTextBoxColumn";
            this.tujuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.Width = 150;
            // 
            // jenisDataGridViewTextBoxColumn
            // 
            this.jenisDataGridViewTextBoxColumn.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisDataGridViewTextBoxColumn.Name = "jenisDataGridViewTextBoxColumn";
            this.jenisDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 150;
            // 
            // travelDataBindingSource1
            // 
            this.travelDataBindingSource1.DataMember = "travelData";
            this.travelDataBindingSource1.DataSource = this.travelDatabaseDataSet2;
            // 
            // travelDatabaseDataSet2
            // 
            this.travelDatabaseDataSet2.DataSetName = "travelDatabaseDataSet2";
            this.travelDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 323);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(40, 42);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(71, 24);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Display";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // travelDataBindingSource
            // 
            this.travelDataBindingSource.DataMember = "travelData";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "No Kursi";
            // 
            // boxJenis
            // 
            this.boxJenis.FormattingEnabled = true;
            this.boxJenis.Items.AddRange(new object[] {
            "Ekonomi",
            "Bisnis",
            "Eksekutif"});
            this.boxJenis.Location = new System.Drawing.Point(311, 234);
            this.boxJenis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxJenis.Name = "boxJenis";
            this.boxJenis.Size = new System.Drawing.Size(98, 24);
            this.boxJenis.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tujuan";
            // 
            // boxTujuan
            // 
            this.boxTujuan.FormattingEnabled = true;
            this.boxTujuan.Items.AddRange(new object[] {
            "Semarang",
            "Bandung",
            "Surabaya"});
            this.boxTujuan.Location = new System.Drawing.Point(151, 142);
            this.boxTujuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxTujuan.Name = "boxTujuan";
            this.boxTujuan.Size = new System.Drawing.Size(270, 24);
            this.boxTujuan.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIK";
            // 
            // boxKursi
            // 
            this.boxKursi.FormattingEnabled = true;
            this.boxKursi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.boxKursi.Location = new System.Drawing.Point(152, 237);
            this.boxKursi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxKursi.Name = "boxKursi";
            this.boxKursi.Size = new System.Drawing.Size(59, 24);
            this.boxKursi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(311, 362);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(311, 308);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textNIK
            // 
            this.textNIK.Location = new System.Drawing.Point(151, 98);
            this.textNIK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNIK.Name = "textNIK";
            this.textNIK.Size = new System.Drawing.Size(270, 22);
            this.textNIK.TabIndex = 2;
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(151, 48);
            this.textNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(270, 22);
            this.textNama.TabIndex = 0;
            this.textNama.Text = "\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTanggal);
            this.groupBox1.Controls.Add(this.textNama);
            this.groupBox1.Controls.Add(this.textNIK);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxKursi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxTujuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxJenis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(479, 448);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tanggal ";
            // 
            // dateTanggal
            // 
            this.dateTanggal.Location = new System.Drawing.Point(151, 189);
            this.dateTanggal.Name = "dateTanggal";
            this.dateTanggal.Size = new System.Drawing.Size(270, 22);
            this.dateTanggal.TabIndex = 16;
            // 
            // travelDataTableAdapter1
            // 
            this.travelDataTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1186, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Jendela Travel";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxJenis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxTujuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxKursi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNIK;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource travelDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource travelDataBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTanggal;
        private travelDatabaseDataSet2 travelDatabaseDataSet2;
        private System.Windows.Forms.BindingSource travelDataBindingSource1;
        private travelDatabaseDataSet2TableAdapters.travelDataTableAdapter travelDataTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorKursiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tujuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}

