namespace LabelCreatorSU627
{
    partial class LabelCreatorfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelCreatorfrm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chksu627w = new System.Windows.Forms.CheckBox();
            this.chksu627s = new System.Windows.Forms.CheckBox();
            this.lbldevicetype = new System.Windows.Forms.Label();
            this.rdbExcel = new System.Windows.Forms.RadioButton();
            this.rdbManually = new System.Windows.Forms.RadioButton();
            this.lblprintype = new System.Windows.Forms.Label();
            this.chkserialno = new System.Windows.Forms.CheckBox();
            this.lblserialno = new System.Windows.Forms.Label();
            this.txtserialno = new System.Windows.Forms.TextBox();
            this.gbserialno = new System.Windows.Forms.GroupBox();
            this.btnserialno = new System.Windows.Forms.Button();
            this.gbmanual = new System.Windows.Forms.GroupBox();
            this.btnmprintlbl = new System.Windows.Forms.Button();
            this.txtmimeino = new System.Windows.Forms.TextBox();
            this.txtmsimno = new System.Windows.Forms.TextBox();
            this.lblmimeino = new System.Windows.Forms.Label();
            this.txtmserialno = new System.Windows.Forms.TextBox();
            this.lblmsinno = new System.Windows.Forms.Label();
            this.lblmserialno = new System.Windows.Forms.Label();
            this.lblnote = new System.Windows.Forms.Label();
            this.gbexcel = new System.Windows.Forms.GroupBox();
            this.btnprintLabel = new System.Windows.Forms.Button();
            this.btnexcelpath = new System.Windows.Forms.Button();
            this.txtexcelpath = new System.Windows.Forms.TextBox();
            this.lblexceldir = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.gbserialno.SuspendLayout();
            this.gbmanual.SuspendLayout();
            this.gbexcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(211, -30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.chksu627w);
            this.panel3.Controls.Add(this.chksu627s);
            this.panel3.Controls.Add(this.lbldevicetype);
            this.panel3.Controls.Add(this.rdbExcel);
            this.panel3.Controls.Add(this.rdbManually);
            this.panel3.Controls.Add(this.lblprintype);
            this.panel3.Location = new System.Drawing.Point(2, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 30);
            this.panel3.TabIndex = 22;
            // 
            // chksu627w
            // 
            this.chksu627w.AutoSize = true;
            this.chksu627w.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksu627w.ForeColor = System.Drawing.Color.White;
            this.chksu627w.Location = new System.Drawing.Point(195, 6);
            this.chksu627w.Name = "chksu627w";
            this.chksu627w.Size = new System.Drawing.Size(81, 19);
            this.chksu627w.TabIndex = 28;
            this.chksu627w.Text = "SU627W";
            this.chksu627w.UseVisualStyleBackColor = true;
            // 
            // chksu627s
            // 
            this.chksu627s.AutoSize = true;
            this.chksu627s.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksu627s.ForeColor = System.Drawing.Color.White;
            this.chksu627s.Location = new System.Drawing.Point(112, 6);
            this.chksu627s.Name = "chksu627s";
            this.chksu627s.Size = new System.Drawing.Size(78, 19);
            this.chksu627s.TabIndex = 27;
            this.chksu627s.Text = "SU627S";
            this.chksu627s.UseVisualStyleBackColor = true;
            // 
            // lbldevicetype
            // 
            this.lbldevicetype.AutoSize = true;
            this.lbldevicetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldevicetype.ForeColor = System.Drawing.Color.White;
            this.lbldevicetype.Location = new System.Drawing.Point(18, 6);
            this.lbldevicetype.Name = "lbldevicetype";
            this.lbldevicetype.Size = new System.Drawing.Size(84, 15);
            this.lbldevicetype.TabIndex = 20;
            this.lbldevicetype.Text = "Device Type";
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel.ForeColor = System.Drawing.Color.White;
            this.rdbExcel.Location = new System.Drawing.Point(534, 6);
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Size = new System.Drawing.Size(64, 19);
            this.rdbExcel.TabIndex = 19;
            this.rdbExcel.Text = "Excel ";
            this.rdbExcel.UseVisualStyleBackColor = true;
            this.rdbExcel.CheckedChanged += new System.EventHandler(this.rdbExcel_CheckedChanged);
            // 
            // rdbManually
            // 
            this.rdbManually.AutoSize = true;
            this.rdbManually.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbManually.ForeColor = System.Drawing.Color.White;
            this.rdbManually.Location = new System.Drawing.Point(448, 4);
            this.rdbManually.Name = "rdbManually";
            this.rdbManually.Size = new System.Drawing.Size(83, 19);
            this.rdbManually.TabIndex = 18;
            this.rdbManually.Text = "Manually";
            this.rdbManually.UseVisualStyleBackColor = true;
            this.rdbManually.CheckedChanged += new System.EventHandler(this.rdbManually_CheckedChanged);
            // 
            // lblprintype
            // 
            this.lblprintype.AutoSize = true;
            this.lblprintype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprintype.ForeColor = System.Drawing.Color.White;
            this.lblprintype.Location = new System.Drawing.Point(370, 6);
            this.lblprintype.Name = "lblprintype";
            this.lblprintype.Size = new System.Drawing.Size(71, 15);
            this.lblprintype.TabIndex = 17;
            this.lblprintype.Text = "Print Type";
            // 
            // chkserialno
            // 
            this.chkserialno.AutoSize = true;
            this.chkserialno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkserialno.Location = new System.Drawing.Point(206, 105);
            this.chkserialno.Name = "chkserialno";
            this.chkserialno.Size = new System.Drawing.Size(203, 21);
            this.chkserialno.TabIndex = 23;
            this.chkserialno.Text = "Generate Serial Number";
            this.chkserialno.UseVisualStyleBackColor = true;
            this.chkserialno.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblserialno
            // 
            this.lblserialno.AutoSize = true;
            this.lblserialno.Location = new System.Drawing.Point(146, 27);
            this.lblserialno.Name = "lblserialno";
            this.lblserialno.Size = new System.Drawing.Size(160, 13);
            this.lblserialno.TabIndex = 24;
            this.lblserialno.Text = "Total Number Of Serial Number :";
            // 
            // txtserialno
            // 
            this.txtserialno.Location = new System.Drawing.Point(318, 24);
            this.txtserialno.Name = "txtserialno";
            this.txtserialno.Size = new System.Drawing.Size(57, 20);
            this.txtserialno.TabIndex = 25;
            // 
            // gbserialno
            // 
            this.gbserialno.Controls.Add(this.btnserialno);
            this.gbserialno.Controls.Add(this.lblserialno);
            this.gbserialno.Controls.Add(this.txtserialno);
            this.gbserialno.Location = new System.Drawing.Point(44, 394);
            this.gbserialno.Name = "gbserialno";
            this.gbserialno.Size = new System.Drawing.Size(534, 108);
            this.gbserialno.TabIndex = 26;
            this.gbserialno.TabStop = false;
            this.gbserialno.Text = "Generate Serial Numbers";
            this.gbserialno.Visible = false;
            // 
            // btnserialno
            // 
            this.btnserialno.Location = new System.Drawing.Point(167, 59);
            this.btnserialno.Name = "btnserialno";
            this.btnserialno.Size = new System.Drawing.Size(185, 35);
            this.btnserialno.TabIndex = 26;
            this.btnserialno.Text = "Generate Serial Number (Notepad)";
            this.btnserialno.UseVisualStyleBackColor = true;
            this.btnserialno.Click += new System.EventHandler(this.btnserialno_Click);
            // 
            // gbmanual
            // 
            this.gbmanual.Controls.Add(this.btnmprintlbl);
            this.gbmanual.Controls.Add(this.txtmimeino);
            this.gbmanual.Controls.Add(this.txtmsimno);
            this.gbmanual.Controls.Add(this.lblmimeino);
            this.gbmanual.Controls.Add(this.txtmserialno);
            this.gbmanual.Controls.Add(this.lblmsinno);
            this.gbmanual.Controls.Add(this.lblmserialno);
            this.gbmanual.Location = new System.Drawing.Point(44, 519);
            this.gbmanual.Name = "gbmanual";
            this.gbmanual.Size = new System.Drawing.Size(534, 159);
            this.gbmanual.TabIndex = 27;
            this.gbmanual.TabStop = false;
            this.gbmanual.Text = "Manual Entries";
            this.gbmanual.Visible = false;
            // 
            // btnmprintlbl
            // 
            this.btnmprintlbl.Location = new System.Drawing.Point(223, 114);
            this.btnmprintlbl.Name = "btnmprintlbl";
            this.btnmprintlbl.Size = new System.Drawing.Size(105, 35);
            this.btnmprintlbl.TabIndex = 30;
            this.btnmprintlbl.Text = "Print Label";
            this.btnmprintlbl.UseVisualStyleBackColor = true;
            this.btnmprintlbl.Click += new System.EventHandler(this.btnmprintlbl_Click);
            // 
            // txtmimeino
            // 
            this.txtmimeino.Location = new System.Drawing.Point(207, 75);
            this.txtmimeino.Name = "txtmimeino";
            this.txtmimeino.Size = new System.Drawing.Size(150, 20);
            this.txtmimeino.TabIndex = 29;
            // 
            // txtmsimno
            // 
            this.txtmsimno.Location = new System.Drawing.Point(207, 49);
            this.txtmsimno.Name = "txtmsimno";
            this.txtmsimno.Size = new System.Drawing.Size(150, 20);
            this.txtmsimno.TabIndex = 28;
            // 
            // lblmimeino
            // 
            this.lblmimeino.AutoSize = true;
            this.lblmimeino.Location = new System.Drawing.Point(132, 82);
            this.lblmimeino.Name = "lblmimeino";
            this.lblmimeino.Size = new System.Drawing.Size(52, 13);
            this.lblmimeino.TabIndex = 2;
            this.lblmimeino.Text = "IMEI No :";
            // 
            // txtmserialno
            // 
            this.txtmserialno.Location = new System.Drawing.Point(207, 19);
            this.txtmserialno.Name = "txtmserialno";
            this.txtmserialno.Size = new System.Drawing.Size(150, 20);
            this.txtmserialno.TabIndex = 27;
            // 
            // lblmsinno
            // 
            this.lblmsinno.AutoSize = true;
            this.lblmsinno.Location = new System.Drawing.Point(132, 52);
            this.lblmsinno.Name = "lblmsinno";
            this.lblmsinno.Size = new System.Drawing.Size(47, 13);
            this.lblmsinno.TabIndex = 1;
            this.lblmsinno.Text = "Sim No :";
            // 
            // lblmserialno
            // 
            this.lblmserialno.AutoSize = true;
            this.lblmserialno.Location = new System.Drawing.Point(132, 26);
            this.lblmserialno.Name = "lblmserialno";
            this.lblmserialno.Size = new System.Drawing.Size(56, 13);
            this.lblmserialno.TabIndex = 0;
            this.lblmserialno.Text = "Serial No :";
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.Location = new System.Drawing.Point(112, 313);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(358, 17);
            this.lblnote.TabIndex = 28;
            this.lblnote.Text = "Note: Set printer as a default printerbefore print";
            // 
            // gbexcel
            // 
            this.gbexcel.Controls.Add(this.btnprintLabel);
            this.gbexcel.Controls.Add(this.btnexcelpath);
            this.gbexcel.Controls.Add(this.txtexcelpath);
            this.gbexcel.Controls.Add(this.lblexceldir);
            this.gbexcel.Location = new System.Drawing.Point(44, 132);
            this.gbexcel.Name = "gbexcel";
            this.gbexcel.Size = new System.Drawing.Size(534, 116);
            this.gbexcel.TabIndex = 29;
            this.gbexcel.TabStop = false;
            this.gbexcel.Text = "Excel Enties";
            this.gbexcel.Visible = false;
            // 
            // btnprintLabel
            // 
            this.btnprintLabel.Location = new System.Drawing.Point(311, 71);
            this.btnprintLabel.Name = "btnprintLabel";
            this.btnprintLabel.Size = new System.Drawing.Size(94, 39);
            this.btnprintLabel.TabIndex = 3;
            this.btnprintLabel.Text = "Print Label";
            this.btnprintLabel.UseVisualStyleBackColor = true;
            this.btnprintLabel.Click += new System.EventHandler(this.btnprintLabel_Click);
            // 
            // btnexcelpath
            // 
            this.btnexcelpath.Location = new System.Drawing.Point(159, 71);
            this.btnexcelpath.Name = "btnexcelpath";
            this.btnexcelpath.Size = new System.Drawing.Size(94, 39);
            this.btnexcelpath.TabIndex = 2;
            this.btnexcelpath.Text = "Broswe Excel";
            this.btnexcelpath.UseVisualStyleBackColor = true;
            this.btnexcelpath.Click += new System.EventHandler(this.btnexcelpath_Click);
            // 
            // txtexcelpath
            // 
            this.txtexcelpath.Location = new System.Drawing.Point(149, 33);
            this.txtexcelpath.Name = "txtexcelpath";
            this.txtexcelpath.Size = new System.Drawing.Size(320, 20);
            this.txtexcelpath.TabIndex = 1;
            // 
            // lblexceldir
            // 
            this.lblexceldir.AutoSize = true;
            this.lblexceldir.Location = new System.Drawing.Point(65, 40);
            this.lblexceldir.Name = "lblexceldir";
            this.lblexceldir.Size = new System.Drawing.Size(61, 13);
            this.lblexceldir.TabIndex = 0;
            this.lblexceldir.Text = "Excel Path:";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // LabelCreatorfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 706);
            this.Controls.Add(this.gbexcel);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.gbmanual);
            this.Controls.Add(this.gbserialno);
            this.Controls.Add(this.chkserialno);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "LabelCreatorfrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Creator";
            this.Load += new System.EventHandler(this.LabelCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbserialno.ResumeLayout(false);
            this.gbserialno.PerformLayout();
            this.gbmanual.ResumeLayout(false);
            this.gbmanual.PerformLayout();
            this.gbexcel.ResumeLayout(false);
            this.gbexcel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbldevicetype;
        private System.Windows.Forms.RadioButton rdbExcel;
        private System.Windows.Forms.RadioButton rdbManually;
        private System.Windows.Forms.Label lblprintype;
        private System.Windows.Forms.CheckBox chkserialno;
        private System.Windows.Forms.Label lblserialno;
        private System.Windows.Forms.TextBox txtserialno;
        private System.Windows.Forms.GroupBox gbserialno;
        private System.Windows.Forms.Button btnserialno;
        private System.Windows.Forms.CheckBox chksu627w;
        private System.Windows.Forms.CheckBox chksu627s;
        private System.Windows.Forms.GroupBox gbmanual;
        private System.Windows.Forms.Button btnmprintlbl;
        private System.Windows.Forms.TextBox txtmimeino;
        private System.Windows.Forms.TextBox txtmsimno;
        private System.Windows.Forms.TextBox txtmserialno;
        private System.Windows.Forms.Label lblmimeino;
        private System.Windows.Forms.Label lblmsinno;
        private System.Windows.Forms.Label lblmserialno;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.GroupBox gbexcel;
        private System.Windows.Forms.Button btnprintLabel;
        private System.Windows.Forms.Button btnexcelpath;
        private System.Windows.Forms.TextBox txtexcelpath;
        private System.Windows.Forms.Label lblexceldir;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
    }
}

