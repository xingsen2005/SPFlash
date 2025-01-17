namespace SPFlash
{
    partial class Custom_Flash_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom_Flash_Form));
            this.Reboot_to_Fstboot_Button = new System.Windows.Forms.Button();
            this.Path_Boot_Button = new System.Windows.Forms.Button();
            this.Select_Input_Path_Button = new System.Windows.Forms.Button();
            this.Select_Input_Path_TextBox = new System.Windows.Forms.TextBox();
            this.Select_Input_Path_Label = new System.Windows.Forms.Label();
            this.Select_Boot_IMG_Button = new System.Windows.Forms.Button();
            this.Boot_File_Path_TextBox = new System.Windows.Forms.TextBox();
            this.Select_Boot_IMG_File_Label = new System.Windows.Forms.Label();
            this.Install_Magisk_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reboot_to_Fstboot_Button
            // 
            this.Reboot_to_Fstboot_Button.Location = new System.Drawing.Point(282, 76);
            this.Reboot_to_Fstboot_Button.Name = "Reboot_to_Fstboot_Button";
            this.Reboot_to_Fstboot_Button.Size = new System.Drawing.Size(125, 23);
            this.Reboot_to_Fstboot_Button.TabIndex = 34;
            this.Reboot_to_Fstboot_Button.Text = "重启到 FASTBOOT";
            this.Reboot_to_Fstboot_Button.UseVisualStyleBackColor = true;
            this.Reboot_to_Fstboot_Button.Click += new System.EventHandler(this.Reboot_to_Fstboot_Button_Click);
            // 
            // Path_Boot_Button
            // 
            this.Path_Boot_Button.Location = new System.Drawing.Point(413, 76);
            this.Path_Boot_Button.Name = "Path_Boot_Button";
            this.Path_Boot_Button.Size = new System.Drawing.Size(125, 23);
            this.Path_Boot_Button.TabIndex = 33;
            this.Path_Boot_Button.Text = "修补 Boot 镜像";
            this.Path_Boot_Button.UseVisualStyleBackColor = true;
            // 
            // Select_Input_Path_Button
            // 
            this.Select_Input_Path_Button.Location = new System.Drawing.Point(463, 47);
            this.Select_Input_Path_Button.Name = "Select_Input_Path_Button";
            this.Select_Input_Path_Button.Size = new System.Drawing.Size(75, 23);
            this.Select_Input_Path_Button.TabIndex = 32;
            this.Select_Input_Path_Button.Text = "浏览...";
            this.Select_Input_Path_Button.UseVisualStyleBackColor = true;
            // 
            // Select_Input_Path_TextBox
            // 
            this.Select_Input_Path_TextBox.Location = new System.Drawing.Point(107, 47);
            this.Select_Input_Path_TextBox.Name = "Select_Input_Path_TextBox";
            this.Select_Input_Path_TextBox.Size = new System.Drawing.Size(350, 21);
            this.Select_Input_Path_TextBox.TabIndex = 31;
            // 
            // Select_Input_Path_Label
            // 
            this.Select_Input_Path_Label.AutoSize = true;
            this.Select_Input_Path_Label.Location = new System.Drawing.Point(12, 51);
            this.Select_Input_Path_Label.Name = "Select_Input_Path_Label";
            this.Select_Input_Path_Label.Size = new System.Drawing.Size(89, 12);
            this.Select_Input_Path_Label.TabIndex = 30;
            this.Select_Input_Path_Label.Text = "选择输出路径：";
            // 
            // Select_Boot_IMG_Button
            // 
            this.Select_Boot_IMG_Button.Location = new System.Drawing.Point(463, 16);
            this.Select_Boot_IMG_Button.Name = "Select_Boot_IMG_Button";
            this.Select_Boot_IMG_Button.Size = new System.Drawing.Size(75, 23);
            this.Select_Boot_IMG_Button.TabIndex = 29;
            this.Select_Boot_IMG_Button.Text = "浏览...";
            this.Select_Boot_IMG_Button.UseVisualStyleBackColor = true;
            this.Select_Boot_IMG_Button.Click += new System.EventHandler(this.Select_Boot_IMG_Button_Click);
            // 
            // Boot_File_Path_TextBox
            // 
            this.Boot_File_Path_TextBox.Location = new System.Drawing.Point(107, 16);
            this.Boot_File_Path_TextBox.Name = "Boot_File_Path_TextBox";
            this.Boot_File_Path_TextBox.Size = new System.Drawing.Size(350, 21);
            this.Boot_File_Path_TextBox.TabIndex = 26;
            // 
            // Select_Boot_IMG_File_Label
            // 
            this.Select_Boot_IMG_File_Label.AutoSize = true;
            this.Select_Boot_IMG_File_Label.Location = new System.Drawing.Point(12, 20);
            this.Select_Boot_IMG_File_Label.Name = "Select_Boot_IMG_File_Label";
            this.Select_Boot_IMG_File_Label.Size = new System.Drawing.Size(89, 12);
            this.Select_Boot_IMG_File_Label.TabIndex = 28;
            this.Select_Boot_IMG_File_Label.Text = "选择镜像文件：";
            // 
            // Install_Magisk_Button
            // 
            this.Install_Magisk_Button.Location = new System.Drawing.Point(151, 76);
            this.Install_Magisk_Button.Name = "Install_Magisk_Button";
            this.Install_Magisk_Button.Size = new System.Drawing.Size(125, 23);
            this.Install_Magisk_Button.TabIndex = 27;
            this.Install_Magisk_Button.Text = "安装 Magisk 应用";
            this.Install_Magisk_Button.UseVisualStyleBackColor = true;
            // 
            // Custom_Flash_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 111);
            this.Controls.Add(this.Reboot_to_Fstboot_Button);
            this.Controls.Add(this.Path_Boot_Button);
            this.Controls.Add(this.Select_Input_Path_Button);
            this.Controls.Add(this.Select_Input_Path_TextBox);
            this.Controls.Add(this.Select_Input_Path_Label);
            this.Controls.Add(this.Select_Boot_IMG_Button);
            this.Controls.Add(this.Boot_File_Path_TextBox);
            this.Controls.Add(this.Select_Boot_IMG_File_Label);
            this.Controls.Add(this.Install_Magisk_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Custom_Flash_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom_Flash_Form";
            this.Load += new System.EventHandler(this.Custom_Flash_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reboot_to_Fstboot_Button;
        private System.Windows.Forms.Button Path_Boot_Button;
        private System.Windows.Forms.Button Select_Input_Path_Button;
        private System.Windows.Forms.TextBox Select_Input_Path_TextBox;
        private System.Windows.Forms.Label Select_Input_Path_Label;
        private System.Windows.Forms.Button Select_Boot_IMG_Button;
        private System.Windows.Forms.TextBox Boot_File_Path_TextBox;
        private System.Windows.Forms.Label Select_Boot_IMG_File_Label;
        private System.Windows.Forms.Button Install_Magisk_Button;
    }
}