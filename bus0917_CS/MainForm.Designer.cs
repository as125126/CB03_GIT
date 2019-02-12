﻿namespace bus0917_CS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iPConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DatabaseTabControl = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.FunctionsTabControl = new System.Windows.Forms.TabControl();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TakePictureTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.takePicTextBox = new System.Windows.Forms.TextBox();
            this.takePicStartButton = new System.Windows.Forms.Button();
            this.takePicFinishButton = new System.Windows.Forms.Button();
            this.takePicCancelButton = new System.Windows.Forms.Button();
            this.takePicListView = new System.Windows.Forms.ListView();
            this.takePicLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TrainXMLTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trainingTitleLabel = new System.Windows.Forms.Label();
            this.trainingStatusLabel = new System.Windows.Forms.Label();
            this.trainingTrainButton = new System.Windows.Forms.Button();
            this.trainingListView = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.updata_timer = new System.Windows.Forms.Timer(this.components);
            this.receiver_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.FunctionsTabControl.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TakePictureTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.TrainXMLTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1604, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPConfigToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // iPConfigToolStripMenuItem
            // 
            this.iPConfigToolStripMenuItem.Name = "iPConfigToolStripMenuItem";
            this.iPConfigToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.iPConfigToolStripMenuItem.Text = "IP (re)config";
            this.iPConfigToolStripMenuItem.Click += new System.EventHandler(this.iPConfigToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Enabled = false;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.updateToolStripMenuItem.Text = "Update Data";
            this.updateToolStripMenuItem.Visible = false;
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.15686F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.Controls.Add(this.DatabaseTabControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1604, 849);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DatabaseTabControl
            // 
            this.DatabaseTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseTabControl.Location = new System.Drawing.Point(6, 5);
            this.DatabaseTabControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DatabaseTabControl.Name = "DatabaseTabControl";
            this.DatabaseTabControl.SelectedIndex = 0;
            this.DatabaseTabControl.Size = new System.Drawing.Size(664, 839);
            this.DatabaseTabControl.TabIndex = 0;
            this.DatabaseTabControl.SelectedIndexChanged += new System.EventHandler(this.DatabaseTabControl_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.FunctionsTabControl, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(820, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(781, 843);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // FunctionsTabControl
            // 
            this.FunctionsTabControl.Controls.Add(this.InfoTab);
            this.FunctionsTabControl.Controls.Add(this.TakePictureTab);
            this.FunctionsTabControl.Controls.Add(this.TrainXMLTab);
            this.FunctionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionsTabControl.Location = new System.Drawing.Point(6, 426);
            this.FunctionsTabControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.FunctionsTabControl.Name = "FunctionsTabControl";
            this.FunctionsTabControl.SelectedIndex = 0;
            this.FunctionsTabControl.Size = new System.Drawing.Size(769, 412);
            this.FunctionsTabControl.TabIndex = 4;
            this.FunctionsTabControl.SelectedIndexChanged += new System.EventHandler(this.FunctionsTabControl_SelectedIndexChanged);
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.tableLayoutPanel2);
            this.InfoTab.Location = new System.Drawing.Point(4, 38);
            this.InfoTab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InfoTab.Size = new System.Drawing.Size(761, 370);
            this.InfoTab.TabIndex = 0;
            this.InfoTab.Text = "Info";
            this.InfoTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(749, 360);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 72);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 72);
            this.label4.TabIndex = 3;
            this.label4.Text = "Card";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 72);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP Connection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(380, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 72);
            this.label6.TabIndex = 5;
            this.label6.Text = "Not Detected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(380, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 72);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(380, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 72);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(380, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 72);
            this.label9.TabIndex = 8;
            this.label9.Text = "Not Detected";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(380, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 72);
            this.label10.TabIndex = 9;
            this.label10.Text = "Not Connected. \r\nPlease Check: Menu->IP Config";
            // 
            // TakePictureTab
            // 
            this.TakePictureTab.Controls.Add(this.tableLayoutPanel3);
            this.TakePictureTab.Location = new System.Drawing.Point(4, 38);
            this.TakePictureTab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TakePictureTab.Name = "TakePictureTab";
            this.TakePictureTab.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TakePictureTab.Size = new System.Drawing.Size(761, 372);
            this.TakePictureTab.TabIndex = 1;
            this.TakePictureTab.Text = "Take Picture";
            this.TakePictureTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.takePicTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.takePicStartButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.takePicFinishButton, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.takePicCancelButton, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.takePicListView, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.takePicLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26165F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.34409F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(749, 362);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 48);
            this.label11.TabIndex = 0;
            this.label11.Text = "File Name ";
            // 
            // takePicTextBox
            // 
            this.takePicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.takePicTextBox, 2);
            this.takePicTextBox.Location = new System.Drawing.Point(255, 5);
            this.takePicTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.takePicTextBox.Name = "takePicTextBox";
            this.takePicTextBox.Size = new System.Drawing.Size(488, 38);
            this.takePicTextBox.TabIndex = 1;
            // 
            // takePicStartButton
            // 
            this.takePicStartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takePicStartButton.AutoSize = true;
            this.takePicStartButton.Location = new System.Drawing.Point(86, 290);
            this.takePicStartButton.Name = "takePicStartButton";
            this.takePicStartButton.Size = new System.Drawing.Size(76, 41);
            this.takePicStartButton.TabIndex = 2;
            this.takePicStartButton.Text = "Start";
            this.takePicStartButton.UseVisualStyleBackColor = true;
            this.takePicStartButton.Click += new System.EventHandler(this.takePicStartButton_Click);
            // 
            // takePicFinishButton
            // 
            this.takePicFinishButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takePicFinishButton.AutoSize = true;
            this.takePicFinishButton.Enabled = false;
            this.takePicFinishButton.Location = new System.Drawing.Point(328, 290);
            this.takePicFinishButton.Name = "takePicFinishButton";
            this.takePicFinishButton.Size = new System.Drawing.Size(91, 41);
            this.takePicFinishButton.TabIndex = 3;
            this.takePicFinishButton.Text = "Finish";
            this.takePicFinishButton.UseVisualStyleBackColor = true;
            this.takePicFinishButton.Click += new System.EventHandler(this.takePicFinishButton_Click);
            // 
            // takePicCancelButton
            // 
            this.takePicCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takePicCancelButton.AutoSize = true;
            this.takePicCancelButton.Enabled = false;
            this.takePicCancelButton.Location = new System.Drawing.Point(573, 290);
            this.takePicCancelButton.Name = "takePicCancelButton";
            this.takePicCancelButton.Size = new System.Drawing.Size(100, 41);
            this.takePicCancelButton.TabIndex = 4;
            this.takePicCancelButton.Text = "Cancel";
            this.takePicCancelButton.UseVisualStyleBackColor = true;
            this.takePicCancelButton.Click += new System.EventHandler(this.takePicCancelButton_Click);
            // 
            // takePicListView
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.takePicListView, 3);
            this.takePicListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.takePicListView.Location = new System.Drawing.Point(3, 86);
            this.takePicListView.Name = "takePicListView";
            this.takePicListView.Size = new System.Drawing.Size(743, 198);
            this.takePicListView.TabIndex = 5;
            this.takePicListView.UseCompatibleStateImageBehavior = false;
            this.takePicListView.SelectedIndexChanged += new System.EventHandler(this.takePicListView_SelectedIndexChanged);
            // 
            // takePicLabel
            // 
            this.takePicLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.takePicLabel, 3);
            this.takePicLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.takePicLabel.Location = new System.Drawing.Point(3, 334);
            this.takePicLabel.Name = "takePicLabel";
            this.takePicLabel.Size = new System.Drawing.Size(743, 28);
            this.takePicLabel.TabIndex = 6;
            this.takePicLabel.Text = "takePicLabel";
            this.takePicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label14.Location = new System.Drawing.Point(3, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 35);
            this.label14.TabIndex = 7;
            this.label14.Text = "Student ID";
            // 
            // comboBox1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.comboBox1, 2);
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(494, 37);
            this.comboBox1.TabIndex = 8;
            // 
            // TrainXMLTab
            // 
            this.TrainXMLTab.Controls.Add(this.tableLayoutPanel4);
            this.TrainXMLTab.Location = new System.Drawing.Point(4, 38);
            this.TrainXMLTab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TrainXMLTab.Name = "TrainXMLTab";
            this.TrainXMLTab.Size = new System.Drawing.Size(761, 372);
            this.TrainXMLTab.TabIndex = 2;
            this.TrainXMLTab.Text = "Training";
            this.TrainXMLTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.trainingTitleLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.trainingStatusLabel, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.trainingTrainButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.trainingListView, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(761, 372);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // trainingTitleLabel
            // 
            this.trainingTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainingTitleLabel.AutoSize = true;
            this.trainingTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.trainingTitleLabel.Name = "trainingTitleLabel";
            this.trainingTitleLabel.Size = new System.Drawing.Size(755, 31);
            this.trainingTitleLabel.TabIndex = 0;
            this.trainingTitleLabel.Text = "Title";
            // 
            // trainingStatusLabel
            // 
            this.trainingStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trainingStatusLabel.AutoSize = true;
            this.trainingStatusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingStatusLabel.Location = new System.Drawing.Point(296, 350);
            this.trainingStatusLabel.Name = "trainingStatusLabel";
            this.trainingStatusLabel.Size = new System.Drawing.Size(168, 22);
            this.trainingStatusLabel.TabIndex = 1;
            this.trainingStatusLabel.Text = "TrainingStatusLabel";
            // 
            // trainingTrainButton
            // 
            this.trainingTrainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trainingTrainButton.Location = new System.Drawing.Point(313, 316);
            this.trainingTrainButton.Name = "trainingTrainButton";
            this.trainingTrainButton.Size = new System.Drawing.Size(134, 31);
            this.trainingTrainButton.TabIndex = 2;
            this.trainingTrainButton.Text = "Train";
            this.trainingTrainButton.UseVisualStyleBackColor = true;
            this.trainingTrainButton.Click += new System.EventHandler(this.trainingTrainButton_Click);
            // 
            // trainingListView
            // 
            this.trainingListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingListView.Location = new System.Drawing.Point(3, 34);
            this.trainingListView.Name = "trainingListView";
            this.trainingListView.Size = new System.Drawing.Size(755, 276);
            this.trainingListView.TabIndex = 3;
            this.trainingListView.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.listBox1);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(679, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(135, 843);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Columns Name";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(3, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 33);
            this.listBox1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label13.Location = new System.Drawing.Point(3, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox1.Location = new System.Drawing.Point(3, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 30);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(3, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(3, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Default";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // updata_timer
            // 
            this.updata_timer.Enabled = true;
            this.updata_timer.Interval = 5000;
            this.updata_timer.Tick += new System.EventHandler(this.updata_timer_Tick);
            // 
            // receiver_backgroundWorker
            // 
            this.receiver_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.receiver_backgroundWorker_DoWork);
            this.receiver_backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.receiver_backgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Text = "FaceRec.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.FunctionsTabControl.ResumeLayout(false);
            this.InfoTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.TakePictureTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.TrainXMLTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iPConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl DatabaseTabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl FunctionsTabControl;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage TakePictureTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button takePicStartButton;
        private System.Windows.Forms.Button takePicFinishButton;
        private System.Windows.Forms.Button takePicCancelButton;
        private System.Windows.Forms.Label takePicLabel;
        private System.Windows.Forms.TabPage TrainXMLTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label trainingTitleLabel;
        private System.Windows.Forms.Label trainingStatusLabel;
        private System.Windows.Forms.Button trainingTrainButton;
        private System.Windows.Forms.ListView trainingListView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox takePicTextBox;
        private System.Windows.Forms.ListView takePicListView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer updata_timer;
        private System.ComponentModel.BackgroundWorker receiver_backgroundWorker;
    }
}