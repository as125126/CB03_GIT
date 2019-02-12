namespace bus0917_CS
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.main_tab_control = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.frame_picturebox = new System.Windows.Forms.PictureBox();
            this.stop_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.add_face_tab = new System.Windows.Forms.TabPage();
            this.add_face_cancel_button = new System.Windows.Forms.Button();
            this.add_face_start_button = new System.Windows.Forms.Button();
            this.add_face_name_label = new System.Windows.Forms.Label();
            this.add_face_name_textbox = new System.Windows.Forms.TextBox();
            this.train_tab = new System.Windows.Forms.TabPage();
            this.train_title_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.train_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageListView = new System.Windows.Forms.ListView();
            this.finish_add_picture_button = new System.Windows.Forms.Button();
            this.stream_ip_textbox = new System.Windows.Forms.TextBox();
            this.main_tab_control.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frame_picturebox)).BeginInit();
            this.add_face_tab.SuspendLayout();
            this.train_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tab_control
            // 
            this.main_tab_control.Controls.Add(this.Main);
            this.main_tab_control.Controls.Add(this.add_face_tab);
            this.main_tab_control.Controls.Add(this.train_tab);
            this.main_tab_control.Location = new System.Drawing.Point(12, 12);
            this.main_tab_control.Name = "main_tab_control";
            this.main_tab_control.SelectedIndex = 0;
            this.main_tab_control.Size = new System.Drawing.Size(776, 462);
            this.main_tab_control.TabIndex = 0;
            this.main_tab_control.SelectedIndexChanged += new System.EventHandler(this.main_tab_control_SelectedIndexChanged);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.stream_ip_textbox);
            this.Main.Controls.Add(this.frame_picturebox);
            this.Main.Controls.Add(this.stop_button);
            this.Main.Controls.Add(this.start_button);
            this.Main.Location = new System.Drawing.Point(4, 25);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(768, 433);
            this.Main.TabIndex = 3;
            this.Main.Text = "main_oage";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // frame_picturebox
            // 
            this.frame_picturebox.Location = new System.Drawing.Point(24, 45);
            this.frame_picturebox.Name = "frame_picturebox";
            this.frame_picturebox.Size = new System.Drawing.Size(724, 353);
            this.frame_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame_picturebox.TabIndex = 2;
            this.frame_picturebox.TabStop = false;
            this.frame_picturebox.Visible = false;
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(665, 16);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 1;
            this.stop_button.Text = "stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(571, 16);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // add_face_tab
            // 
            this.add_face_tab.Controls.Add(this.finish_add_picture_button);
            this.add_face_tab.Controls.Add(this.imageListView);
            this.add_face_tab.Controls.Add(this.add_face_cancel_button);
            this.add_face_tab.Controls.Add(this.add_face_start_button);
            this.add_face_tab.Controls.Add(this.add_face_name_label);
            this.add_face_tab.Controls.Add(this.add_face_name_textbox);
            this.add_face_tab.Location = new System.Drawing.Point(4, 25);
            this.add_face_tab.Name = "add_face_tab";
            this.add_face_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_face_tab.Size = new System.Drawing.Size(768, 433);
            this.add_face_tab.TabIndex = 1;
            this.add_face_tab.Text = "add_face";
            this.add_face_tab.UseVisualStyleBackColor = true;
            // 
            // add_face_cancel_button
            // 
            this.add_face_cancel_button.Location = new System.Drawing.Point(515, 344);
            this.add_face_cancel_button.Name = "add_face_cancel_button";
            this.add_face_cancel_button.Size = new System.Drawing.Size(75, 23);
            this.add_face_cancel_button.TabIndex = 3;
            this.add_face_cancel_button.Text = "cancel";
            this.add_face_cancel_button.UseVisualStyleBackColor = true;
            this.add_face_cancel_button.Click += new System.EventHandler(this.add_face_cancel_button_Click);
            // 
            // add_face_start_button
            // 
            this.add_face_start_button.Enabled = false;
            this.add_face_start_button.Location = new System.Drawing.Point(135, 344);
            this.add_face_start_button.Name = "add_face_start_button";
            this.add_face_start_button.Size = new System.Drawing.Size(75, 23);
            this.add_face_start_button.TabIndex = 2;
            this.add_face_start_button.Text = "start";
            this.add_face_start_button.UseVisualStyleBackColor = true;
            this.add_face_start_button.Click += new System.EventHandler(this.add_face_start_button_Click);
            // 
            // add_face_name_label
            // 
            this.add_face_name_label.AutoSize = true;
            this.add_face_name_label.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add_face_name_label.Location = new System.Drawing.Point(51, 27);
            this.add_face_name_label.Name = "add_face_name_label";
            this.add_face_name_label.Size = new System.Drawing.Size(117, 40);
            this.add_face_name_label.TabIndex = 1;
            this.add_face_name_label.Text = "Name:";
            // 
            // add_face_name_textbox
            // 
            this.add_face_name_textbox.Font = new System.Drawing.Font("新細明體", 24F);
            this.add_face_name_textbox.Location = new System.Drawing.Point(179, 24);
            this.add_face_name_textbox.Name = "add_face_name_textbox";
            this.add_face_name_textbox.Size = new System.Drawing.Size(381, 55);
            this.add_face_name_textbox.TabIndex = 0;
            this.add_face_name_textbox.TextChanged += new System.EventHandler(this.add_face_name_textbox_TextChanged);
            // 
            // train_tab
            // 
            this.train_tab.Controls.Add(this.train_title_label);
            this.train_tab.Controls.Add(this.label2);
            this.train_tab.Controls.Add(this.train_button);
            this.train_tab.Location = new System.Drawing.Point(4, 25);
            this.train_tab.Name = "train_tab";
            this.train_tab.Padding = new System.Windows.Forms.Padding(3);
            this.train_tab.Size = new System.Drawing.Size(768, 433);
            this.train_tab.TabIndex = 5;
            this.train_tab.Text = "train";
            this.train_tab.UseVisualStyleBackColor = true;
            // 
            // train_title_label
            // 
            this.train_title_label.AutoSize = true;
            this.train_title_label.Location = new System.Drawing.Point(293, 26);
            this.train_title_label.Name = "train_title_label";
            this.train_title_label.Size = new System.Drawing.Size(38, 15);
            this.train_title_label.TabIndex = 3;
            this.train_title_label.Text = " Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // train_button
            // 
            this.train_button.Location = new System.Drawing.Point(350, 367);
            this.train_button.Name = "train_button";
            this.train_button.Size = new System.Drawing.Size(75, 23);
            this.train_button.TabIndex = 1;
            this.train_button.Text = "Train";
            this.train_button.UseVisualStyleBackColor = true;
            this.train_button.Click += new System.EventHandler(this.train_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // imageListView
            // 
            this.imageListView.Location = new System.Drawing.Point(58, 105);
            this.imageListView.Name = "imageListView";
            this.imageListView.Size = new System.Drawing.Size(678, 233);
            this.imageListView.TabIndex = 4;
            this.imageListView.UseCompatibleStateImageBehavior = false;
            this.imageListView.SelectedIndexChanged += new System.EventHandler(this.imageListView_SelectedIndexChanged);
            // 
            // finish_add_picture_button
            // 
            this.finish_add_picture_button.Enabled = false;
            this.finish_add_picture_button.Location = new System.Drawing.Point(332, 343);
            this.finish_add_picture_button.Name = "finish_add_picture_button";
            this.finish_add_picture_button.Size = new System.Drawing.Size(75, 23);
            this.finish_add_picture_button.TabIndex = 5;
            this.finish_add_picture_button.Text = "Finish";
            this.finish_add_picture_button.UseVisualStyleBackColor = true;
            this.finish_add_picture_button.Visible = false;
            this.finish_add_picture_button.Click += new System.EventHandler(this.finish_add_picture_button_Click);
            // 
            // stream_ip_textbox
            // 
            this.stream_ip_textbox.Location = new System.Drawing.Point(233, 14);
            this.stream_ip_textbox.Name = "stream_ip_textbox";
            this.stream_ip_textbox.Size = new System.Drawing.Size(326, 25);
            this.stream_ip_textbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_tab_control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_tab_control.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frame_picturebox)).EndInit();
            this.add_face_tab.ResumeLayout(false);
            this.add_face_tab.PerformLayout();
            this.train_tab.ResumeLayout(false);
            this.train_tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl main_tab_control;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage add_face_tab;
        private System.Windows.Forms.TabPage train_tab;
        private System.Windows.Forms.Button add_face_start_button;
        private System.Windows.Forms.Label add_face_name_label;
        private System.Windows.Forms.TextBox add_face_name_textbox;
        private System.Windows.Forms.Button add_face_cancel_button;
        private System.Windows.Forms.Button train_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label train_title_label;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PictureBox frame_picturebox;
        private System.Windows.Forms.ListView imageListView;
        private System.Windows.Forms.Button finish_add_picture_button;
        private System.Windows.Forms.TextBox stream_ip_textbox;
    }
}

