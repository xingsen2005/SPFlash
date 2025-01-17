namespace SPFlash
{
    partial class Download_Flash_File_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Download_Flash_File_Form));
            this.Drive_Label = new System.Windows.Forms.Label();
            this.Drive_ComboBox = new System.Windows.Forms.ComboBox();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Select_Region_GroupBox = new System.Windows.Forms.GroupBox();
            this.Indonesia_RadioButton = new System.Windows.Forms.RadioButton();
            this.International_Development_RadioButton = new System.Windows.Forms.RadioButton();
            this.China_Development_RadioButton = new System.Windows.Forms.RadioButton();
            this.Korea_RadioButton = new System.Windows.Forms.RadioButton();
            this.Japan_RadioButton = new System.Windows.Forms.RadioButton();
            this.Turkey_RadioButton = new System.Windows.Forms.RadioButton();
            this.India_RadioButton = new System.Windows.Forms.RadioButton();
            this.Russia_RadioButton = new System.Windows.Forms.RadioButton();
            this.Europe_RadioButton = new System.Windows.Forms.RadioButton();
            this.International_RadioButton = new System.Windows.Forms.RadioButton();
            this.TaiWan_RadioButton = new System.Windows.Forms.RadioButton();
            this.China_RadioButton = new System.Windows.Forms.RadioButton();
            this.Select_Categories_GroupBox = new System.Windows.Forms.GroupBox();
            this.Flash_RadioButton = new System.Windows.Forms.RadioButton();
            this.OTA_RadioButton = new System.Windows.Forms.RadioButton();
            this.ROM_Update_Info_Label = new System.Windows.Forms.Label();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Copy_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rom_List_DataGridView = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROM_Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flash_Pack_Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Android_Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Build_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Download_Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_Label = new System.Windows.Forms.Label();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_ComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Select_Region_GroupBox.SuspendLayout();
            this.Select_Categories_GroupBox.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rom_List_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Drive_Label
            // 
            this.Drive_Label.AutoSize = true;
            this.Drive_Label.Location = new System.Drawing.Point(14, 17);
            this.Drive_Label.Name = "Drive_Label";
            this.Drive_Label.Size = new System.Drawing.Size(65, 12);
            this.Drive_Label.TabIndex = 1;
            this.Drive_Label.Text = "选择机型：";
            // 
            // Drive_ComboBox
            // 
            this.Drive_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drive_ComboBox.FormattingEnabled = true;
            this.Drive_ComboBox.Items.AddRange(new object[] {
            "小米 14 Ultra",
            "红米平板 Pro 5G",
            "红米 13 / POCO M6",
            "红米 12C / POCO C55",
            "红米平板 Pro",
            "小米 11T",
            "小米 12",
            "红米 Note 11E / POCO M4 5G / 红米 10 Prime+ 5G",
            "红米 Note 11S / POCO M4 Pro 4G",
            "红米13R 5G / 红米13C 5G / POCO M6 5G",
            "红米 Note 13 Pro 5G / POCO X6",
            "小米 MIX Fold 4",
            "小米 11T Pro",
            "红米 Note12T Pro",
            "Redm K50 电竞版 / POCO F4 GT",
            "小米 11 Pro / 小米11 Ultra",
            "小米 12T",
            "红米 Note 11 Pro / 红米 Note11 Pro+ / 小米11i",
            "小米平板 6 Pro",
            "小米 12 Lite",
            "Redmi K40S（POCO F4）",
            "小米 12 Pro",
            "POCO M6 Pro 4G",
            "红米 Note13 5G / 红米 Note 13R Pro",
            "小米平板 5",
            "Redmi K60E",
            "红米 A3X",
            "小米 11 青春活力版 / 小米11 Lite 5G NE",
            "小米 CIVI 2 / 小米 13 Lite",
            "红米 Note 11E Pro / 红米 Note 11 Pro 5G",
            "小米 CIVI 4 Pro",
            "红米 12",
            "小米平板 6",
            "POCO M4 Pro 5G",
            "红米 14C / 红米 A3 Pro / POCO C75",
            "红米 K50 至尊版 / 小米 12T Pro",
            "红米平板 SE",
            "红米 Note 13R / 红米 13 5G / POCO M6 Plus 5G",
            "小米平板 6S Pro 12.4",
            "POCO M5 / 红米 11 Prime 4G",
            "红米 Note13 Pro+ 5G",
            "红米 Note13 4G NFC",
            "红米 Note12 Pro",
            "Redmi K50 Pro",
            "小米 12 Pro 天玑版",
            "红米 Note12 Turbo / POCO F5 5G",
            "小米 12X",
            "小米 11",
            "红米 13 / CPOCO C65",
            "小米 CIVI 3",
            "红米 Note12 Pro 4G",
            "红米 Note12R / POCO M6 Pro 5G / 红米12 5G",
            "POCO X5 5G",
            "小米 13 Ultra",
            "Redmi K60 / POCO F5 Pro",
            "红米平板 SE 8.7 4G",
            "红米平板 SE 8.7 WiFi",
            "红米 Note12 Pro 极速版 / POCO X5 Pro 5G",
            "Redmi K40 Pro / Redmi K40 Pro+ / 小米11i / 小米 11X Pro",
            "红米 Note12 5G / 红米 Note 12R Pro",
            "红米 Note12S",
            "红米 Turbo 3 / POCO F6",
            "红米 Note 11S 5G",
            "小米平板 6 Max",
            "小米 MIX Flip",
            "红米平板",
            "小米 14",
            "小米 MIX Fold 2",
            "Redmi K70 / POCO F6 Pro",
            "小米 13 Pro",
            "小米 13",
            "小米 MIX Fold 3",
            "红米 Note13 4G",
            "小米 MIX4",
            "Redmi K50",
            "小米 12S Pro",
            "Redmi K70E / POCO X6 Pro 5G",
            "Redmi K40 / POCO F3 / 小米 11X",
            "小米 12S",
            "Redmi K60 Pro",
            "小米 14 钛金属版",
            "Redmi K60 至尊版 / 小米 13T Pro",
            "Redmi K70 Pro",
            "Redmi K70 至尊版 / 小米 13T Pro",
            "小米CIVI 1S",
            "小米平板 5 Pro 12.4",
            "红米 Note12 4G",
            "小米 12S Ultra",
            "红米 Note12 4G NFC",
            "小米 14 Pro",
            "小米 13T",
            "小米 10S",
            "小米 10 Pro",
            "小米 10 至尊纪念版",
            "小米 10",
            "小米平板 5 Pro（5G）",
            "小米平板 5 Pro（WiFi）",
            "红米 10C",
            "红米 A3 / POCO C61",
            "红米 A1 / POCO C50",
            "红米 Note11 5G",
            "红米 10A",
            "红米 Note 8 (2021年款)",
            "Redmi K40 游戏增强版 / POCO F3 GT",
            "POCO C51 / 红米 A2 / 红米 A2+",
            "红米 Note 10S",
            "POCO M5S",
            "POCO C40",
            "小米 CIVI",
            "小米 11 青春版",
            "红米 Note 10T",
            "红米 10 / 红米10 Prime",
            "红米 Note 10 Pro / POCO X3 GT",
            "红米 Note 11R",
            "红米 Note 10 Pro",
            "红米 Note 10",
            "小米 MIX Fold",
            "红米 Note 9T 5G",
            "小米 11 Lite",
            "红米 Note 9 5G",
            "红米 Note 10 / POCO M3 Pro / 红米 Note 11 SE",
            "红米 Note 10 5G",
            "红米 Note 9 Pro",
            "红米 Note 9S / 红米 Note 9 Pro（印度版）",
            "POCO X3 NFC",
            "POCO C3",
            "红米 Note 9 4G / 红米 9T 红米 9 Power",
            "红米 10X Pro",
            "红米 10X 5G",
            "POCO M2 Pro",
            "Redmi K30S 至尊纪念版 / 小米 10T / 小米 10T Pro",
            "Redmi K30 至尊纪念版",
            "红米 Note 9 Pro / 小米 10T Lite / 小米10i",
            "POCO X3 Pro",
            "POCO M3",
            "红米 Note 9 Pro Max（印度版）",
            "Redmi K30 Pro / Redmi K30 Pro 变焦版 / POCO F2 Pro",
            "红米 9C",
            "红米 9 / 红米 9 Prime",
            "红米 10X 4G / 红米 Note 9",
            "小米 Note 10 Lite",
            "红米 Note 8",
            "小米 10 Lite",
            "小米 10 青春版",
            "Redmi K30 5G",
            "Redmi K30i 5G",
            "红米 9C NFC",
            "Redmi K30 4G / POCO X2",
            "小米 CC9 Pro / 小米 Note 10 / 小米 Note 10 Pro",
            "红米 Note 8 Pro",
            "红米 8A Dual / 红米 8A Pro",
            "红米 9（印度版）",
            "红米 8",
            "红米 8A",
            "小米 CC9 / 小米9 Lite",
            "POCO M2",
            "小米 A3",
            "红米 Note11T Pro / 红米 Note11T Pro+ / POCO X4 GT / POCO X4 GT Pro",
            "红米 Note 8T",
            "小米 9 Pro 5G",
            "红米 Note11 4G",
            "红米 7A",
            "小米 8 Pro 屏幕指纹版",
            "小米 8",
            "红米 Note 7",
            "小米 9",
            "小米 CC9 E",
            "小米 9 SE",
            "Redmi K20 / 小米 9T",
            "红米 Note 7 Pro",
            "小米 CC9 美图定制版",
            "小米 8 透明探索版",
            "红米 7",
            "Redmi K20 Pro / 小米 9T Pro",
            "小米 MIX 2S",
            "小米 A2",
            "小米 MIX 3",
            "小米 A2 Lite",
            "小米 8 SE",
            "红米 6A",
            "红米 6",
            "小米 8 Lite",
            "小米 Max 3",
            "红米 Note 5",
            "小米 MIX 3 5G",
            "红米 Go",
            "红米 Y3",
            "小米 6X",
            "POCO F1",
            "小米 Play",
            "红米 Note 6 Pro",
            "红米 S2 / 红米 Y2",
            "红米 6 Pro",
            "小米 MIX 2",
            "小米 Note 3",
            "小米 A1",
            "小米 6",
            "红米 5",
            "红米 5A",
            "小米 5X",
            "红米 5 Plus",
            "红米 4X",
            "红米 Note 4X 高通版",
            "小米 5S",
            "小米 5S Plus",
            "小米 MIX",
            "小米 Max 2",
            "小米 Note 2",
            "红米 Note 5A 标准版",
            "红米 Note 5A 高配版",
            "Redmi K20 Pro 尊享版",
            "小米平板 3",
            "小米平板 4 / 小米平板 4 Plus",
            "小米 5C",
            "红米 4A",
            "小米 Max 标准版",
            "小米 Max 高配版",
            "红米 4",
            "红米 4 高配版",
            "红米 3S",
            "红米 Note 4 联发科版",
            "红米 Note 3 台湾特别版",
            "红米 Note 3 全网通版",
            "小米 5",
            "小米 3 / 小米 4",
            "红米手机 2 联通电信增强版",
            "红米 Note 2",
            "小米平板",
            "小米 4i",
            "红米手机 1S",
            "小米 2S",
            "小米平板 2",
            "红米 Note 4G 单卡版",
            "小米 Note 双网通版",
            "红米 Note 3 双网通版",
            "小米 4C",
            "红米 3 / 红米 3 Pro",
            "红米 Note 3G 联通版",
            "红米手机 2 移动增强版",
            "红米手机 2 移动标配版",
            "红米手机",
            "红米 Pro",
            "红米 Note 4G 双卡版"});
            this.Drive_ComboBox.Location = new System.Drawing.Point(85, 14);
            this.Drive_ComboBox.Name = "Drive_ComboBox";
            this.Drive_ComboBox.Size = new System.Drawing.Size(821, 20);
            this.Drive_ComboBox.TabIndex = 2;
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(1072, 46);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(180, 60);
            this.Confirm_Button.TabIndex = 5;
            this.Confirm_Button.Text = "开始搜索";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Select_Region_GroupBox
            // 
            this.Select_Region_GroupBox.Controls.Add(this.Indonesia_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.International_Development_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.China_Development_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.Korea_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.Japan_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.Turkey_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.India_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.Russia_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.Europe_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.International_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.TaiWan_RadioButton);
            this.Select_Region_GroupBox.Controls.Add(this.China_RadioButton);
            this.Select_Region_GroupBox.Location = new System.Drawing.Point(16, 41);
            this.Select_Region_GroupBox.Name = "Select_Region_GroupBox";
            this.Select_Region_GroupBox.Size = new System.Drawing.Size(890, 65);
            this.Select_Region_GroupBox.TabIndex = 13;
            this.Select_Region_GroupBox.TabStop = false;
            this.Select_Region_GroupBox.Text = "选择地区";
            // 
            // Indonesia_RadioButton
            // 
            this.Indonesia_RadioButton.AutoSize = true;
            this.Indonesia_RadioButton.Location = new System.Drawing.Point(821, 28);
            this.Indonesia_RadioButton.Name = "Indonesia_RadioButton";
            this.Indonesia_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.Indonesia_RadioButton.TabIndex = 11;
            this.Indonesia_RadioButton.Text = "印尼版";
            this.Indonesia_RadioButton.UseVisualStyleBackColor = true;
            // 
            // International_Development_RadioButton
            // 
            this.International_Development_RadioButton.AutoSize = true;
            this.International_Development_RadioButton.Location = new System.Drawing.Point(260, 28);
            this.International_Development_RadioButton.Name = "International_Development_RadioButton";
            this.International_Development_RadioButton.Size = new System.Drawing.Size(83, 16);
            this.International_Development_RadioButton.TabIndex = 10;
            this.International_Development_RadioButton.Text = "国际开发版";
            this.International_Development_RadioButton.UseVisualStyleBackColor = true;
            // 
            // China_Development_RadioButton
            // 
            this.China_Development_RadioButton.AutoSize = true;
            this.China_Development_RadioButton.Location = new System.Drawing.Point(108, 28);
            this.China_Development_RadioButton.Name = "China_Development_RadioButton";
            this.China_Development_RadioButton.Size = new System.Drawing.Size(83, 16);
            this.China_Development_RadioButton.TabIndex = 9;
            this.China_Development_RadioButton.Text = "国行开发版";
            this.China_Development_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Korea_RadioButton
            // 
            this.Korea_RadioButton.AutoSize = true;
            this.Korea_RadioButton.Location = new System.Drawing.Point(680, 28);
            this.Korea_RadioButton.Name = "Korea_RadioButton";
            this.Korea_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.Korea_RadioButton.TabIndex = 8;
            this.Korea_RadioButton.Text = "韩国版";
            this.Korea_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Japan_RadioButton
            // 
            this.Japan_RadioButton.AutoSize = true;
            this.Japan_RadioButton.Location = new System.Drawing.Point(476, 28);
            this.Japan_RadioButton.Name = "Japan_RadioButton";
            this.Japan_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.Japan_RadioButton.TabIndex = 7;
            this.Japan_RadioButton.Text = "日本版";
            this.Japan_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Turkey_RadioButton
            // 
            this.Turkey_RadioButton.AutoSize = true;
            this.Turkey_RadioButton.Location = new System.Drawing.Point(744, 28);
            this.Turkey_RadioButton.Name = "Turkey_RadioButton";
            this.Turkey_RadioButton.Size = new System.Drawing.Size(71, 16);
            this.Turkey_RadioButton.TabIndex = 6;
            this.Turkey_RadioButton.Text = "土耳其版";
            this.Turkey_RadioButton.UseVisualStyleBackColor = true;
            // 
            // India_RadioButton
            // 
            this.India_RadioButton.AutoSize = true;
            this.India_RadioButton.Location = new System.Drawing.Point(616, 28);
            this.India_RadioButton.Name = "India_RadioButton";
            this.India_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.India_RadioButton.TabIndex = 5;
            this.India_RadioButton.Text = "印度版";
            this.India_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Russia_RadioButton
            // 
            this.Russia_RadioButton.AutoSize = true;
            this.Russia_RadioButton.Location = new System.Drawing.Point(540, 28);
            this.Russia_RadioButton.Name = "Russia_RadioButton";
            this.Russia_RadioButton.Size = new System.Drawing.Size(71, 16);
            this.Russia_RadioButton.TabIndex = 4;
            this.Russia_RadioButton.Text = "俄罗斯版";
            this.Russia_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Europe_RadioButton
            // 
            this.Europe_RadioButton.AutoSize = true;
            this.Europe_RadioButton.Location = new System.Drawing.Point(348, 28);
            this.Europe_RadioButton.Name = "Europe_RadioButton";
            this.Europe_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.Europe_RadioButton.TabIndex = 3;
            this.Europe_RadioButton.Text = "欧洲版";
            this.Europe_RadioButton.UseVisualStyleBackColor = true;
            // 
            // International_RadioButton
            // 
            this.International_RadioButton.AutoSize = true;
            this.International_RadioButton.Location = new System.Drawing.Point(196, 28);
            this.International_RadioButton.Name = "International_RadioButton";
            this.International_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.International_RadioButton.TabIndex = 2;
            this.International_RadioButton.Text = "国际版";
            this.International_RadioButton.UseVisualStyleBackColor = true;
            // 
            // TaiWan_RadioButton
            // 
            this.TaiWan_RadioButton.AutoSize = true;
            this.TaiWan_RadioButton.Location = new System.Drawing.Point(412, 28);
            this.TaiWan_RadioButton.Name = "TaiWan_RadioButton";
            this.TaiWan_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.TaiWan_RadioButton.TabIndex = 1;
            this.TaiWan_RadioButton.Text = "台湾版";
            this.TaiWan_RadioButton.UseVisualStyleBackColor = true;
            // 
            // China_RadioButton
            // 
            this.China_RadioButton.AutoSize = true;
            this.China_RadioButton.Checked = true;
            this.China_RadioButton.Location = new System.Drawing.Point(20, 28);
            this.China_RadioButton.Name = "China_RadioButton";
            this.China_RadioButton.Size = new System.Drawing.Size(83, 16);
            this.China_RadioButton.TabIndex = 0;
            this.China_RadioButton.TabStop = true;
            this.China_RadioButton.Text = "国行稳定版";
            this.China_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Select_Categories_GroupBox
            // 
            this.Select_Categories_GroupBox.Controls.Add(this.Flash_RadioButton);
            this.Select_Categories_GroupBox.Controls.Add(this.OTA_RadioButton);
            this.Select_Categories_GroupBox.Location = new System.Drawing.Point(912, 42);
            this.Select_Categories_GroupBox.Name = "Select_Categories_GroupBox";
            this.Select_Categories_GroupBox.Size = new System.Drawing.Size(154, 64);
            this.Select_Categories_GroupBox.TabIndex = 14;
            this.Select_Categories_GroupBox.TabStop = false;
            this.Select_Categories_GroupBox.Text = "选择刷机包类型";
            // 
            // Flash_RadioButton
            // 
            this.Flash_RadioButton.AutoSize = true;
            this.Flash_RadioButton.Location = new System.Drawing.Point(84, 27);
            this.Flash_RadioButton.Name = "Flash_RadioButton";
            this.Flash_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.Flash_RadioButton.TabIndex = 8;
            this.Flash_RadioButton.Text = "线刷包";
            this.Flash_RadioButton.UseVisualStyleBackColor = true;
            // 
            // OTA_RadioButton
            // 
            this.OTA_RadioButton.AutoSize = true;
            this.OTA_RadioButton.Checked = true;
            this.OTA_RadioButton.Location = new System.Drawing.Point(19, 27);
            this.OTA_RadioButton.Name = "OTA_RadioButton";
            this.OTA_RadioButton.Size = new System.Drawing.Size(59, 16);
            this.OTA_RadioButton.TabIndex = 1;
            this.OTA_RadioButton.TabStop = true;
            this.OTA_RadioButton.Text = "卡刷包";
            this.OTA_RadioButton.UseVisualStyleBackColor = true;
            // 
            // ROM_Update_Info_Label
            // 
            this.ROM_Update_Info_Label.AutoSize = true;
            this.ROM_Update_Info_Label.ForeColor = System.Drawing.Color.Blue;
            this.ROM_Update_Info_Label.Location = new System.Drawing.Point(14, 657);
            this.ROM_Update_Info_Label.Name = "ROM_Update_Info_Label";
            this.ROM_Update_Info_Label.Size = new System.Drawing.Size(323, 12);
            this.ROM_Update_Info_Label.TabIndex = 19;
            this.ROM_Update_Info_Label.Text = "共 234 个机型 2365 个刷机包，最后更新时间：2024-10-14";
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy_ToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // Copy_ToolStripMenuItem
            // 
            this.Copy_ToolStripMenuItem.Name = "Copy_ToolStripMenuItem";
            this.Copy_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.Copy_ToolStripMenuItem.Text = "复制";
            this.Copy_ToolStripMenuItem.Click += new System.EventHandler(this.Copy_ToolStripMenuItem_Click);
            // 
            // Rom_List_DataGridView
            // 
            this.Rom_List_DataGridView.AllowUserToAddRows = false;
            this.Rom_List_DataGridView.AllowUserToDeleteRows = false;
            this.Rom_List_DataGridView.AllowUserToResizeColumns = false;
            this.Rom_List_DataGridView.AllowUserToResizeRows = false;
            this.Rom_List_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Rom_List_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rom_List_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.ROM_Version,
            this.Region,
            this.Flash_Pack_Version,
            this.Android_Version,
            this.Build_Time,
            this.Download_Link});
            this.Rom_List_DataGridView.Location = new System.Drawing.Point(16, 113);
            this.Rom_List_DataGridView.MultiSelect = false;
            this.Rom_List_DataGridView.Name = "Rom_List_DataGridView";
            this.Rom_List_DataGridView.ReadOnly = true;
            this.Rom_List_DataGridView.RowHeadersVisible = false;
            this.Rom_List_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Rom_List_DataGridView.RowTemplate.Height = 23;
            this.Rom_List_DataGridView.Size = new System.Drawing.Size(1236, 531);
            this.Rom_List_DataGridView.TabIndex = 24;
            // 
            // Model
            // 
            this.Model.HeaderText = "手机型号";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // ROM_Version
            // 
            this.ROM_Version.HeaderText = "ROM 版本号";
            this.ROM_Version.Name = "ROM_Version";
            this.ROM_Version.ReadOnly = true;
            this.ROM_Version.Width = 150;
            // 
            // Region
            // 
            this.Region.HeaderText = "地区版本";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // Flash_Pack_Version
            // 
            this.Flash_Pack_Version.HeaderText = "刷机包类型";
            this.Flash_Pack_Version.Name = "Flash_Pack_Version";
            this.Flash_Pack_Version.ReadOnly = true;
            // 
            // Android_Version
            // 
            this.Android_Version.HeaderText = "Android 版本";
            this.Android_Version.Name = "Android_Version";
            this.Android_Version.ReadOnly = true;
            // 
            // Build_Time
            // 
            this.Build_Time.HeaderText = "发布时间";
            this.Build_Time.Name = "Build_Time";
            this.Build_Time.ReadOnly = true;
            this.Build_Time.Width = 163;
            // 
            // Download_Link
            // 
            this.Download_Link.HeaderText = "下载链接";
            this.Download_Link.Name = "Download_Link";
            this.Download_Link.ReadOnly = true;
            this.Download_Link.Width = 520;
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Location = new System.Drawing.Point(912, 17);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(65, 12);
            this.Search_Label.TabIndex = 3;
            this.Search_Label.Text = "筛选机型：";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(981, 14);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(271, 21);
            this.Search_TextBox.TabIndex = 4;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(991, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "更新源：";
            // 
            // Update_ComboBox
            // 
            this.Update_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Update_ComboBox.FormattingEnabled = true;
            this.Update_ComboBox.Items.AddRange(new object[] {
            "阿里云"});
            this.Update_ComboBox.Location = new System.Drawing.Point(1050, 651);
            this.Update_ComboBox.Name = "Update_ComboBox";
            this.Update_ComboBox.Size = new System.Drawing.Size(121, 20);
            this.Update_ComboBox.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1177, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Download_Flash_File_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rom_List_DataGridView);
            this.Controls.Add(this.Select_Categories_GroupBox);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.ROM_Update_Info_Label);
            this.Controls.Add(this.Select_Region_GroupBox);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.Drive_ComboBox);
            this.Controls.Add(this.Drive_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Download_Flash_File_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下载刷机包";
            this.Load += new System.EventHandler(this.Download_Flash_File_Form_Load);
            this.Select_Region_GroupBox.ResumeLayout(false);
            this.Select_Region_GroupBox.PerformLayout();
            this.Select_Categories_GroupBox.ResumeLayout(false);
            this.Select_Categories_GroupBox.PerformLayout();
            this.ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rom_List_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Drive_Label;
        private System.Windows.Forms.ComboBox Drive_ComboBox;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.GroupBox Select_Region_GroupBox;
        private System.Windows.Forms.RadioButton China_RadioButton;
        private System.Windows.Forms.RadioButton TaiWan_RadioButton;
        private System.Windows.Forms.RadioButton Europe_RadioButton;
        private System.Windows.Forms.RadioButton Russia_RadioButton;
        private System.Windows.Forms.RadioButton Japan_RadioButton;
        private System.Windows.Forms.RadioButton India_RadioButton;
        private System.Windows.Forms.RadioButton Korea_RadioButton;
        private System.Windows.Forms.GroupBox Select_Categories_GroupBox;
        private System.Windows.Forms.RadioButton OTA_RadioButton;
        private System.Windows.Forms.RadioButton Flash_RadioButton;
        private System.Windows.Forms.Label ROM_Update_Info_Label;
        private System.Windows.Forms.RadioButton International_RadioButton;
        private System.Windows.Forms.RadioButton China_Development_RadioButton;
        private System.Windows.Forms.RadioButton International_Development_RadioButton;
        private System.Windows.Forms.RadioButton Indonesia_RadioButton;
        private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Copy_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView Rom_List_DataGridView;
        private System.Windows.Forms.RadioButton Turkey_RadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROM_Version;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flash_Pack_Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Android_Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Build_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Download_Link;
        private System.Windows.Forms.Label Search_Label;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Update_ComboBox;
        private System.Windows.Forms.Button button1;
    }
}