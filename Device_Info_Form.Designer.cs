namespace SPFlash
{
    partial class Device_Info_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Device_Info_Form));
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Copy_Button = new System.Windows.Forms.Button();
            this.Output_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBox
            // 
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox.Location = new System.Drawing.Point(12, 12);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(760, 408);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            // 
            // Copy_Button
            // 
            this.Copy_Button.Location = new System.Drawing.Point(607, 426);
            this.Copy_Button.Name = "Copy_Button";
            this.Copy_Button.Size = new System.Drawing.Size(165, 23);
            this.Copy_Button.TabIndex = 1;
            this.Copy_Button.Text = "复制以上信息到剪切板";
            this.Copy_Button.UseVisualStyleBackColor = true;
            this.Copy_Button.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // Output_Button
            // 
            this.Output_Button.Location = new System.Drawing.Point(436, 426);
            this.Output_Button.Name = "Output_Button";
            this.Output_Button.Size = new System.Drawing.Size(165, 23);
            this.Output_Button.TabIndex = 2;
            this.Output_Button.Text = "将以上信息导出为文件";
            this.Output_Button.UseVisualStyleBackColor = true;
            this.Output_Button.Click += new System.EventHandler(this.Output_Button_Click);
            // 
            // Device_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Output_Button);
            this.Controls.Add(this.Copy_Button);
            this.Controls.Add(this.RichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Device_Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device_Info_Form";
            this.Load += new System.EventHandler(this.Device_Info_Form_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button Copy_Button;
        private System.Windows.Forms.Button Output_Button;
    }
}