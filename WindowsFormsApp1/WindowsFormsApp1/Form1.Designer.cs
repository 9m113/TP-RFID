using System;

namespace WindowsFormsApp1
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lAPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPEEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFIDINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new WindowsFormsApp1.DemoDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btContinue = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btStopRead = new System.Windows.Forms.Button();
            this.btReadMulti = new System.Windows.Forms.Button();
            this.btReadSingle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comBAUDRAT = new System.Windows.Forms.ComboBox();
            this.comPOTNO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comSTATUS = new System.Windows.Forms.Label();
            this.rFIDINFOTableAdapter = new WindowsFormsApp1.DemoDataSetTableAdapters.RFIDINFOTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.setselect = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MemBank = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btEPCTableClear = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFIDINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Carolo_Cup_Logo_rgb_0;
            this.pictureBox2.Location = new System.Drawing.Point(2, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.TU_Braunschweig_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(787, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tag Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 406);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Running Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 371);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INFO Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNIDataGridViewTextBoxColumn,
            this.tEAMDataGridViewTextBoxColumn,
            this.cARNODataGridViewTextBoxColumn,
            this.lAPSDataGridViewTextBoxColumn,
            this.sPEEDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rFIDINFOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // uNIDataGridViewTextBoxColumn
            // 
            this.uNIDataGridViewTextBoxColumn.DataPropertyName = "UNI";
            this.uNIDataGridViewTextBoxColumn.HeaderText = "UNI";
            this.uNIDataGridViewTextBoxColumn.Name = "uNIDataGridViewTextBoxColumn";
            this.uNIDataGridViewTextBoxColumn.Width = 175;
            // 
            // tEAMDataGridViewTextBoxColumn
            // 
            this.tEAMDataGridViewTextBoxColumn.DataPropertyName = "TEAM";
            this.tEAMDataGridViewTextBoxColumn.HeaderText = "TEAM";
            this.tEAMDataGridViewTextBoxColumn.Name = "tEAMDataGridViewTextBoxColumn";
            this.tEAMDataGridViewTextBoxColumn.Width = 105;
            // 
            // cARNODataGridViewTextBoxColumn
            // 
            this.cARNODataGridViewTextBoxColumn.DataPropertyName = "CARNO";
            this.cARNODataGridViewTextBoxColumn.HeaderText = "CARNO";
            this.cARNODataGridViewTextBoxColumn.Name = "cARNODataGridViewTextBoxColumn";
            // 
            // lAPSDataGridViewTextBoxColumn
            // 
            this.lAPSDataGridViewTextBoxColumn.DataPropertyName = "LAPS";
            this.lAPSDataGridViewTextBoxColumn.HeaderText = "LAPS";
            this.lAPSDataGridViewTextBoxColumn.Name = "lAPSDataGridViewTextBoxColumn";
            // 
            // sPEEDDataGridViewTextBoxColumn
            // 
            this.sPEEDDataGridViewTextBoxColumn.DataPropertyName = "SPEED";
            this.sPEEDDataGridViewTextBoxColumn.HeaderText = "SPEED";
            this.sPEEDDataGridViewTextBoxColumn.Name = "sPEEDDataGridViewTextBoxColumn";
            // 
            // rFIDINFOBindingSource
            // 
            this.rFIDINFOBindingSource.DataMember = "RFIDINFO";
            this.rFIDINFOBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "DemoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btContinue);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btStopRead);
            this.groupBox2.Controls.Add(this.btReadMulti);
            this.groupBox2.Controls.Add(this.btReadSingle);
            this.groupBox2.Location = new System.Drawing.Point(642, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory";
            // 
            // btContinue
            // 
            this.btContinue.Location = new System.Drawing.Point(16, 117);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(75, 21);
            this.btContinue.TabIndex = 5;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btStopRead
            // 
            this.btStopRead.Location = new System.Drawing.Point(202, 80);
            this.btStopRead.Name = "btStopRead";
            this.btStopRead.Size = new System.Drawing.Size(75, 22);
            this.btStopRead.TabIndex = 2;
            this.btStopRead.Text = "Stop Read";
            this.btStopRead.UseVisualStyleBackColor = true;
            // 
            // btReadMulti
            // 
            this.btReadMulti.Location = new System.Drawing.Point(16, 79);
            this.btReadMulti.Name = "btReadMulti";
            this.btReadMulti.Size = new System.Drawing.Size(75, 22);
            this.btReadMulti.TabIndex = 1;
            this.btReadMulti.Text = "Read Multi";
            this.btReadMulti.UseVisualStyleBackColor = true;
            // 
            // btReadSingle
            // 
            this.btReadSingle.Location = new System.Drawing.Point(16, 35);
            this.btReadSingle.Name = "btReadSingle";
            this.btReadSingle.Size = new System.Drawing.Size(75, 22);
            this.btReadSingle.TabIndex = 0;
            this.btReadSingle.Text = "Read Single";
            this.btReadSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBAUDRAT);
            this.groupBox1.Controls.Add(this.comPOTNO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(642, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Connection";
            // 
            // comBAUDRAT
            // 
            this.comBAUDRAT.FormattingEnabled = true;
            this.comBAUDRAT.Items.AddRange(new object[] {
            "9600",
            "19200",
            "119600"});
            this.comBAUDRAT.Location = new System.Drawing.Point(84, 50);
            this.comBAUDRAT.Name = "comBAUDRAT";
            this.comBAUDRAT.Size = new System.Drawing.Size(94, 21);
            this.comBAUDRAT.TabIndex = 6;
            this.comBAUDRAT.SelectedIndexChanged += new System.EventHandler(this.comBAUDRAT_SelectedIndexChanged);
            // 
            // comPOTNO
            // 
            this.comPOTNO.FormattingEnabled = true;
            this.comPOTNO.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.comPOTNO.Location = new System.Drawing.Point(84, 23);
            this.comPOTNO.Name = "comPOTNO";
            this.comPOTNO.Size = new System.Drawing.Size(94, 21);
            this.comPOTNO.TabIndex = 5;
            this.comPOTNO.SelectedIndexChanged += new System.EventHandler(this.comPOTNO_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port.No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comSTATUS
            // 
            this.comSTATUS.AutoSize = true;
            this.comSTATUS.ForeColor = System.Drawing.Color.Red;
            this.comSTATUS.Location = new System.Drawing.Point(494, 425);
            this.comSTATUS.Name = "comSTATUS";
            this.comSTATUS.Size = new System.Drawing.Size(61, 13);
            this.comSTATUS.TabIndex = 5;
            this.comSTATUS.Text = "Com Status";
            this.comSTATUS.Click += new System.EventHandler(this.comSTATUS_Click);
            // 
            // rFIDINFOTableAdapter
            // 
            this.rFIDINFOTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.MemBank);
            this.groupBox4.Location = new System.Drawing.Point(463, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 127);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read/Write Tag Memory";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.setselect);
            this.groupBox5.Location = new System.Drawing.Point(463, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 98);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set Parameter";
            // 
            // setselect
            // 
            this.setselect.Location = new System.Drawing.Point(29, 67);
            this.setselect.Name = "setselect";
            this.setselect.Size = new System.Drawing.Size(78, 23);
            this.setselect.TabIndex = 0;
            this.setselect.Text = "Set Selsct";
            this.setselect.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(113, 69);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(62, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target";
            // 
            // MemBank
            // 
            this.MemBank.FormattingEnabled = true;
            this.MemBank.Items.AddRange(new object[] {
            "RFU",
            "EPC",
            "TID",
            "User"});
            this.MemBank.Location = new System.Drawing.Point(26, 48);
            this.MemBank.Name = "MemBank";
            this.MemBank.Size = new System.Drawing.Size(58, 21);
            this.MemBank.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(355, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MemBank";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(259, 20);
            this.textBox6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btEPCTableClear);
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(7, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(450, 367);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "EPC Table";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(437, 308);
            this.dataGridView2.TabIndex = 0;
            // 
            // btEPCTableClear
            // 
            this.btEPCTableClear.Location = new System.Drawing.Point(339, 19);
            this.btEPCTableClear.Name = "btEPCTableClear";
            this.btEPCTableClear.Size = new System.Drawing.Size(75, 23);
            this.btEPCTableClear.TabIndex = 1;
            this.btEPCTableClear.Text = "Clear";
            this.btEPCTableClear.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(463, 238);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(461, 61);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lock";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(463, 305);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(461, 69);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kill";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 463);
            this.Controls.Add(this.comSTATUS);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFIDINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comBAUDRAT;
        private System.Windows.Forms.ComboBox comPOTNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label comSTATUS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btStopRead;
        private System.Windows.Forms.Button btReadMulti;
        private System.Windows.Forms.Button btReadSingle;
        private DemoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource rFIDINFOBindingSource;
        private DemoDataSetTableAdapters.RFIDINFOTableAdapter rFIDINFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lAPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPEEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button setselect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox MemBank;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btEPCTableClear;
    }
}

