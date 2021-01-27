namespace OBDTool
{
    partial class frmOBDLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOBDLabel));
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbManually = new System.Windows.Forms.RadioButton();
            this.rdbExcel = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCopies = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelExcel = new System.Windows.Forms.Panel();
            this.panelManually = new System.Windows.Forms.Panel();
            this.ttximei = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsrnumber = new System.Windows.Forms.TextBox();
            this.txtsimnumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdb_default = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelExcel.SuspendLayout();
            this.panelManually.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(145, 279);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(256, 29);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Label";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Device";
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk3.ForeColor = System.Drawing.Color.White;
            this.chk3.Location = new System.Drawing.Point(292, 10);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(75, 19);
            this.chk3.TabIndex = 8;
            this.chk3.Text = "SU627W";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.Chkmt05_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2.ForeColor = System.Drawing.Color.White;
            this.chk2.Location = new System.Drawing.Point(175, 9);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(72, 19);
            this.chk2.TabIndex = 9;
            this.chk2.Text = "SU627S";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.Chk2283g_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(133, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Browse Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(96, 23);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.ReadOnly = true;
            this.txtfilepath.Size = new System.Drawing.Size(335, 20);
            this.txtfilepath.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, -26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 51);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(0, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(547, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Progress: Completed 10% (0/200)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Generating Label for ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(204, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Print Type";
            // 
            // rdbManually
            // 
            this.rdbManually.AutoSize = true;
            this.rdbManually.Checked = true;
            this.rdbManually.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbManually.ForeColor = System.Drawing.Color.White;
            this.rdbManually.Location = new System.Drawing.Point(289, 6);
            this.rdbManually.Name = "rdbManually";
            this.rdbManually.Size = new System.Drawing.Size(83, 19);
            this.rdbManually.TabIndex = 18;
            this.rdbManually.TabStop = true;
            this.rdbManually.Text = "Manually";
            this.rdbManually.UseVisualStyleBackColor = true;
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel.ForeColor = System.Drawing.Color.White;
            this.rdbExcel.Location = new System.Drawing.Point(403, 6);
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Size = new System.Drawing.Size(64, 19);
            this.rdbExcel.TabIndex = 19;
            this.rdbExcel.Text = "Excel ";
            this.rdbExcel.UseVisualStyleBackColor = true;
            this.rdbExcel.CheckedChanged += new System.EventHandler(this.RdbExcel_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(96)))), ((int)(((byte)(161)))));
            this.panel2.Controls.Add(this.chk2);
            this.panel2.Controls.Add(this.chk3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 36);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.cmbCopies);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.rdbExcel);
            this.panel3.Controls.Add(this.rdbManually);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 30);
            this.panel3.TabIndex = 21;
            // 
            // cmbCopies
            // 
            this.cmbCopies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCopies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopies.FormattingEnabled = true;
            this.cmbCopies.Items.AddRange(new object[] {
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
            this.cmbCopies.Location = new System.Drawing.Point(124, 3);
            this.cmbCopies.Name = "cmbCopies";
            this.cmbCopies.Size = new System.Drawing.Size(46, 21);
            this.cmbCopies.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "No of Copies";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Note: Set printer as default printer before print";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(103, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(335, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(571, 65);
            this.panel4.TabIndex = 24;
            this.panel4.Visible = false;
            // 
            // panelExcel
            // 
            this.panelExcel.Controls.Add(this.txtfilepath);
            this.panelExcel.Controls.Add(this.button1);
            this.panelExcel.Location = new System.Drawing.Point(12, 148);
            this.panelExcel.Name = "panelExcel";
            this.panelExcel.Size = new System.Drawing.Size(540, 94);
            this.panelExcel.TabIndex = 25;
            this.panelExcel.Visible = false;
            // 
            // panelManually
            // 
            this.panelManually.Controls.Add(this.ttximei);
            this.panelManually.Controls.Add(this.label9);
            this.panelManually.Controls.Add(this.txtsrnumber);
            this.panelManually.Controls.Add(this.txtsimnumber);
            this.panelManually.Controls.Add(this.label8);
            this.panelManually.Controls.Add(this.label7);
            this.panelManually.Location = new System.Drawing.Point(14, 150);
            this.panelManually.Name = "panelManually";
            this.panelManually.Size = new System.Drawing.Size(517, 127);
            this.panelManually.TabIndex = 26;
            // 
            // ttximei
            // 
            this.ttximei.Location = new System.Drawing.Point(110, 89);
            this.ttximei.Name = "ttximei";
            this.ttximei.Size = new System.Drawing.Size(344, 20);
            this.ttximei.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "IMEI";
            // 
            // txtsrnumber
            // 
            this.txtsrnumber.Location = new System.Drawing.Point(110, 18);
            this.txtsrnumber.Name = "txtsrnumber";
            this.txtsrnumber.Size = new System.Drawing.Size(344, 20);
            this.txtsrnumber.TabIndex = 3;
            // 
            // txtsimnumber
            // 
            this.txtsimnumber.Location = new System.Drawing.Point(110, 53);
            this.txtsimnumber.Name = "txtsimnumber";
            this.txtsimnumber.Size = new System.Drawing.Size(344, 20);
            this.txtsimnumber.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Serial Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sim Number";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.rdb_default);
            this.panel5.Location = new System.Drawing.Point(8, 431);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 33);
            this.panel5.TabIndex = 29;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton2.Location = new System.Drawing.Point(283, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 20);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Select Printer Manually";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // rdb_default
            // 
            this.rdb_default.AutoSize = true;
            this.rdb_default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdb_default.Location = new System.Drawing.Point(105, 3);
            this.rdb_default.Name = "rdb_default";
            this.rdb_default.Size = new System.Drawing.Size(152, 20);
            this.rdb_default.TabIndex = 27;
            this.rdb_default.Text = "Print to Default Printer";
            this.rdb_default.UseVisualStyleBackColor = true;
            this.rdb_default.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(145, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 29);
            this.button2.TabIndex = 30;
            this.button2.Text = "Generate Serial Number (Excel)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Location = new System.Drawing.Point(0, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(620, 37);
            this.panel6.TabIndex = 31;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox1.Location = new System.Drawing.Point(173, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 19);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Generate Serial Number";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.txttotal);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Location = new System.Drawing.Point(0, 149);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(547, 186);
            this.panel7.TabIndex = 32;
            this.panel7.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.progressBar2);
            this.panel8.Location = new System.Drawing.Point(0, 22);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(552, 151);
            this.panel8.TabIndex = 33;
            this.panel8.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(138, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Please Wait, Generating Device Serial Numbers";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(75, 90);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(410, 10);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar2.TabIndex = 0;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(266, 53);
            this.txttotal.MaxLength = 4;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(159, 20);
            this.txttotal.TabIndex = 32;
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total Number of Serial Number";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // frmOBDLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 465);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelManually);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelExcel);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOBDLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekurUs SU627S & SU627W ";
            this.Load += new System.EventHandler(this.FrmOBDLabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelExcel.ResumeLayout(false);
            this.panelExcel.PerformLayout();
            this.panelManually.ResumeLayout(false);
            this.panelManually.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbManually;
        private System.Windows.Forms.RadioButton rdbExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCopies;
        private System.Windows.Forms.Panel panelExcel;
        private System.Windows.Forms.Panel panelManually;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsrnumber;
        private System.Windows.Forms.TextBox txtsimnumber;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdb_default;
        private System.Windows.Forms.TextBox ttximei;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

