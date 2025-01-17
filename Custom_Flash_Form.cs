using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
namespace SPFlash
{
    public partial class Custom_Flash_Form : Form
    {
        public Custom_Flash_Form()
        {
            InitializeComponent();
        }
        private void Custom_Flash_Form_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - 获取 Root 权限";                      
            // 默认选择程序根目录下的 boot.img（如果有）
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "boot.img")))
            {
                Boot_File_Path_TextBox.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "boot.img");
            }

            Select_Input_Path_TextBox.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void ExecuteCommand(string command)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardInput.WriteLine(command + "&exit");
                    process.WaitForExit();
                    if (MessageBox.Show("命令执行成功。是否重启设备？", "成功", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Reboot_Device();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"执行命令时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reboot_Device()
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardInput.WriteLine("fastboot reboot");
                    process.StandardInput.Close();
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"重启设备时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Install_Magisk_Button_Click(object sender, EventArgs e)
        {
            // 检查文件完整性
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app-release.apk"); 
            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件不存在，是否已完整部署程序？", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string expectedHash = "f279baebba45f5c5a302dcc6aa42cfe5254869cf3c9777fff4e7352eafc42cc3";
            string actualHash = ComputeSHA256Hash(filePath);
            if (actualHash != expectedHash)
            {
                MessageBox.Show("文件已损坏，请重新部署程序。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            // 安装 Magisk
            try
            {
                ExecuteCommand("adb install " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app-release.apk"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"安装失败，是否已正确连接设备并打开 USB 安装？\n\n错误信息：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ComputeSHA256Hash(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        builder.Append(hashBytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
        }        

        private void Select_Input_Path_Button_Click(object sender, EventArgs e)
        {            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "选择要导出的文件夹"
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath.TrimEnd('\\');
                Select_Input_Path_TextBox.Text = selectedPath;
            }

        }
        private void Path_Boot_Button_Click(object sender, EventArgs e)
        {
            // 修补 Boot 镜像
            ExecuteCommand("python " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Patch.py") + " --boot " + Boot_File_Path_TextBox.Text);
        }

        private void Functions_Scripts(object sender, EventArgs e)
        { 
            
        }
        private void Select_Boot_IMG_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "引导加载镜像|*.img",
                Title = "选择镜像文件",
                CheckFileExists = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Boot_File_Path_TextBox.Text = openFileDialog.FileName;
                string filePath = openFileDialog.FileName;
                int lastBackslashIndex = filePath.LastIndexOf('\\');
                int lastDotIndex = filePath.LastIndexOf('.');
                if (lastBackslashIndex != -1 && lastDotIndex != -1 && lastBackslashIndex < lastDotIndex)
                {
                    string partition = filePath.Substring(lastBackslashIndex + 1, lastDotIndex - lastBackslashIndex - 1);
                    Select_Input_Path_TextBox.Text = partition;
                }
            }
        }

        private void Reboot_to_Fstboot_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardInput.WriteLine("fastboot reboot");
                    process.StandardInput.Close();
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"重启设备时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
