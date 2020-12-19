﻿namespace GTA5_RPF_FiveM_Convertor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddQueue = new System.Windows.Forms.Button();
            this.queueList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gta5mods_tb = new GTA5_RPF_FiveM_Convertor.PlaceHolderTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gta5mods_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gta5path_status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vmenucheck = new System.Windows.Forms.CheckBox();
            this.fivemresname_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.reslua = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.delspace = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.jobTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsQueue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBar = new System.Windows.Forms.ToolStripProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.gtaFolder_tb = new System.Windows.Forms.TextBox();
            this.btnConvertFromFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnAddQueue);
            this.groupBox1.Controls.Add(this.queueList);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.gta5mods_tb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gta5mods_status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RPF Selector";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Clear queue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddQueue
            // 
            this.btnAddQueue.Enabled = false;
            this.btnAddQueue.Location = new System.Drawing.Point(6, 68);
            this.btnAddQueue.Name = "btnAddQueue";
            this.btnAddQueue.Size = new System.Drawing.Size(102, 23);
            this.btnAddQueue.TabIndex = 18;
            this.btnAddQueue.Text = "Add to queue";
            this.btnAddQueue.UseVisualStyleBackColor = true;
            this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
            // 
            // queueList
            // 
            this.queueList.FormattingEnabled = true;
            this.queueList.ItemHeight = 16;
            this.queueList.Location = new System.Drawing.Point(6, 113);
            this.queueList.Name = "queueList";
            this.queueList.Size = new System.Drawing.Size(452, 116);
            this.queueList.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Queue";
            // 
            // gta5mods_tb
            // 
            this.gta5mods_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gta5mods_tb.ForeColor = System.Drawing.Color.Gray;
            this.gta5mods_tb.Location = new System.Drawing.Point(9, 39);
            this.gta5mods_tb.Name = "gta5mods_tb";
            this.gta5mods_tb.PlaceHolderText = "https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zip";
            this.gta5mods_tb.Size = new System.Drawing.Size(443, 22);
            this.gta5mods_tb.TabIndex = 15;
            this.gta5mods_tb.Text = "https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zipp";
            this.gta5mods_tb.TextChanged += new System.EventHandler(this.placeHolderTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // gta5mods_status
            // 
            this.gta5mods_status.AutoSize = true;
            this.gta5mods_status.BackColor = System.Drawing.SystemColors.Control;
            this.gta5mods_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gta5mods_status.ForeColor = System.Drawing.Color.Crimson;
            this.gta5mods_status.Location = new System.Drawing.Point(377, 20);
            this.gta5mods_status.Name = "gta5mods_status";
            this.gta5mods_status.Size = new System.Drawing.Size(75, 16);
            this.gta5mods_status.TabIndex = 10;
            this.gta5mods_status.Text = "BAD LINK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add to queue";
            // 
            // gta5path_status
            // 
            this.gta5path_status.AutoSize = true;
            this.gta5path_status.BackColor = System.Drawing.SystemColors.Control;
            this.gta5path_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gta5path_status.ForeColor = System.Drawing.Color.Crimson;
            this.gta5path_status.Location = new System.Drawing.Point(396, 12);
            this.gta5path_status.Name = "gta5path_status";
            this.gta5path_status.Size = new System.Drawing.Size(74, 16);
            this.gta5path_status.TabIndex = 9;
            this.gta5path_status.Text = "NOT SET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "GTA folder path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.log);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(476, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 497);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(6, 17);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(591, 470);
            this.log.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(196, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "buildname epicgames_support | developed by: github.com/Avenze";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.vmenucheck);
            this.groupBox3.Controls.Add(this.fivemresname_tb);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resource";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(9, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(267, 20);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "change in-game name (COMING SOON)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(264, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(185, 22);
            this.textBox6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Custom vehicle in-game name";
            // 
            // vmenucheck
            // 
            this.vmenucheck.AutoSize = true;
            this.vmenucheck.Checked = true;
            this.vmenucheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vmenucheck.Enabled = false;
            this.vmenucheck.Location = new System.Drawing.Point(9, 91);
            this.vmenucheck.Name = "vmenucheck";
            this.vmenucheck.Size = new System.Drawing.Size(373, 20);
            this.vmenucheck.TabIndex = 14;
            this.vmenucheck.Text = "vMenu / server.cfg helper (check directory after converting)\r\n";
            this.vmenucheck.UseVisualStyleBackColor = true;
            this.vmenucheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fivemresname_tb
            // 
            this.fivemresname_tb.Location = new System.Drawing.Point(12, 37);
            this.fivemresname_tb.Name = "fivemresname_tb";
            this.fivemresname_tb.Size = new System.Drawing.Size(246, 22);
            this.fivemresname_tb.TabIndex = 13;
            this.fivemresname_tb.Text = "default";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "FiveM Resource name";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 486);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // reslua
            // 
            this.reslua.Location = new System.Drawing.Point(897, 563);
            this.reslua.Multiline = true;
            this.reslua.Name = "reslua";
            this.reslua.Size = new System.Drawing.Size(557, 236);
            this.reslua.TabIndex = 10;
            this.reslua.Text = resources.GetString("reslua.Text");
            this.reslua.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // delspace
            // 
            this.delspace.Location = new System.Drawing.Point(422, 551);
            this.delspace.Multiline = true;
            this.delspace.Name = "delspace";
            this.delspace.Size = new System.Drawing.Size(469, 248);
            this.delspace.TabIndex = 12;
            this.delspace.Text = "@Echo Off\r\nCD cache\\unpack\r\nFOR /D /r %%G in (\"*\") DO move \"%%~nxG\" nospace";
            this.delspace.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.jobTime,
            this.toolStripStatusLabel1,
            this.tsQueue,
            this.tsBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1091, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "tsStatus";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(67, 17);
            this.tsStatus.Text = "Status:  Idle";
            this.tsStatus.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // jobTime
            // 
            this.jobTime.Name = "jobTime";
            this.jobTime.Size = new System.Drawing.Size(109, 17);
            this.jobTime.Text = "| Last job time: 0ms";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(733, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tsQueue
            // 
            this.tsQueue.Name = "tsQueue";
            this.tsQueue.Size = new System.Drawing.Size(65, 17);
            this.tsQueue.Text = "Queue: 0/0";
            // 
            // tsBar
            // 
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(100, 16);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gtaFolder_tb
            // 
            this.gtaFolder_tb.Location = new System.Drawing.Point(11, 29);
            this.gtaFolder_tb.Name = "gtaFolder_tb";
            this.gtaFolder_tb.ReadOnly = true;
            this.gtaFolder_tb.Size = new System.Drawing.Size(459, 22);
            this.gtaFolder_tb.TabIndex = 22;
            // 
            // btnConvertFromFolder
            // 
            this.btnConvertFromFolder.Enabled = false;
            this.btnConvertFromFolder.Location = new System.Drawing.Point(93, 486);
            this.btnConvertFromFolder.Name = "btnConvertFromFolder";
            this.btnConvertFromFolder.Size = new System.Drawing.Size(146, 23);
            this.btnConvertFromFolder.TabIndex = 20;
            this.btnConvertFromFolder.Text = "Convert from folder";
            this.btnConvertFromFolder.UseVisualStyleBackColor = true;
            this.btnConvertFromFolder.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1091, 539);
            this.Controls.Add(this.gtaFolder_tb);
            this.Controls.Add(this.btnConvertFromFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.delspace);
            this.Controls.Add(this.reslua);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gta5path_status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Elysium: GTA5Mods to FiveM AddOn Converter ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gta5mods_status;
        private System.Windows.Forms.Label gta5path_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox vmenucheck;
        private System.Windows.Forms.TextBox fivemresname_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reslua;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox delspace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsQueue;
        private PlaceHolderTextBox gta5mods_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox queueList;
        private System.Windows.Forms.Button btnAddQueue;
        private System.Windows.Forms.ToolStripProgressBar tsBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripStatusLabel jobTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gtaFolder_tb;
        private System.Windows.Forms.Button btnConvertFromFolder;
    }
}
