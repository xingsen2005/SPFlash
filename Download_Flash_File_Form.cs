using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace SPFlash
{
    public partial class Download_Flash_File_Form : Form
    {      
        public Download_Flash_File_Form()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            this.Rom_List_DataGridView.ContextMenuStrip = this.ContextMenuStrip;
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                Search_TextBox.Focus();
            }
        }
        private void Download_Flash_File_Form_Load(object sender, EventArgs e)
        {           
            this.Text = Application.ProductName + "：刷机包下载";            
            Drive_ComboBox.SelectedIndex = 0;
            Update_ComboBox.SelectedIndex = 0;
            this.AcceptButton = Confirm_Button;
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "OS1.0.9.0.UMYCNXM", "国行稳定版", "卡刷包", "14", "2024-09-06", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/OS1.0.9.0.UMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "OS1.0.7.0.UMYCNXM", "国行稳定版", "卡刷包", "14", "2024-07-13", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/OS1.0.7.0.UMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "OS1.0.5.0.UMYCNXM", "国行稳定版", "卡刷包", "14", "2024-05-12", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/OS1.0.5.0.UMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "OS1.0.4.0.UMYCNXM", "国行稳定版", "卡刷包", "14", "2024-01-07", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/OS1.0.4.0.UMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "OS1.0.2.0.UMYCNXM", "国行稳定版", "卡刷包", "14", "2023-12-12", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/OS1.0.2.0.UMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "V14.0.9.0.TMYCNXM", "国行稳定版", "卡刷包", "13", "2023-11-25", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/V14.0.9.0.TMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "V14.0.6.0.TMYCNXM", "国行稳定版", "卡刷包", "13", "2023-11-12", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/V14.0.6.0.TMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "V14.0.5.0.TMYCNXM", "国行稳定版", "卡刷包", "13", "2023-10-07", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/V14.0.5.0.TMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "V14.0.3.0.TMYCNXM", "国行稳定版", "卡刷包", "13", "2023-09-12", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/V14.0.3.0.TMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");
            Rom_List_DataGridView.Rows.Add("小米 14 Ultra", "V14.0.2.0.TMYCNXM", "国行稳定版", "卡刷包", "13", "2023-08-15", "https://bkt-sgp-miui-ota-update-alisgp.oss-ap-southeast-1.aliyuncs.com/V14.0.2.0.TMYCNXM/miui_LIUQIN_OS1.0.9.0.UMYCNXM_cb72e06b59_14.0.zip");            
            ROM_Update_Info_Label.Text = "共 " + Drive_ComboBox.Items.Count + " 个机型 " + Rom_List_DataGridView.Rows.Count + " 个刷机包。最后更新时间：" + DateTime.Now.ToString("yyyy-MM-dd");

        }
        
        private List<string> originalItems;
        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = Search_TextBox.Text.ToLower();
            if (originalItems == null || !originalItems.Any())
            {
                originalItems = Drive_ComboBox.Items.Cast<string>().ToList();
            }
            var filteredItems = originalItems
                .Where(item => item.ToLower().Contains(searchText))
                .ToList();
            Drive_ComboBox.BeginUpdate();
            Drive_ComboBox.Items.Clear();
            foreach (var item in filteredItems)
            {
                Drive_ComboBox.Items.Add(item);
                Drive_ComboBox.SelectedIndex = 0;
            }
            Drive_ComboBox.EndUpdate();

            if (string.IsNullOrEmpty(searchText))
            {
                Drive_ComboBox.BeginUpdate();
                Drive_ComboBox.Items.Clear();
                foreach (var item in originalItems)
                {
                    Drive_ComboBox.Items.Add(item);
                    Drive_ComboBox.SelectedIndex = 0;
                }
                Drive_ComboBox.EndUpdate();
            }

            if (Drive_ComboBox.SelectedIndex == -1)
            {
                Confirm_Button.Enabled = false;
                Confirm_Button.Text = "未找到符合的结果";
            }
            else
            { 
                Confirm_Button.Enabled = true;
                Confirm_Button.Text = "开始搜索";
            }
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            //BindingSource bsRomList = this.bsRomList;
            //string modelFilter = string.Format("Model = '{0}'", Drive_ComboBox.Text);
            //string regionFilter = "Region = 'NotSelected'";
            //if (China_RadioButton.Checked) regionFilter = "Region = '" + China_RadioButton.Text + "'";
            //else if (China_Development_RadioButton.Checked) regionFilter = "Region = '" + China_Development_RadioButton.Text + "'";
            //else if (Indonesia_RadioButton.Checked) regionFilter = "Region = '" + Indonesia_RadioButton.Text + "'";
            //string flashPackVersionFilter = "Flash_Pack_Version = 'NotSelected'";
            //if (OTA_RadioButton.Checked) flashPackVersionFilter = "Flash_Pack_Version = '" + OTA_RadioButton.Text + "'";
            //else if (Flash_RadioButton.Checked) flashPackVersionFilter = "Flash_Pack_Version = '" + Flash_RadioButton.Text + "'";
            //string filter = string.Format("({0}) AND ({1}) AND ({2})", modelFilter, regionFilter, flashPackVersionFilter);
            //bsRomList.Filter = filter;
        }
        private void Refresh_the_List_Button_Click(object sender, EventArgs e)
        {           
            Confirm_Button_Click(sender, e);
        }
        private void Copy_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cellValue = Rom_List_DataGridView.CurrentCell.Value?.ToString();
            if (!string.IsNullOrEmpty(cellValue))
            {
                Clipboard.SetText(cellValue);
            }
        }
    }
}


//if (Drive_ComboBox.Text == "小米 14 Ultra") Device_Code_Info.Text = "aurora";
//if (Drive_ComboBox.Text == "红米平板 Pro 5G") Device_Code_Info.Text = "ruan";
//if (Drive_ComboBox.Text == "红米 13 / POCO M6") Device_Code_Info.Text = "moon";
//if (Drive_ComboBox.Text == "红米 12C / POCO C55") Device_Code_Info.Text = "earth";
//if (Drive_ComboBox.Text == "红米平板 Pro") Device_Code_Info.Text = "dizi";
//if (Drive_ComboBox.Text == "小米 11T") Device_Code_Info.Text = "agate";
//if (Drive_ComboBox.Text == "小米 12") Device_Code_Info.Text = "cupid";
//if (Drive_ComboBox.Text == "红米 Note 11E / POCO M4 5G / 红米 10 Prime+ 5G") Device_Code_Info.Text = "light";
//if (Drive_ComboBox.Text == "红米 Note 11S / POCO M4 Pro 4G") Device_Code_Info.Text = "fleur";
//if (Drive_ComboBox.Text == "红米13R 5G / 红米13C 5G / POCO M6 5G") Device_Code_Info.Text = "air";
//if (Drive_ComboBox.Text == "红米 Note 13 Pro 5G / POCO X6") Device_Code_Info.Text = "garnet";
//if (Drive_ComboBox.Text == "小米 MIX Fold 4") Device_Code_Info.Text = "goku";
//if (Drive_ComboBox.Text == "小米11T Pro") Device_Code_Info.Text = "vili";
//if (Drive_ComboBox.Text == "红米 Note12T Pro") Device_Code_Info.Text = "pearl";
//if (Drive_ComboBox.Text == "Redm K50 电竞版 / POCO F4 GT") Device_Code_Info.Text = "ingres";
//if (Drive_ComboBox.Text == "小米 11 Pro / 小米11 Ultra") Device_Code_Info.Text = "star";
//if (Drive_ComboBox.Text == "小米 12T") Device_Code_Info.Text = "plato";
//if (Drive_ComboBox.Text == "红米 Note 11 Pro / 红米 Note11 Pro+ / 小米11i") Device_Code_Info.Text = "pissarro";
//if (Drive_ComboBox.Text == "小米平板 6 Pro") Device_Code_Info.Text = "liuqin";
//if (Drive_ComboBox.Text == "小米 12 Lite") Device_Code_Info.Text = "taoyao";
//if (Drive_ComboBox.Text == "Redmi K40S（POCO F4）") Device_Code_Info.Text = "munch";
//if (Drive_ComboBox.Text == "小米 12 Pro") Device_Code_Info.Text = "zeus";
//if (Drive_ComboBox.Text == "POCO M6 Pro 4G") Device_Code_Info.Text = "emerald";
//if (Drive_ComboBox.Text == "小米平板 5") Device_Code_Info.Text = "nabu";
//if (Drive_ComboBox.Text == "Redmi K60E") Device_Code_Info.Text = "rembrandt";
//if (Drive_ComboBox.Text == "红米 A3X") Device_Code_Info.Text = "klein";
//if (Drive_ComboBox.Text == "小米 11 青春活力版 / 小米11 Lite 5G NE") Device_Code_Info.Text = "lisa";
//if (Drive_ComboBox.Text == "小米 CIVI 2 / 小米 13 Lite") Device_Code_Info.Text = "ziyi";
//if (Drive_ComboBox.Text == "红米 Note 11E Pro / 红米 Note 11 Pro 5G") Device_Code_Info.Text = "veux";
//if (Drive_ComboBox.Text == "小米 CIVI 4 Pro") Device_Code_Info.Text = "chenfeng";
//if (Drive_ComboBox.Text == "红米 12") Device_Code_Info.Text = "fire";
//if (Drive_ComboBox.Text == "小米平板 6") Device_Code_Info.Text = "pipa";
//if (Drive_ComboBox.Text == "POCO M4 Pro 5G") Device_Code_Info.Text = "evergreen";
//if (Drive_ComboBox.Text == "红米 14C / 红米 A3 Pro / POCO C75") Device_Code_Info.Text = "lake";
//if (Drive_ComboBox.Text == "红米 K50 至尊版 / 小米 12T Pro") Device_Code_Info.Text = "diting";
//if (Drive_ComboBox.Text == "红米平板 SE") Device_Code_Info.Text = "xun";
//if (Drive_ComboBox.Text == "红米 Note 13R / 红米 13 5G / POCO M6 Plus 5G") Device_Code_Info.Text = "breeze";
//if (Drive_ComboBox.Text == "小米平板 6S Pro 12.4") Device_Code_Info.Text = "sheng";
//if (Drive_ComboBox.Text == "POCO M5 / 红米 11 Prime 4G") Device_Code_Info.Text = "rock";
//if (Drive_ComboBox.Text == "红米 Note13 Pro+ 5G") Device_Code_Info.Text = "zircon";
//if (Drive_ComboBox.Text == "红米 Note13 4G NFC") Device_Code_Info.Text = "sapphiren";
//if (Drive_ComboBox.Text == "红米 Note12 Pro") Device_Code_Info.Text = "ruby";
//if (Drive_ComboBox.Text == "Redmi K50 Pro") Device_Code_Info.Text = "matisse";
//if (Drive_ComboBox.Text == "小米12 Pro 天玑版") Device_Code_Info.Text = "daumier";
//if (Drive_ComboBox.Text == "红米 Note12 Turbo / POCO F5 5G") Device_Code_Info.Text = "marble";
//if (Drive_ComboBox.Text == "小米 12X") Device_Code_Info.Text = "psyche";
//if (Drive_ComboBox.Text == "小米 11") Device_Code_Info.Text = "venus";
//if (Drive_ComboBox.Text == "红米 13 / CPOCO C65") Device_Code_Info.Text = "gale";
//if (Drive_ComboBox.Text == "小米 CIVI 3") Device_Code_Info.Text = "yuechu";
//if (Drive_ComboBox.Text == "红米 Note12 Pro 4G") Device_Code_Info.Text = "sweet_k6a";
//if (Drive_ComboBox.Text == "红米 Note12R / POCO M6 Pro 5G / 红米12 5G") Device_Code_Info.Text = "sky";
//if (Drive_ComboBox.Text == "POCO X5 5G") Device_Code_Info.Text = "moonstone";
//if (Drive_ComboBox.Text == "小米 13 Ultra") Device_Code_Info.Text = "ishtar";
//if (Drive_ComboBox.Text == "Redmi K60 / POCO F5 Pro") Device_Code_Info.Text = "mondrian";
//if (Drive_ComboBox.Text == "红米平板 SE 8.7 4G") Device_Code_Info.Text = "spark";
//if (Drive_ComboBox.Text == "红米平板 SE 8.7 WiFi") Device_Code_Info.Text = "flare";
//if (Drive_ComboBox.Text == "红米 Note12 Pro 极速版 / POCO X5 Pro 5G") Device_Code_Info.Text = "redwood";
//if (Drive_ComboBox.Text == "Redmi K40 Pro / Redmi K40 Pro+ / 小米11i / 小米 11X Pro") Device_Code_Info.Text = "haydn";
//if (Drive_ComboBox.Text == "红米 Note12 5G / 红米 Note 12R Pro") Device_Code_Info.Text = "sunstone";
//if (Drive_ComboBox.Text == "红米 Note12S") Device_Code_Info.Text = "sea";
//if (Drive_ComboBox.Text == "红米 Turbo 3 / POCO F6") Device_Code_Info.Text = "peridot";
//if (Drive_ComboBox.Text == "红米 Note 11S 5G") Device_Code_Info.Text = "opal";
//if (Drive_ComboBox.Text == "小米平板 6 Max") Device_Code_Info.Text = "yudi";
//if (Drive_ComboBox.Text == "小米 MIX Flip") Device_Code_Info.Text = "ruyi";
//if (Drive_ComboBox.Text == "红米平板") Device_Code_Info.Text = "yunluo";
//if (Drive_ComboBox.Text == "小米 14") Device_Code_Info.Text = "houji";
//if (Drive_ComboBox.Text == "小米 MIX Fold 2") Device_Code_Info.Text = "zizhan";
//if (Drive_ComboBox.Text == "Redmi K70 / POCO F6 Pro") Device_Code_Info.Text = "vermeer";
//if (Drive_ComboBox.Text == "小米 13 Pro") Device_Code_Info.Text = "nuwa";
//if (Drive_ComboBox.Text == "小米 13") Device_Code_Info.Text = "fuxi";
//if (Drive_ComboBox.Text == "小米 MIX Fold 3") Device_Code_Info.Text = "babylon";
//if (Drive_ComboBox.Text == "红米 Note13 4G") Device_Code_Info.Text = "sapphire";
//if (Drive_ComboBox.Text == "小米 MIX4") Device_Code_Info.Text = "odin";
//if (Drive_ComboBox.Text == "Redmi K50") Device_Code_Info.Text = "rubens";
//if (Drive_ComboBox.Text == "小米 12S Pro") Device_Code_Info.Text = "unicorn";
//if (Drive_ComboBox.Text == "Redmi K70E / POCO X6 Pro 5G") Device_Code_Info.Text = "duchamp";
//if (Drive_ComboBox.Text == "Redmi K40 / POCO F3 / 小米 11X") Device_Code_Info.Text = "alioth";
//if (Drive_ComboBox.Text == "小米 12S") Device_Code_Info.Text = "mayfly";
//if (Drive_ComboBox.Text == "Redmi K60 Pro") Device_Code_Info.Text = "socrates";
//if (Drive_ComboBox.Text == "小米 14 钛金属版") Device_Code_Info.Text = "shennongt";
//if (Drive_ComboBox.Text == "Redmi K60 至尊版 / 小米 13T Pro") Device_Code_Info.Text = "corot";
//if (Drive_ComboBox.Text == "Redmi K70 Pro") Device_Code_Info.Text = "manet";
//if (Drive_ComboBox.Text == "Redmi K70 至尊版 / 小米 13T Pro") Device_Code_Info.Text = "rothko";
//if (Drive_ComboBox.Text == "小米CIVI 1S") Device_Code_Info.Text = "zijin";
//if (Drive_ComboBox.Text == "小米平板 5 Pro 12.4") Device_Code_Info.Text = "dagu";
//if (Drive_ComboBox.Text == "红米 Note12 4G") Device_Code_Info.Text = "tapas";
//if (Drive_ComboBox.Text == "小米 12S Ultra") Device_Code_Info.Text = "thor";
//if (Drive_ComboBox.Text == "红米 Note12 4G NFC") Device_Code_Info.Text = "topaz";
//if (Drive_ComboBox.Text == "小米 14 Pro") Device_Code_Info.Text = "shennong";
//if (Drive_ComboBox.Text == "小米 13T") Device_Code_Info.Text = "aristotle";
//if (Drive_ComboBox.Text == "小米 10S") Device_Code_Info.Text = "thyme";
//if (Drive_ComboBox.Text == "小米 10 Pro") Device_Code_Info.Text = "cmi";
//if (Drive_ComboBox.Text == "小米 10 至尊纪念版") Device_Code_Info.Text = "cas";
//if (Drive_ComboBox.Text == "小米 10") Device_Code_Info.Text = "umi";
//if (Drive_ComboBox.Text == "小米平板 5 Pro（5G）") Device_Code_Info.Text = "enuma";
//if (Drive_ComboBox.Text == "小米平板 5 Pro（WiFi）") Device_Code_Info.Text = "elish";
//if (Drive_ComboBox.Text == "红米 10C") Device_Code_Info.Text = "fog";
//if (Drive_ComboBox.Text == "红米 A3 / POCO C61") Device_Code_Info.Text = "blue";
//if (Drive_ComboBox.Text == "红米 A1 / POCO C50") Device_Code_Info.Text = "ice";
//if (Drive_ComboBox.Text == "红米 Note11 5G") Device_Code_Info.Text = "evergo";
//if (Drive_ComboBox.Text == "红米 10A") Device_Code_Info.Text = "dandelion";
//if (Drive_ComboBox.Text == "红米 Note 8 (2021年款)") Device_Code_Info.Text = "biloba";
//if (Drive_ComboBox.Text == "Redmi K40 游戏增强版 / POCO F3 GT") Device_Code_Info.Text = "ares";
//if (Drive_ComboBox.Text == "POCO C51 / 红米 A2 / 红米 A2+") Device_Code_Info.Text = "water";
//if (Drive_ComboBox.Text == "红米 Note 10S") Device_Code_Info.Text = "rosemary";
//if (Drive_ComboBox.Text == "POCO M5S") Device_Code_Info.Text = "rosemary_p";
//if (Drive_ComboBox.Text == "POCO C40") Device_Code_Info.Text = "frost";
//if (Drive_ComboBox.Text == "小米 CIVI") Device_Code_Info.Text = "mona";
//if (Drive_ComboBox.Text == "小米 11 青春版") Device_Code_Info.Text = "renoir";
//if (Drive_ComboBox.Text == "红米 Note 10T") Device_Code_Info.Text = "lilac";
//if (Drive_ComboBox.Text == "红米 10 / 红米10 Prime") Device_Code_Info.Text = "selene";
//if (Drive_ComboBox.Text == "红米 Note 10 Pro / POCO X3 GT") Device_Code_Info.Text = "chopin";
//if (Drive_ComboBox.Text == "红米 Note 11R") Device_Code_Info.Text = "lightcm";
//if (Drive_ComboBox.Text == "红米 Note 10 Pro") Device_Code_Info.Text = "sweet";
//if (Drive_ComboBox.Text == "红米 Note 10") Device_Code_Info.Text = "mojito";
//if (Drive_ComboBox.Text == "小米 MIX Fold") Device_Code_Info.Text = "cetus";
//if (Drive_ComboBox.Text == "红米 Note 9T 5G") Device_Code_Info.Text = "cannong";
//if (Drive_ComboBox.Text == "小米 11 Lite") Device_Code_Info.Text = "courbet";
//if (Drive_ComboBox.Text == "红米 Note 9 5G") Device_Code_Info.Text = "cannon";
//if (Drive_ComboBox.Text == "红米 Note 10 / POCO M3 Pro / 红米 Note 11 SE") Device_Code_Info.Text = "camellia";
//if (Drive_ComboBox.Text == "红米 Note 10 5G") Device_Code_Info.Text = "camellian";
//if (Drive_ComboBox.Text == "红米 Note 9 Pro") Device_Code_Info.Text = "joyeuse";
//if (Drive_ComboBox.Text == "红米 Note 9S / 红米 Note 9 Pro（印度版）") Device_Code_Info.Text = "curtana";
//if (Drive_ComboBox.Text == "POCO X3 NFC") Device_Code_Info.Text = "surya";
//if (Drive_ComboBox.Text == "POCO C3") Device_Code_Info.Text = "angelicain";
//if (Drive_ComboBox.Text == "红米 Note 9 4G / 红米 9T 红米 9 Power") Device_Code_Info.Text = "lime";
//if (Drive_ComboBox.Text == "红米 10X Pro") Device_Code_Info.Text = "bomb";
//if (Drive_ComboBox.Text == "红米 10X 5G") Device_Code_Info.Text = "atom";
//if (Drive_ComboBox.Text == "POCO M2 Pro") Device_Code_Info.Text = "gram";
//if (Drive_ComboBox.Text == "Redmi K30S 至尊纪念版 / 小米 10T / 小米 10T Pro") Device_Code_Info.Text = "apollo";
//if (Drive_ComboBox.Text == "Redmi K30 至尊纪念版") Device_Code_Info.Text = "cezanne";
//if (Drive_ComboBox.Text == "红米 Note 9 Pro / 小米 10T Lite / 小米10i") Device_Code_Info.Text = "gauguin";
//if (Drive_ComboBox.Text == "POCO X3 Pro") Device_Code_Info.Text = "vayu";
//if (Drive_ComboBox.Text == "POCO M3") Device_Code_Info.Text = "citrus";
//if (Drive_ComboBox.Text == "红米 Note 9 Pro Max（印度版）") Device_Code_Info.Text = "excalibur";
//if (Drive_ComboBox.Text == "Redmi K30 Pro / Redmi K30 Pro 变焦版 / POCO F2 Pro") Device_Code_Info.Text = "lmi";
//if (Drive_ComboBox.Text == "红米 9C") Device_Code_Info.Text = "angelica";
//if (Drive_ComboBox.Text == "红米 9 / 红米 9 Prime") Device_Code_Info.Text = "lancelot";
//if (Drive_ComboBox.Text == "红米 10X 4G / 红米 Note 9") Device_Code_Info.Text = "merlin";
//if (Drive_ComboBox.Text == "小米 Note 10 Lite") Device_Code_Info.Text = "toco";
//if (Drive_ComboBox.Text == "红米 Note 8") Device_Code_Info.Text = "ginkgo";
//if (Drive_ComboBox.Text == "小米 10 Lite") Device_Code_Info.Text = "monet";
//if (Drive_ComboBox.Text == "小米 10 青春版") Device_Code_Info.Text = "vangogh";
//if (Drive_ComboBox.Text == "Redmi K30 5G") Device_Code_Info.Text = "picasso";
//if (Drive_ComboBox.Text == "Redmi K30i 5G") Device_Code_Info.Text = "picasso_48m";
//if (Drive_ComboBox.Text == "红米 9C NFC") Device_Code_Info.Text = "angelican";
//if (Drive_ComboBox.Text == "Redmi K30 4G / POCO X2") Device_Code_Info.Text = "phoenix";
//if (Drive_ComboBox.Text == "小米 CC9 Pro / 小米 Note 10 / 小米 Note 10 Pro") Device_Code_Info.Text = "tucana";
//if (Drive_ComboBox.Text == "红米 Note 8 Pro") Device_Code_Info.Text = "begonia";
//if (Drive_ComboBox.Text == "红米 8A Dual / 红米 8A Pro") Device_Code_Info.Text = "olivewood";
//if (Drive_ComboBox.Text == "红米 9（印度版）") Device_Code_Info.Text = "cattail";
//if (Drive_ComboBox.Text == "红米 8") Device_Code_Info.Text = "olive";
//if (Drive_ComboBox.Text == "红米 8A") Device_Code_Info.Text = "olivelite";
//if (Drive_ComboBox.Text == "小米 CC9 / 小米9 Lite") Device_Code_Info.Text = "pyxis";
//if (Drive_ComboBox.Text == "POCO M2") Device_Code_Info.Text = "shiva";
//if (Drive_ComboBox.Text == "小米 A3") Device_Code_Info.Text = "laurel_sprout";
//if (Drive_ComboBox.Text == "红米 Note11T Pro / 红米 Note11T Pro+ / POCO X4 GT / POCO X4 GT Pro") Device_Code_Info.Text = "xaga";
//if (Drive_ComboBox.Text == "红米 Note 8T") Device_Code_Info.Text = "willow";
//if (Drive_ComboBox.Text == "小米 9 Pro 5G") Device_Code_Info.Text = "crux";
//if (Drive_ComboBox.Text == "红米 Note11 4G") Device_Code_Info.Text = "selenes";
//if (Drive_ComboBox.Text == "红米 7A") Device_Code_Info.Text = "pine";
//if (Drive_ComboBox.Text == "小米 8 Pro 屏幕指纹版") Device_Code_Info.Text = "equuleus";
//if (Drive_ComboBox.Text == "小米 8") Device_Code_Info.Text = "dipper";
//if (Drive_ComboBox.Text == "红米 Note 7") Device_Code_Info.Text = "lavender";
//if (Drive_ComboBox.Text == "小米 9") Device_Code_Info.Text = "cepheus";
//if (Drive_ComboBox.Text == "小米 CC9 E") Device_Code_Info.Text = "laurus";
//if (Drive_ComboBox.Text == "小米 9 SE") Device_Code_Info.Text = "grus";
//if (Drive_ComboBox.Text == "Redmi K20 / 小米 9T") Device_Code_Info.Text = "davinci";
//if (Drive_ComboBox.Text == "红米 Note 7 Pro") Device_Code_Info.Text = "violet";
//if (Drive_ComboBox.Text == "小米 CC9 美图定制版") Device_Code_Info.Text = "vela";
//if (Drive_ComboBox.Text == "小米 8 透明探索版") Device_Code_Info.Text = "ursa";
//if (Drive_ComboBox.Text == "红米 7") Device_Code_Info.Text = "onclite";
//if (Drive_ComboBox.Text == "Redmi K20 Pro / 小米 9T Pro") Device_Code_Info.Text = "raphael";
//if (Drive_ComboBox.Text == "小米 MIX 2S") Device_Code_Info.Text = "polaris";
//if (Drive_ComboBox.Text == "小米 A2") Device_Code_Info.Text = "jasmine";
//if (Drive_ComboBox.Text == "小米 MIX 3") Device_Code_Info.Text = "perseus";
//if (Drive_ComboBox.Text == "小米 A2 Lite") Device_Code_Info.Text = "daisy";
//if (Drive_ComboBox.Text == "小米 8 SE") Device_Code_Info.Text = "sirius";
//if (Drive_ComboBox.Text == "红米 6A") Device_Code_Info.Text = "cactus";
//if (Drive_ComboBox.Text == "红米 6") Device_Code_Info.Text = "cereus";
//if (Drive_ComboBox.Text == "小米 8 Lite") Device_Code_Info.Text = "platina";
//if (Drive_ComboBox.Text == "小米 Max 3") Device_Code_Info.Text = "nitrogen";
//if (Drive_ComboBox.Text == "红米 Note 5") Device_Code_Info.Text = "whyred";
//if (Drive_ComboBox.Text == "小米 MIX 3 5G") Device_Code_Info.Text = "andromeda";
//if (Drive_ComboBox.Text == "红米 Go") Device_Code_Info.Text = "tiare";
//if (Drive_ComboBox.Text == "红米 Y3") Device_Code_Info.Text = "onc";
//if (Drive_ComboBox.Text == "小米 6X") Device_Code_Info.Text = "wayne";
//if (Drive_ComboBox.Text == "POCO F1") Device_Code_Info.Text = "beryllium";
//if (Drive_ComboBox.Text == "小米 Play") Device_Code_Info.Text = "lotus";
//if (Drive_ComboBox.Text == "红米 Note 6 Pro") Device_Code_Info.Text = "tulip";
//if (Drive_ComboBox.Text == "红米 S2 / 红米 Y2") Device_Code_Info.Text = "ysl";
//if (Drive_ComboBox.Text == "红米 6 Pro") Device_Code_Info.Text = "sakura";
//if (Drive_ComboBox.Text == "小米 MIX 2") Device_Code_Info.Text = "chiron";
//if (Drive_ComboBox.Text == "小米 Note 3") Device_Code_Info.Text = "jason";
//if (Drive_ComboBox.Text == "小米 A1") Device_Code_Info.Text = "tissot";
//if (Drive_ComboBox.Text == "小米 6") Device_Code_Info.Text = "sagit";
//if (Drive_ComboBox.Text == "红米 5") Device_Code_Info.Text = "rosy";
//if (Drive_ComboBox.Text == "红米 5A") Device_Code_Info.Text = "riva";
//if (Drive_ComboBox.Text == "小米 5X") Device_Code_Info.Text = "tiffany";
//if (Drive_ComboBox.Text == "红米 5 Plus") Device_Code_Info.Text = "vince";
//if (Drive_ComboBox.Text == "红米 4X") Device_Code_Info.Text = "santoni";
//if (Drive_ComboBox.Text == "红米 Note 4X 高通版") Device_Code_Info.Text = "mido";
//if (Drive_ComboBox.Text == "小米 5S") Device_Code_Info.Text = "capricorn";
//if (Drive_ComboBox.Text == "小米 5S Plus") Device_Code_Info.Text = "natrium";
//if (Drive_ComboBox.Text == "小米 MIX") Device_Code_Info.Text = "lithium";
//if (Drive_ComboBox.Text == "小米 Max 2") Device_Code_Info.Text = "oxygen";
//if (Drive_ComboBox.Text == "小米 Note 2") Device_Code_Info.Text = "scorpio";
//if (Drive_ComboBox.Text == "红米 Note 5A 标准版") Device_Code_Info.Text = "ugglite";
//if (Drive_ComboBox.Text == "红米 Note 5A 高配版") Device_Code_Info.Text = "ugg";
//if (Drive_ComboBox.Text == "Redmi K20 Pro 尊享版") Device_Code_Info.Text = "raphaels";
//if (Drive_ComboBox.Text == "小米平板 3") Device_Code_Info.Text = "cappu";
//if (Drive_ComboBox.Text == "小米平板 4 / 小米平板 4 Plus") Device_Code_Info.Text = "clover";
//if (Drive_ComboBox.Text == "小米 5C") Device_Code_Info.Text = "meri";
//if (Drive_ComboBox.Text == "红米 4A") Device_Code_Info.Text = "rolex";
//if (Drive_ComboBox.Text == "小米 Max 标准版") Device_Code_Info.Text = "hydrogen";
//if (Drive_ComboBox.Text == "小米 Max 高配版") Device_Code_Info.Text = "helium";
//if (Drive_ComboBox.Text == "红米 4") Device_Code_Info.Text = "prada";
//if (Drive_ComboBox.Text == "红米 4 高配版") Device_Code_Info.Text = "markw";
//if (Drive_ComboBox.Text == "红米 3S") Device_Code_Info.Text = "land";
//if (Drive_ComboBox.Text == "红米 Note 4 联发科版") Device_Code_Info.Text = "nikel";
//if (Drive_ComboBox.Text == "红米 Note 3 台湾特别版") Device_Code_Info.Text = "kate";
//if (Drive_ComboBox.Text == "红米 Note 3 全网通版") Device_Code_Info.Text = "kenzo";
//if (Drive_ComboBox.Text == "小米 5") Device_Code_Info.Text = "gemini";
//if (Drive_ComboBox.Text == "小米 3 / 小米 4") Device_Code_Info.Text = "cancro";
//if (Drive_ComboBox.Text == "红米手机 2 联通电信增强版") Device_Code_Info.Text = "wt88047_1";
//if (Drive_ComboBox.Text == "红米 Note 2") Device_Code_Info.Text = "hermes";
//if (Drive_ComboBox.Text == "小米平板") Device_Code_Info.Text = "mocha";
//if (Drive_ComboBox.Text == "小米 4i") Device_Code_Info.Text = "ferrari";
//if (Drive_ComboBox.Text == "红米手机 1S") Device_Code_Info.Text = "armani";
//if (Drive_ComboBox.Text == "小米 2S") Device_Code_Info.Text = "aries";
//if (Drive_ComboBox.Text == "小米平板 2") Device_Code_Info.Text = "latte";
//if (Drive_ComboBox.Text == "红米 Note 4G 单卡版") Device_Code_Info.Text = "dior";
//if (Drive_ComboBox.Text == "小米 Note 双网通版") Device_Code_Info.Text = "virgo";
//if (Drive_ComboBox.Text == "红米 Note 3 双网通版") Device_Code_Info.Text = "hennessy";
//if (Drive_ComboBox.Text == "小米 4C") Device_Code_Info.Text = "libra";
//if (Drive_ComboBox.Text == "红米 3 / 红米 3 Pro") Device_Code_Info.Text = "ido";
//if (Drive_ComboBox.Text == "红米 Note 3G 联通版") Device_Code_Info.Text = "lcsh92_wet_jb9";
//if (Drive_ComboBox.Text == "红米手机 2 移动增强版") Device_Code_Info.Text = "wt88047";
//if (Drive_ComboBox.Text == "红米手机 2 移动标配版") Device_Code_Info.Text = "wt88047_2";
//if (Drive_ComboBox.Text == "红米手机") Device_Code_Info.Text = "wt98007";
//if (Drive_ComboBox.Text == "红米 Pro") Device_Code_Info.Text = "omega";
//if (Drive_ComboBox.Text == "红米 Note 4G 双卡版") Device_Code_Info.Text = "gucci";