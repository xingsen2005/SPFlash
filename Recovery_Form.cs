using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aliyun.OSS.Common;
using Aliyun.OSS;

namespace SPFlash
{
    public partial class Recovery_Form : Form
    {
        public Recovery_Form()
        {
            InitializeComponent();
        }

        private void Recovery_Form_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - Recovery 下载";
            Drive_ComboBox.SelectedIndex = 0;
            Recovery_ComboBox.SelectedIndex = 0;
            Download_Source_ComboBox.SelectedIndex = 0;
            Download_Path_TextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);           
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
                //Confirm_Button.Enabled = false;
                //Confirm_Button.Text = "未找到符合的结果";
            }
            else
            {
                //Confirm_Button.Enabled = true;
                //Confirm_Button.Text = "开始搜索";
            }
        }

        private void DL_To_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "选择下载文件夹"
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath.TrimEnd('\\');
                Download_Path_TextBox.Text = selectedPath;
            }

        }
    }
}
