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
            this.kodeBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.travelDatabaseDataSet2 = new ADONet_DataSet.travelDatabaseDataSet2();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.btnFind = new System.Windows.Forms.Button();
            this.travelDataTableAdapter1 = new ADONet_DataSet.travelDatabaseDataSet2TableAdapters.travelDataTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textKode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tujuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorKursiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBookingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Location = new System.Drawing.Point(502, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1259, 600);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Penumpang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBookingDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.nIKDataGridViewTextBoxColumn,
            this.tujuanDataGridViewTextBoxColumn,
            this.nomorKursiDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn1,
            this.hargaDataGridViewTextBoxColumn1,
            this.kodeBookingDataGridViewTextBoxColumn1});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.travelDataBindingSource1, "Id", true));
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("DataMember", this.travelDataBindingSource1, "Id", true));
            this.dataGridView1.DataSource = this.travelDataBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 505);
            this.dataGridView1.TabIndex = 3;
            // 
            // kodeBookingDataGridViewTextBoxColumn
            // 
            this.kodeBookingDataGridViewTextBoxColumn.DataPropertyName = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn.HeaderText = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeBookingDataGridViewTextBoxColumn.Name = "kodeBookingDataGridViewTextBoxColumn";
            this.kodeBookingDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodeBookingDataGridViewTextBoxColumn.Width = 150;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanggalDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(22, 34);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(81, 33);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Display";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 78);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // travelDataBindingSource
            // 
            this.travelDataBindingSource.DataMember = "travelData";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "No Kursi";
            // 
            // boxJenis
            // 
            this.boxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxJenis.FormattingEnabled = true;
            this.boxJenis.Items.AddRange(new object[] {
            "Ekonomi",
            "Bisnis",
            "Eksekutif"});
            this.boxJenis.Location = new System.Drawing.Point(311, 234);
            this.boxJenis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxJenis.Name = "boxJenis";
            this.boxJenis.Size = new System.Drawing.Size(98, 23);
            this.boxJenis.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tujuan";
            // 
            // boxTujuan
            // 
            this.boxTujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTujuan.FormattingEnabled = true;
            this.boxTujuan.Items.AddRange(new object[] {
            "Semarang",
            "Bandung",
            "Surabaya"});
            this.boxTujuan.Location = new System.Drawing.Point(151, 136);
            this.boxTujuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxTujuan.Name = "boxTujuan";
            this.boxTujuan.Size = new System.Drawing.Size(270, 23);
            this.boxTujuan.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIK";
            // 
            // boxKursi
            // 
            this.boxKursi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.boxKursi.Location = new System.Drawing.Point(151, 234);
            this.boxKursi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxKursi.Name = "boxKursi";
            this.boxKursi.Size = new System.Drawing.Size(59, 23);
            this.boxKursi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(311, 355);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 38);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(311, 302);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // textNIK
            // 
            this.textNIK.Location = new System.Drawing.Point(151, 89);
            this.textNIK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNIK.MaxLength = 16;
            this.textNIK.Name = "textNIK";
            this.textNIK.Size = new System.Drawing.Size(270, 23);
            this.textNIK.TabIndex = 2;
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(151, 42);
            this.textNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(270, 23);
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
            this.groupBox1.Size = new System.Drawing.Size(475, 412);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tanggal ";
            // 
            // dateTanggal
            // 
            this.dateTanggal.Location = new System.Drawing.Point(151, 182);
            this.dateTanggal.Name = "dateTanggal";
            this.dateTanggal.Size = new System.Drawing.Size(270, 23);
            this.dateTanggal.TabIndex = 16;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(177, 78);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 27);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // travelDataTableAdapter1
            // 
            this.travelDataTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFind);
            this.groupBox3.Controls.Add(this.textKode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(22, 474);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(475, 148);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search and Delete";
            // 
            // textKode
            // 
            this.textKode.Location = new System.Drawing.Point(151, 43);
            this.textKode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textKode.Name = "textKode";
            this.textKode.Size = new System.Drawing.Size(270, 23);
            this.textKode.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kode Booking";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nIKDataGridViewTextBoxColumn
            // 
            this.nIKDataGridViewTextBoxColumn.DataPropertyName = "NIK";
            this.nIKDataGridViewTextBoxColumn.HeaderText = "NIK";
            this.nIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIKDataGridViewTextBoxColumn.Name = "nIKDataGridViewTextBoxColumn";
            this.nIKDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIKDataGridViewTextBoxColumn.Width = 125;
            // 
            // tujuanDataGridViewTextBoxColumn
            // 
            this.tujuanDataGridViewTextBoxColumn.DataPropertyName = "Tujuan";
            this.tujuanDataGridViewTextBoxColumn.HeaderText = "Tujuan";
            this.tujuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tujuanDataGridViewTextBoxColumn.Name = "tujuanDataGridViewTextBoxColumn";
            this.tujuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.tujuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomorKursiDataGridViewTextBoxColumn
            // 
            this.nomorKursiDataGridViewTextBoxColumn.DataPropertyName = "NomorKursi";
            this.nomorKursiDataGridViewTextBoxColumn.HeaderText = "NomorKursi";
            this.nomorKursiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorKursiDataGridViewTextBoxColumn.Name = "nomorKursiDataGridViewTextBoxColumn";
            this.nomorKursiDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomorKursiDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisDataGridViewTextBoxColumn
            // 
            this.jenisDataGridViewTextBoxColumn.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisDataGridViewTextBoxColumn.Name = "jenisDataGridViewTextBoxColumn";
            this.jenisDataGridViewTextBoxColumn.ReadOnly = true;
            this.jenisDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalDataGridViewTextBoxColumn1
            // 
            this.tanggalDataGridViewTextBoxColumn1.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn1.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tanggalDataGridViewTextBoxColumn1.Name = "tanggalDataGridViewTextBoxColumn1";
            this.tanggalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tanggalDataGridViewTextBoxColumn1.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn1
            // 
            this.hargaDataGridViewTextBoxColumn1.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn1.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn1.Name = "hargaDataGridViewTextBoxColumn1";
            this.hargaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hargaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kodeBookingDataGridViewTextBoxColumn1
            // 
            this.kodeBookingDataGridViewTextBoxColumn1.DataPropertyName = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn1.HeaderText = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kodeBookingDataGridViewTextBoxColumn1.Name = "kodeBookingDataGridViewTextBoxColumn1";
            this.kodeBookingDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kodeBookingDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1773, 668);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        //private travelDatabaseDataSet travelDatabaseDataSet;
        //private travelDatabaseDataSet1 travelDatabaseDataSet1;
        private System.Windows.Forms.BindingSource travelDataBindingSource;
        //private travelDatabaseDataSet1TableAdapters.travelDataTableAdapter travelDataTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTanggal;
        private travelDatabaseDataSet2 travelDatabaseDataSet2;
        private System.Windows.Forms.BindingSource travelDataBindingSource1;
        private travelDatabaseDataSet2TableAdapters.travelDataTableAdapter travelDataTableAdapter1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textKode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tujuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorKursiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBookingDataGridViewTextBoxColumn1;
    }
}

