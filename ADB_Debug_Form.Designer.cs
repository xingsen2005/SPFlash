namespace SPFlash
{
    partial class ADB_Debug_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADB_Debug_Form));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ADB_Debug_TabPage = new System.Windows.Forms.TabPage();
            this.USB_Debug_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.WiFi_Debug_TabPage = new System.Windows.Forms.TabPage();
            this.WiFi_Debug_Rich_TextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.ADB_Debug_TabPage.SuspendLayout();
            this.WiFi_Debug_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ADB_Debug_TabPage);
            this.tabControl.Controls.Add(this.WiFi_Debug_TabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 425);
            this.tabControl.TabIndex = 0;
            // 
            // ADB_Debug_TabPage
            // 
            this.ADB_Debug_TabPage.Controls.Add(this.USB_Debug_RichTextBox);
            this.ADB_Debug_TabPage.Location = new System.Drawing.Point(4, 22);
            this.ADB_Debug_TabPage.Name = "ADB_Debug_TabPage";
            this.ADB_Debug_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ADB_Debug_TabPage.Size = new System.Drawing.Size(767, 399);
            this.ADB_Debug_TabPage.TabIndex = 0;
            this.ADB_Debug_TabPage.Text = "USB 调试";
            this.ADB_Debug_TabPage.UseVisualStyleBackColor = true;
            // 
            // USB_Debug_RichTextBox
            // 
            this.USB_Debug_RichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.USB_Debug_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USB_Debug_RichTextBox.ForeColor = System.Drawing.Color.Lime;
            this.USB_Debug_RichTextBox.Location = new System.Drawing.Point(6, 6);
            this.USB_Debug_RichTextBox.Name = "USB_Debug_RichTextBox";
            this.USB_Debug_RichTextBox.ReadOnly = true;
            this.USB_Debug_RichTextBox.Size = new System.Drawing.Size(754, 320);
            this.USB_Debug_RichTextBox.TabIndex = 1;
            this.USB_Debug_RichTextBox.Text = "";
            // 
            // WiFi_Debug_TabPage
            // 
            this.WiFi_Debug_TabPage.Controls.Add(this.WiFi_Debug_Rich_TextBox);
            this.WiFi_Debug_TabPage.Location = new System.Drawing.Point(4, 22);
            this.WiFi_Debug_TabPage.Name = "WiFi_Debug_TabPage";
            this.WiFi_Debug_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.WiFi_Debug_TabPage.Size = new System.Drawing.Size(767, 399);
            this.WiFi_Debug_TabPage.TabIndex = 1;
            this.WiFi_Debug_TabPage.Text = "无线调试";
            this.WiFi_Debug_TabPage.UseVisualStyleBackColor = true;
            // 
            // WiFi_Debug_Rich_TextBox
            // 
            this.WiFi_Debug_Rich_TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WiFi_Debug_Rich_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WiFi_Debug_Rich_TextBox.ForeColor = System.Drawing.Color.Lime;
            this.WiFi_Debug_Rich_TextBox.Location = new System.Drawing.Point(6, 6);
            this.WiFi_Debug_Rich_TextBox.Name = "WiFi_Debug_Rich_TextBox";
            this.WiFi_Debug_Rich_TextBox.ReadOnly = true;
            this.WiFi_Debug_Rich_TextBox.Size = new System.Drawing.Size(754, 320);
            this.WiFi_Debug_Rich_TextBox.TabIndex = 0;
            this.WiFi_Debug_Rich_TextBox.Text = "";
            // 
            // ADB_Debug_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADB_Debug_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开始调试";
            this.Load += new System.EventHandler(this.ADB_Debug_Form_Load);
            this.tabControl.ResumeLayout(false);
            this.ADB_Debug_TabPage.ResumeLayout(false);
            this.WiFi_Debug_TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ADB_Debug_TabPage;
        private System.Windows.Forms.TabPage WiFi_Debug_TabPage;
        private System.Windows.Forms.RichTextBox WiFi_Debug_Rich_TextBox;
        private System.Windows.Forms.RichTextBox USB_Debug_RichTextBox;
    }
}