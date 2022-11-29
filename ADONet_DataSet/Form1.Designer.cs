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
            this.travelDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDatabaseDataSet = new ADONet_DataSet.travelDatabaseDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Location = new System.Drawing.Point(534, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 374);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Penumpang";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.travelDatabaseDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(380, 224);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // travelDatabaseDataSetBindingSource
            // 
            this.travelDatabaseDataSetBindingSource.DataSource = this.travelDatabaseDataSet;
            this.travelDatabaseDataSetBindingSource.Position = 0;
            // 
            // travelDatabaseDataSet
            // 
            this.travelDatabaseDataSet.DataSetName = "travelDatabaseDataSet";
            this.travelDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(41, 43);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(80, 30);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Display";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
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
            this.boxJenis.Location = new System.Drawing.Point(310, 193);
            this.boxJenis.Name = "boxJenis";
            this.boxJenis.Size = new System.Drawing.Size(110, 28);
            this.boxJenis.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
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
            this.boxTujuan.Name = "boxTujuan";
            this.boxTujuan.Size = new System.Drawing.Size(269, 28);
            this.boxTujuan.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
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
            this.boxKursi.Location = new System.Drawing.Point(151, 195);
            this.boxKursi.Name = "boxKursi";
            this.boxKursi.Size = new System.Drawing.Size(66, 28);
            this.boxKursi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(310, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(310, 266);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 37);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textNIK
            // 
            this.textNIK.Location = new System.Drawing.Point(151, 98);
            this.textNIK.Name = "textNIK";
            this.textNIK.Size = new System.Drawing.Size(269, 26);
            this.textNIK.TabIndex = 2;
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(151, 47);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(269, 26);
            this.textNama.TabIndex = 0;
            this.textNama.Text = "\r\n";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 374);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Jendela Travel";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDatabaseDataSet)).EndInit();
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
        private travelDatabaseDataSet travelDatabaseDataSet;
    }
}

