namespace MiFlash
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem Recovery_ToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Extract_IMG_GroupBox = new System.Windows.Forms.GroupBox();
            this.Custom_Flash_Button = new System.Windows.Forms.Button();
            this.Open_File_Path_CheckBox = new System.Windows.Forms.CheckBox();
            this.Input_Specific_IMG_ComboBox = new System.Windows.Forms.ComboBox();
            this.Input_Specific_IMG_RadioButton = new System.Windows.Forms.RadioButton();
            this.Input_Button = new System.Windows.Forms.Button();
            this.Input_Init_IMG_RadioButton = new System.Windows.Forms.RadioButton();
            this.Input_Boot_IMG_RadioButton = new System.Windows.Forms.RadioButton();
            this.Input_ALL_IMG_RadioButton = new System.Windows.Forms.RadioButton();
            this.Input_IMG_Button = new System.Windows.Forms.Button();
            this.Input_IMG_TextBox = new System.Windows.Forms.TextBox();
            this.Input_IMG_Lable = new System.Windows.Forms.Label();
            this.Select_Payload_Button = new System.Windows.Forms.Button();
            this.Payload_File_Path_TextBox = new System.Windows.Forms.TextBox();
            this.Select_the_File_Label = new System.Windows.Forms.Label();
            this.Connect_the_Device_GroupBox = new System.Windows.Forms.GroupBox();
            this.Link_Button = new System.Windows.Forms.Button();
            this.Device_Name_Lable = new System.Windows.Forms.Label();
            this.Connect_the_Device_Label = new System.Windows.Forms.Label();
            this.Recovery_RadioButton = new System.Windows.Forms.RadioButton();
            this.FASTBOOT_RadioButton = new System.Windows.Forms.RadioButton();
            this.ADB_RadioButton = new System.Windows.Forms.RadioButton();
            this.Device_Status_Label = new System.Windows.Forms.Label();
            this.Clear_GroupBox = new System.Windows.Forms.GroupBox();
            this.Clear_Data_Button = new System.Windows.Forms.Button();
            this.CL_UserData_CheckBox = new System.Windows.Forms.CheckBox();
            this.CL_Cache_CheckBox = new System.Windows.Forms.CheckBox();
            this.CL_Boot_CheckBox = new System.Windows.Forms.CheckBox();
            this.CL_System_CheckBox = new System.Windows.Forms.CheckBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Download_Flash_File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Device_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Install_Device_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ADB_Debug_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Device_Info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Read_Device_Info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnlockBL_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_Me_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Source_License_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AVB2_GroupBox = new System.Windows.Forms.GroupBox();
            this.Reboot_to_Fstboot_Button = new System.Windows.Forms.Button();
            this.Disable_AVB2_Flash_Button = new System.Windows.Forms.Button();
            this.Enable_AVB2_Flash_Button = new System.Windows.Forms.Button();
            this.Select_Vbmeta_IMG_Button = new System.Windows.Forms.Button();
            this.IMG_Vbmeta_File_Path_TextBox = new System.Windows.Forms.TextBox();
            this.Select_the_IMG_Vbmeta_File_Label = new System.Windows.Forms.Label();
            Recovery_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Extract_IMG_GroupBox.SuspendLayout();
            this.Connect_the_Device_GroupBox.SuspendLayout();
            this.Clear_GroupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.AVB2_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Recovery_ToolStripMenuItem
            // 
            Recovery_ToolStripMenuItem.Name = "Recovery_ToolStripMenuItem";
            Recovery_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            Recovery_ToolStripMenuItem.Text = "下载 / 刷入Recovery";
            Recovery_ToolStripMenuItem.Click += new System.EventHandler(this.Recovery_ToolStripMenuItem_Click);
            // 
            // Extract_IMG_GroupBox
            // 
            this.Extract_IMG_GroupBox.Controls.Add(this.Custom_Flash_Button);
            this.Extract_IMG_GroupBox.Controls.Add(this.Open_File_Path_CheckBox);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_Specific_IMG_ComboBox);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_Specific_IMG_RadioButton);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_Button);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_Init_IMG_RadioButton);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_Boot_IMG_RadioButton);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_ALL_IMG_RadioButton);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_IMG_Button);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_IMG_TextBox);
            this.Extract_IMG_GroupBox.Controls.Add(this.Input_IMG_Lable);
            this.Extract_IMG_GroupBox.Controls.Add(this.Select_Payload_Button);
            this.Extract_IMG_GroupBox.Controls.Add(this.Payload_File_Path_TextBox);
            this.Extract_IMG_GroupBox.Controls.Add(this.Select_the_File_Label);
            this.Extract_IMG_GroupBox.Location = new System.Drawing.Point(13, 30);
            this.Extract_IMG_GroupBox.Name = "Extract_IMG_GroupBox";
            this.Extract_IMG_GroupBox.Size = new System.Drawing.Size(659, 160);
            this.Extract_IMG_GroupBox.TabIndex = 0;
            this.Extract_IMG_GroupBox.TabStop = false;
            this.Extract_IMG_GroupBox.Text = "Setup 01. 提取镜像";
            // 
            // Custom_Flash_Button
            // 
            this.Custom_Flash_Button.Location = new System.Drawing.Point(437, 123);
            this.Custom_Flash_Button.Name = "Custom_Flash_Button";
            this.Custom_Flash_Button.Size = new System.Drawing.Size(135, 23);
            this.Custom_Flash_Button.TabIndex = 14;
            this.Custom_Flash_Button.Text = "获取 Root 权限";
            this.Custom_Flash_Button.UseVisualStyleBackColor = true;
            this.Custom_Flash_Button.Click += new System.EventHandler(this.Custom_Flash_Button_Click);
            // 
            // Open_File_Path_CheckBox
            // 
            this.Open_File_Path_CheckBox.AutoSize = true;
            this.Open_File_Path_CheckBox.Checked = true;
            this.Open_File_Path_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Open_File_Path_CheckBox.Location = new System.Drawing.Point(24, 126);
            this.Open_File_Path_CheckBox.Name = "Open_File_Path_CheckBox";
            this.Open_File_Path_CheckBox.Size = new System.Drawing.Size(156, 16);
            this.Open_File_Path_CheckBox.TabIndex = 13;
            this.Open_File_Path_CheckBox.Text = "导出后打开文件所在位置";
            this.Open_File_Path_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Input_Specific_IMG_ComboBox
            // 
            this.Input_Specific_IMG_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Input_Specific_IMG_ComboBox.Enabled = false;
            this.Input_Specific_IMG_ComboBox.FormattingEnabled = true;
            this.Input_Specific_IMG_ComboBox.Items.AddRange(new object[] {
            "abl",
            "aop",
            "aop_config",
            "bluetooth",
            "boot",
            "cpucp",
            "devcfg",
            "dsp",
            "dtbo",
            "featenabler",
            "hyp",
            "imagefv",
            "init_boot",
            "keymaster",
            "mi_ext",
            "modem",
            "odm",
            "product",
            "qupfw",
            "recovery",
            "shrm",
            "system",
            "system_ext",
            "temp",
            "tz",
            "uefi",
            "uefisecapp",
            "vbmeta",
            "vbmeta_system",
            "vendor",
            "vendor_boot",
            "vendor_dlkm",
            "vm-bootsys",
            "xbl",
            "xbl_config",
            "xbl_ramdump"});
            this.Input_Specific_IMG_ComboBox.Location = new System.Drawing.Point(533, 94);
            this.Input_Specific_IMG_ComboBox.Name = "Input_Specific_IMG_ComboBox";
            this.Input_Specific_IMG_ComboBox.Size = new System.Drawing.Size(120, 20);
            this.Input_Specific_IMG_ComboBox.TabIndex = 12;
            this.Input_Specific_IMG_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Input_Specific_IMG_ComboBox_SelectedIndexChanged);
            // 
            // Input_Specific_IMG_RadioButton
            // 
            this.Input_Specific_IMG_RadioButton.AutoSize = true;
            this.Input_Specific_IMG_RadioButton.Location = new System.Drawing.Point(432, 95);
            this.Input_Specific_IMG_RadioButton.Name = "Input_Specific_IMG_RadioButton";
            this.Input_Specific_IMG_RadioButton.Size = new System.Drawing.Size(95, 16);
            this.Input_Specific_IMG_RadioButton.TabIndex = 11;
            this.Input_Specific_IMG_RadioButton.TabStop = true;
            this.Input_Specific_IMG_RadioButton.Text = "导出指定镜像";
            this.Input_Specific_IMG_RadioButton.UseVisualStyleBackColor = true;
            this.Input_Specific_IMG_RadioButton.CheckedChanged += new System.EventHandler(this.Input_Specific_IMG_RadioButton_CheckedChanged);
            // 
            // Input_Button
            // 
            this.Input_Button.Location = new System.Drawing.Point(578, 123);
            this.Input_Button.Name = "Input_Button";
            this.Input_Button.Size = new System.Drawing.Size(75, 23);
            this.Input_Button.TabIndex = 9;
            this.Input_Button.Text = "导出";
            this.Input_Button.UseVisualStyleBackColor = true;
            this.Input_Button.Click += new System.EventHandler(this.Input_Button_Click);
            // 
            // Input_Init_IMG_RadioButton
            // 
            this.Input_Init_IMG_RadioButton.AutoSize = true;
            this.Input_Init_IMG_RadioButton.Location = new System.Drawing.Point(180, 95);
            this.Input_Init_IMG_RadioButton.Name = "Input_Init_IMG_RadioButton";
            this.Input_Init_IMG_RadioButton.Size = new System.Drawing.Size(119, 16);
            this.Input_Init_IMG_RadioButton.TabIndex = 8;
            this.Input_Init_IMG_RadioButton.Text = "仅导出 Init_Boot";
            this.Input_Init_IMG_RadioButton.UseVisualStyleBackColor = true;
            this.Input_Init_IMG_RadioButton.CheckedChanged += new System.EventHandler(this.Input_Init_IMG_RadioButton_CheckedChanged);
            // 
            // Input_Boot_IMG_RadioButton
            // 
            this.Input_Boot_IMG_RadioButton.AutoSize = true;
            this.Input_Boot_IMG_RadioButton.Checked = true;
            this.Input_Boot_IMG_RadioButton.Location = new System.Drawing.Point(24, 95);
            this.Input_Boot_IMG_RadioButton.Name = "Input_Boot_IMG_RadioButton";
            this.Input_Boot_IMG_RadioButton.Size = new System.Drawing.Size(137, 16);
            this.Input_Boot_IMG_RadioButton.TabIndex = 7;
            this.Input_Boot_IMG_RadioButton.TabStop = true;
            this.Input_Boot_IMG_RadioButton.Text = "仅导出 Boot（推荐）";
            this.Input_Boot_IMG_RadioButton.UseVisualStyleBackColor = true;
            this.Input_Boot_IMG_RadioButton.CheckedChanged += new System.EventHandler(this.Input_Boot_IMG_RadioButton_CheckedChanged);
            // 
            // Input_ALL_IMG_RadioButton
            // 
            this.Input_ALL_IMG_RadioButton.AutoSize = true;
            this.Input_ALL_IMG_RadioButton.Location = new System.Drawing.Point(318, 95);
            this.Input_ALL_IMG_RadioButton.Name = "Input_ALL_IMG_RadioButton";
            this.Input_ALL_IMG_RadioButton.Size = new System.Drawing.Size(95, 16);
            this.Input_ALL_IMG_RadioButton.TabIndex = 6;
            this.Input_ALL_IMG_RadioButton.Text = "导出全部镜像";
            this.Input_ALL_IMG_RadioButton.UseVisualStyleBackColor = true;
            this.Input_ALL_IMG_RadioButton.CheckedChanged += new System.EventHandler(this.Input_ALL_IMG_RadioButton_CheckedChanged);
            // 
            // Input_IMG_Button
            // 
            this.Input_IMG_Button.Location = new System.Drawing.Point(578, 60);
            this.Input_IMG_Button.Name = "Input_IMG_Button";
            this.Input_IMG_Button.Size = new System.Drawing.Size(75, 23);
            this.Input_IMG_Button.TabIndex = 5;
            this.Input_IMG_Button.Text = "浏览...";
            this.Input_IMG_Button.UseVisualStyleBackColor = true;
            this.Input_IMG_Button.Click += new System.EventHandler(this.Input_IMG_Button_Click);
            // 
            // Input_IMG_TextBox
            // 
            this.Input_IMG_TextBox.Location = new System.Drawing.Point(152, 60);
            this.Input_IMG_TextBox.Name = "Input_IMG_TextBox";
            this.Input_IMG_TextBox.Size = new System.Drawing.Size(420, 21);
            this.Input_IMG_TextBox.TabIndex = 4;
            // 
            // Input_IMG_Lable
            // 
            this.Input_IMG_Lable.AutoSize = true;
            this.Input_IMG_Lable.Location = new System.Drawing.Point(22, 65);
            this.Input_IMG_Lable.Name = "Input_IMG_Lable";
            this.Input_IMG_Lable.Size = new System.Drawing.Size(113, 12);
            this.Input_IMG_Lable.TabIndex = 3;
            this.Input_IMG_Lable.Text = "将镜像文件导出到：";
            // 
            // Select_Payload_Button
            // 
            this.Select_Payload_Button.Location = new System.Drawing.Point(578, 27);
            this.Select_Payload_Button.Name = "Select_Payload_Button";
            this.Select_Payload_Button.Size = new System.Drawing.Size(75, 23);
            this.Select_Payload_Button.TabIndex = 2;
            this.Select_Payload_Button.Text = "浏览...";
            this.Select_Payload_Button.UseVisualStyleBackColor = true;
            this.Select_Payload_Button.Click += new System.EventHandler(this.Select_Payload_Button_Click);
            // 
            // Payload_File_Path_TextBox
            // 
            this.Payload_File_Path_TextBox.AllowDrop = true;
            this.Payload_File_Path_TextBox.Location = new System.Drawing.Point(152, 27);
            this.Payload_File_Path_TextBox.Name = "Payload_File_Path_TextBox";
            this.Payload_File_Path_TextBox.Size = new System.Drawing.Size(420, 21);
            this.Payload_File_Path_TextBox.TabIndex = 1;
            // 
            // Select_the_File_Label
            // 
            this.Select_the_File_Label.AutoSize = true;
            this.Select_the_File_Label.Location = new System.Drawing.Point(22, 32);
            this.Select_the_File_Label.Name = "Select_the_File_Label";
            this.Select_the_File_Label.Size = new System.Drawing.Size(119, 12);
            this.Select_the_File_Label.TabIndex = 0;
            this.Select_the_File_Label.Text = "选择 Payload 文件：";
            // 
            // Connect_the_Device_GroupBox
            // 
            this.Connect_the_Device_GroupBox.Controls.Add(this.Link_Button);
            this.Connect_the_Device_GroupBox.Controls.Add(this.Device_Name_Lable);
            this.Connect_the_Device_GroupBox.Controls.Add(this.Connect_the_Device_Label);
            this.Connect_the_Device_GroupBox.Controls.Add(this.Recovery_RadioButton);
            this.Connect_the_Device_GroupBox.Controls.Add(this.FASTBOOT_RadioButton);
            this.Connect_the_Device_GroupBox.Controls.Add(this.ADB_RadioButton);
            this.Connect_the_Device_GroupBox.Controls.Add(this.Device_Status_Label);
            this.Connect_the_Device_GroupBox.Location = new System.Drawing.Point(13, 196);
            this.Connect_the_Device_GroupBox.Name = "Connect_the_Device_GroupBox";
            this.Connect_the_Device_GroupBox.Size = new System.Drawing.Size(659, 105);
            this.Connect_the_Device_GroupBox.TabIndex = 11;
            this.Connect_the_Device_GroupBox.TabStop = false;
            this.Connect_the_Device_GroupBox.Text = "Setup 02. 连接设备";
            // 
            // Link_Button
            // 
            this.Link_Button.Location = new System.Drawing.Point(578, 27);
            this.Link_Button.Name = "Link_Button";
            this.Link_Button.Size = new System.Drawing.Size(75, 23);
            this.Link_Button.TabIndex = 6;
            this.Link_Button.Text = "连接设备";
            this.Link_Button.UseVisualStyleBackColor = true;
            this.Link_Button.Click += new System.EventHandler(this.Link_Button_Click);
            // 
            // Device_Name_Lable
            // 
            this.Device_Name_Lable.AutoSize = true;
            this.Device_Name_Lable.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Device_Name_Lable.ForeColor = System.Drawing.Color.Blue;
            this.Device_Name_Lable.Location = new System.Drawing.Point(178, 65);
            this.Device_Name_Lable.Name = "Device_Name_Lable";
            this.Device_Name_Lable.Size = new System.Drawing.Size(89, 12);
            this.Device_Name_Lable.TabIndex = 5;
            this.Device_Name_Lable.Text = "请选择连接模式";
            // 
            // Connect_the_Device_Label
            // 
            this.Connect_the_Device_Label.AutoSize = true;
            this.Connect_the_Device_Label.Location = new System.Drawing.Point(22, 65);
            this.Connect_the_Device_Label.Name = "Connect_the_Device_Label";
            this.Connect_the_Device_Label.Size = new System.Drawing.Size(77, 12);
            this.Connect_the_Device_Label.TabIndex = 4;
            this.Connect_the_Device_Label.Text = "已连接设备：";
            // 
            // Recovery_RadioButton
            // 
            this.Recovery_RadioButton.AutoSize = true;
            this.Recovery_RadioButton.Location = new System.Drawing.Point(432, 30);
            this.Recovery_RadioButton.Name = "Recovery_RadioButton";
            this.Recovery_RadioButton.Size = new System.Drawing.Size(71, 16);
            this.Recovery_RadioButton.TabIndex = 3;
            this.Recovery_RadioButton.Text = "Recovery";
            this.Recovery_RadioButton.UseVisualStyleBackColor = true;
            // 
            // FASTBOOT_RadioButton
            // 
            this.FASTBOOT_RadioButton.AutoSize = true;
            this.FASTBOOT_RadioButton.Location = new System.Drawing.Point(318, 30);
            this.FASTBOOT_RadioButton.Name = "FASTBOOT_RadioButton";
            this.FASTBOOT_RadioButton.Size = new System.Drawing.Size(71, 16);
            this.FASTBOOT_RadioButton.TabIndex = 2;
            this.FASTBOOT_RadioButton.Text = "FASTBOOT";
            this.FASTBOOT_RadioButton.UseVisualStyleBackColor = true;
            // 
            // ADB_RadioButton
            // 
            this.ADB_RadioButton.AutoSize = true;
            this.ADB_RadioButton.Checked = true;
            this.ADB_RadioButton.Location = new System.Drawing.Point(180, 30);
            this.ADB_RadioButton.Name = "ADB_RadioButton";
            this.ADB_RadioButton.Size = new System.Drawing.Size(71, 16);
            this.ADB_RadioButton.TabIndex = 1;
            this.ADB_RadioButton.TabStop = true;
            this.ADB_RadioButton.Text = "开机状态";
            this.ADB_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Device_Status_Label
            // 
            this.Device_Status_Label.AutoSize = true;
            this.Device_Status_Label.Location = new System.Drawing.Point(22, 32);
            this.Device_Status_Label.Name = "Device_Status_Label";
            this.Device_Status_Label.Size = new System.Drawing.Size(89, 12);
            this.Device_Status_Label.TabIndex = 0;
            this.Device_Status_Label.Text = "当前设备状态：";
            // 
            // Clear_GroupBox
            // 
            this.Clear_GroupBox.Controls.Add(this.Clear_Data_Button);
            this.Clear_GroupBox.Controls.Add(this.CL_UserData_CheckBox);
            this.Clear_GroupBox.Controls.Add(this.CL_Cache_CheckBox);
            this.Clear_GroupBox.Controls.Add(this.CL_Boot_CheckBox);
            this.Clear_GroupBox.Controls.Add(this.CL_System_CheckBox);
            this.Clear_GroupBox.Location = new System.Drawing.Point(13, 308);
            this.Clear_GroupBox.Name = "Clear_GroupBox";
            this.Clear_GroupBox.Size = new System.Drawing.Size(659, 75);
            this.Clear_GroupBox.TabIndex = 13;
            this.Clear_GroupBox.TabStop = false;
            this.Clear_GroupBox.Text = "Setup 03. 清除数据（可选）";
            // 
            // Clear_Data_Button
            // 
            this.Clear_Data_Button.Location = new System.Drawing.Point(518, 27);
            this.Clear_Data_Button.Name = "Clear_Data_Button";
            this.Clear_Data_Button.Size = new System.Drawing.Size(135, 23);
            this.Clear_Data_Button.TabIndex = 4;
            this.Clear_Data_Button.Text = "清除所选分区数据";
            this.Clear_Data_Button.UseVisualStyleBackColor = true;
            this.Clear_Data_Button.Click += new System.EventHandler(this.Clear_Data_Button_Click);
            // 
            // CL_UserData_CheckBox
            // 
            this.CL_UserData_CheckBox.AutoSize = true;
            this.CL_UserData_CheckBox.Checked = true;
            this.CL_UserData_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CL_UserData_CheckBox.Location = new System.Drawing.Point(432, 31);
            this.CL_UserData_CheckBox.Name = "CL_UserData_CheckBox";
            this.CL_UserData_CheckBox.Size = new System.Drawing.Size(72, 16);
            this.CL_UserData_CheckBox.TabIndex = 3;
            this.CL_UserData_CheckBox.Text = "UserData";
            this.CL_UserData_CheckBox.UseVisualStyleBackColor = true;
            // 
            // CL_Cache_CheckBox
            // 
            this.CL_Cache_CheckBox.AutoSize = true;
            this.CL_Cache_CheckBox.Checked = true;
            this.CL_Cache_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CL_Cache_CheckBox.Location = new System.Drawing.Point(318, 31);
            this.CL_Cache_CheckBox.Name = "CL_Cache_CheckBox";
            this.CL_Cache_CheckBox.Size = new System.Drawing.Size(54, 16);
            this.CL_Cache_CheckBox.TabIndex = 2;
            this.CL_Cache_CheckBox.Text = "Cache";
            this.CL_Cache_CheckBox.UseVisualStyleBackColor = true;
            // 
            // CL_Boot_CheckBox
            // 
            this.CL_Boot_CheckBox.AutoSize = true;
            this.CL_Boot_CheckBox.Location = new System.Drawing.Point(180, 31);
            this.CL_Boot_CheckBox.Name = "CL_Boot_CheckBox";
            this.CL_Boot_CheckBox.Size = new System.Drawing.Size(48, 16);
            this.CL_Boot_CheckBox.TabIndex = 1;
            this.CL_Boot_CheckBox.Text = "Boot";
            this.CL_Boot_CheckBox.UseVisualStyleBackColor = true;
            // 
            // CL_System_CheckBox
            // 
            this.CL_System_CheckBox.AutoSize = true;
            this.CL_System_CheckBox.Checked = true;
            this.CL_System_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CL_System_CheckBox.Location = new System.Drawing.Point(24, 31);
            this.CL_System_CheckBox.Name = "CL_System_CheckBox";
            this.CL_System_CheckBox.Size = new System.Drawing.Size(60, 16);
            this.CL_System_CheckBox.TabIndex = 0;
            this.CL_System_CheckBox.Text = "System";
            this.CL_System_CheckBox.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Device_ToolStripMenuItem,
            this.Debug_ToolStripMenuItem,
            this.Device_Info_ToolStripMenuItem,
            this.About_ToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(684, 25);
            this.MenuStrip.TabIndex = 14;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Download_Flash_File_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.File_ToolStripMenuItem.Text = "文件";
            // 
            // Download_Flash_File_ToolStripMenuItem
            // 
            this.Download_Flash_File_ToolStripMenuItem.Name = "Download_Flash_File_ToolStripMenuItem";
            this.Download_Flash_File_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.Download_Flash_File_ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.Download_Flash_File_ToolStripMenuItem.Text = "下载刷机包";
            this.Download_Flash_File_ToolStripMenuItem.Click += new System.EventHandler(this.Download_Flash_File_ToolStripMenuItem_Click);
            // 
            // Device_ToolStripMenuItem
            // 
            this.Device_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Install_Device_ToolStripMenuItem});
            this.Device_ToolStripMenuItem.Name = "Device_ToolStripMenuItem";
            this.Device_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.Device_ToolStripMenuItem.Text = "驱动";
            // 
            // Install_Device_ToolStripMenuItem
            // 
            this.Install_Device_ToolStripMenuItem.Name = "Install_Device_ToolStripMenuItem";
            this.Install_Device_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Install_Device_ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.Install_Device_ToolStripMenuItem.Text = "安装驱动";
            this.Install_Device_ToolStripMenuItem.Click += new System.EventHandler(this.Install_Device_ToolStripMenuItem_Click);
            // 
            // Debug_ToolStripMenuItem
            // 
            this.Debug_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADB_Debug_ToolStripMenuItem});
            this.Debug_ToolStripMenuItem.Name = "Debug_ToolStripMenuItem";
            this.Debug_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.Debug_ToolStripMenuItem.Text = "调试";
            // 
            // ADB_Debug_ToolStripMenuItem
            // 
            this.ADB_Debug_ToolStripMenuItem.Name = "ADB_Debug_ToolStripMenuItem";
            this.ADB_Debug_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ADB_Debug_ToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ADB_Debug_ToolStripMenuItem.Text = "开始调试";
            this.ADB_Debug_ToolStripMenuItem.Click += new System.EventHandler(this.ADB_Debug_ToolStripMenuItem_Click);
            // 
            // Device_Info_ToolStripMenuItem
            // 
            this.Device_Info_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Read_Device_Info_ToolStripMenuItem,
            this.UnlockBL_ToolStripMenuItem,
            Recovery_ToolStripMenuItem});
            this.Device_Info_ToolStripMenuItem.Name = "Device_Info_ToolStripMenuItem";
            this.Device_Info_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.Device_Info_ToolStripMenuItem.Text = "设备";
            // 
            // Read_Device_Info_ToolStripMenuItem
            // 
            this.Read_Device_Info_ToolStripMenuItem.Name = "Read_Device_Info_ToolStripMenuItem";
            this.Read_Device_Info_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.Read_Device_Info_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.Read_Device_Info_ToolStripMenuItem.Text = "查看设备信息";
            this.Read_Device_Info_ToolStripMenuItem.Click += new System.EventHandler(this.Read_Device_Info_ToolStripMenuItem_Click);
            // 
            // UnlockBL_ToolStripMenuItem
            // 
            this.UnlockBL_ToolStripMenuItem.Name = "UnlockBL_ToolStripMenuItem";
            this.UnlockBL_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.UnlockBL_ToolStripMenuItem.Text = "尝试降级和解锁";
            this.UnlockBL_ToolStripMenuItem.Click += new System.EventHandler(this.UnlockBL_ToolStripMenuItem_Click);
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_Me_ToolStripMenuItem,
            this.Open_Source_License_ToolStripMenuItem});
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.About_ToolStripMenuItem.Text = "关于";
            // 
            // About_Me_ToolStripMenuItem
            // 
            this.About_Me_ToolStripMenuItem.Name = "About_Me_ToolStripMenuItem";
            this.About_Me_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.About_Me_ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.About_Me_ToolStripMenuItem.Text = "关于我";
            this.About_Me_ToolStripMenuItem.Click += new System.EventHandler(this.About_Me_ToolStripMenuItem_Click);
            // 
            // Open_Source_License_ToolStripMenuItem
            // 
            this.Open_Source_License_ToolStripMenuItem.Name = "Open_Source_License_ToolStripMenuItem";
            this.Open_Source_License_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.Open_Source_License_ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.Open_Source_License_ToolStripMenuItem.Text = "开放源代码许可";
            this.Open_Source_License_ToolStripMenuItem.Click += new System.EventHandler(this.Open_Source_License_ToolStripMenuItem_Click);
            // 
            // AVB2_GroupBox
            // 
            this.AVB2_GroupBox.Controls.Add(this.Reboot_to_Fstboot_Button);
            this.AVB2_GroupBox.Controls.Add(this.Disable_AVB2_Flash_Button);
            this.AVB2_GroupBox.Controls.Add(this.Enable_AVB2_Flash_Button);
            this.AVB2_GroupBox.Controls.Add(this.Select_Vbmeta_IMG_Button);
            this.AVB2_GroupBox.Controls.Add(this.IMG_Vbmeta_File_Path_TextBox);
            this.AVB2_GroupBox.Controls.Add(this.Select_the_IMG_Vbmeta_File_Label);
            this.AVB2_GroupBox.Location = new System.Drawing.Point(13, 389);
            this.AVB2_GroupBox.Name = "AVB2_GroupBox";
            this.AVB2_GroupBox.Size = new System.Drawing.Size(659, 85);
            this.AVB2_GroupBox.TabIndex = 15;
            this.AVB2_GroupBox.TabStop = false;
            this.AVB2_GroupBox.Text = "Setup 04. 关闭验证（可选）";
            // 
            // Reboot_to_Fstboot_Button
            // 
            this.Reboot_to_Fstboot_Button.Location = new System.Drawing.Point(348, 50);
            this.Reboot_to_Fstboot_Button.Name = "Reboot_to_Fstboot_Button";
            this.Reboot_to_Fstboot_Button.Size = new System.Drawing.Size(135, 23);
            this.Reboot_to_Fstboot_Button.TabIndex = 14;
            this.Reboot_to_Fstboot_Button.Text = "重启到 FASTBOOT";
            this.Reboot_to_Fstboot_Button.UseVisualStyleBackColor = true;
            this.Reboot_to_Fstboot_Button.Click += new System.EventHandler(this.Reboot_to_Fstboot_Button_Click);
            // 
            // Disable_AVB2_Flash_Button
            // 
            this.Disable_AVB2_Flash_Button.Location = new System.Drawing.Point(570, 50);
            this.Disable_AVB2_Flash_Button.Name = "Disable_AVB2_Flash_Button";
            this.Disable_AVB2_Flash_Button.Size = new System.Drawing.Size(75, 23);
            this.Disable_AVB2_Flash_Button.TabIndex = 13;
            this.Disable_AVB2_Flash_Button.Text = "关闭验证";
            this.Disable_AVB2_Flash_Button.UseVisualStyleBackColor = true;
            this.Disable_AVB2_Flash_Button.Click += new System.EventHandler(this.Disable_AVB2_Flash_Button_Click);
            // 
            // Enable_AVB2_Flash_Button
            // 
            this.Enable_AVB2_Flash_Button.Location = new System.Drawing.Point(489, 50);
            this.Enable_AVB2_Flash_Button.Name = "Enable_AVB2_Flash_Button";
            this.Enable_AVB2_Flash_Button.Size = new System.Drawing.Size(75, 23);
            this.Enable_AVB2_Flash_Button.TabIndex = 12;
            this.Enable_AVB2_Flash_Button.Text = "启用验证";
            this.Enable_AVB2_Flash_Button.UseVisualStyleBackColor = true;
            this.Enable_AVB2_Flash_Button.Click += new System.EventHandler(this.Enable_AVB2_Flash_Button_Click);
            // 
            // Select_Vbmeta_IMG_Button
            // 
            this.Select_Vbmeta_IMG_Button.Location = new System.Drawing.Point(570, 21);
            this.Select_Vbmeta_IMG_Button.Name = "Select_Vbmeta_IMG_Button";
            this.Select_Vbmeta_IMG_Button.Size = new System.Drawing.Size(75, 23);
            this.Select_Vbmeta_IMG_Button.TabIndex = 5;
            this.Select_Vbmeta_IMG_Button.Text = "浏览...";
            this.Select_Vbmeta_IMG_Button.UseVisualStyleBackColor = true;
            this.Select_Vbmeta_IMG_Button.Click += new System.EventHandler(this.Select_Vbmeta_IMG_Button_Click);
            // 
            // IMG_Vbmeta_File_Path_TextBox
            // 
            this.IMG_Vbmeta_File_Path_TextBox.AllowDrop = true;
            this.IMG_Vbmeta_File_Path_TextBox.Location = new System.Drawing.Point(151, 22);
            this.IMG_Vbmeta_File_Path_TextBox.Name = "IMG_Vbmeta_File_Path_TextBox";
            this.IMG_Vbmeta_File_Path_TextBox.Size = new System.Drawing.Size(413, 21);
            this.IMG_Vbmeta_File_Path_TextBox.TabIndex = 4;
            // 
            // Select_the_IMG_Vbmeta_File_Label
            // 
            this.Select_the_IMG_Vbmeta_File_Label.AutoSize = true;
            this.Select_the_IMG_Vbmeta_File_Label.Location = new System.Drawing.Point(22, 26);
            this.Select_the_IMG_Vbmeta_File_Label.Name = "Select_the_IMG_Vbmeta_File_Label";
            this.Select_the_IMG_Vbmeta_File_Label.Size = new System.Drawing.Size(113, 12);
            this.Select_the_IMG_Vbmeta_File_Label.TabIndex = 3;
            this.Select_the_IMG_Vbmeta_File_Label.Text = "选择 Vbmeta 文件：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.Controls.Add(this.AVB2_GroupBox);
            this.Controls.Add(this.Clear_GroupBox);
            this.Controls.Add(this.Connect_the_Device_GroupBox);
            this.Controls.Add(this.Extract_IMG_GroupBox);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Extract_IMG_GroupBox.ResumeLayout(false);
            this.Extract_IMG_GroupBox.PerformLayout();
            this.Connect_the_Device_GroupBox.ResumeLayout(false);
            this.Connect_the_Device_GroupBox.PerformLayout();
            this.Clear_GroupBox.ResumeLayout(false);
            this.Clear_GroupBox.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.AVB2_GroupBox.ResumeLayout(false);
            this.AVB2_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Extract_IMG_GroupBox;
        private System.Windows.Forms.Label Select_the_File_Label;
        private System.Windows.Forms.TextBox Payload_File_Path_TextBox;
        private System.Windows.Forms.Button Select_Payload_Button;
        private System.Windows.Forms.Button Input_IMG_Button;
        private System.Windows.Forms.TextBox Input_IMG_TextBox;
        private System.Windows.Forms.Label Input_IMG_Lable;
        private System.Windows.Forms.RadioButton Input_Init_IMG_RadioButton;
        private System.Windows.Forms.RadioButton Input_Boot_IMG_RadioButton;
        private System.Windows.Forms.RadioButton Input_ALL_IMG_RadioButton;
        private System.Windows.Forms.Button Input_Button;
        private System.Windows.Forms.GroupBox Connect_the_Device_GroupBox;
        private System.Windows.Forms.Label Device_Status_Label;
        private System.Windows.Forms.RadioButton ADB_RadioButton;
        private System.Windows.Forms.RadioButton FASTBOOT_RadioButton;
        private System.Windows.Forms.RadioButton Recovery_RadioButton;
        private System.Windows.Forms.Label Connect_the_Device_Label;
        private System.Windows.Forms.Label Device_Name_Lable;
        private System.Windows.Forms.Button Link_Button;
        private System.Windows.Forms.GroupBox Clear_GroupBox;
        private System.Windows.Forms.CheckBox CL_System_CheckBox;
        private System.Windows.Forms.CheckBox CL_UserData_CheckBox;
        private System.Windows.Forms.CheckBox CL_Boot_CheckBox;
        private System.Windows.Forms.CheckBox CL_Cache_CheckBox;
        private System.Windows.Forms.Button Clear_Data_Button;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Device_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Install_Device_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Download_Flash_File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_Me_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_Source_License_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ADB_Debug_ToolStripMenuItem;
        private System.Windows.Forms.RadioButton Input_Specific_IMG_RadioButton;
        private System.Windows.Forms.ComboBox Input_Specific_IMG_ComboBox;
        private System.Windows.Forms.GroupBox AVB2_GroupBox;
        private System.Windows.Forms.Button Enable_AVB2_Flash_Button;
        private System.Windows.Forms.Button Select_Vbmeta_IMG_Button;
        private System.Windows.Forms.TextBox IMG_Vbmeta_File_Path_TextBox;
        private System.Windows.Forms.Label Select_the_IMG_Vbmeta_File_Label;
        private System.Windows.Forms.Button Disable_AVB2_Flash_Button;
        private System.Windows.Forms.Button Reboot_to_Fstboot_Button;
        private System.Windows.Forms.CheckBox Open_File_Path_CheckBox;
        private System.Windows.Forms.Button Custom_Flash_Button;
        private System.Windows.Forms.ToolStripMenuItem Device_Info_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Read_Device_Info_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnlockBL_ToolStripMenuItem;
    }
}

