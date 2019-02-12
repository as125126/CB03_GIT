namespace bus0917_CS
{
    partial class input_ip_box
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
            this.ok_button = new System.Windows.Forms.Button();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(143, 83);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(56, 20);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // ip_textbox
            // 
            this.ip_textbox.Location = new System.Drawing.Point(57, 44);
            this.ip_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(234, 20);
            this.ip_textbox.TabIndex = 1;
            // 
            // input_ip_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 133);
            this.ControlBox = false;
            this.Controls.Add(this.ip_textbox);
            this.Controls.Add(this.ok_button);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "input_ip_box";
            this.Text = "input_ip_box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox ip_textbox;
    }
}