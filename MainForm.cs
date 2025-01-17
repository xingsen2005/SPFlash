using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using SPFlash;
namespace MiFlash
{
    public partial class MainForm : Form
    {       
        // 刷机包窗口
        private Download_Flash_File_Form _downloadFlashFileForm;
        private bool _isDownloadFlashFileFormOpen;
        // 调试窗口
        private ADB_Debug_Form _adbDebugForm;
        private bool _isAdbDebugFormOpen;
        // 刷写自定义分区窗口
        private Custom_Flash_Form _customFlashForm;
        private bool _isCustomFlashFormOpen;
        // 查询设备信息窗口
        private Device_Info_Form _deviceInfoForm;
        private bool _isDeviceInfoFormOpen;
        // Recovery 分区操作窗口
        private Recovery_Form _recoveryForm;
        private bool _isRecoveryFormOpen;
        // 程序根目录
        private static readonly string ProgramRoot = Application.StartupPath;
        [DllImport("user32.dll", SetLastError = true)] // 判断当前进程是否为管理员
        [return: MarshalAs(UnmanagedType.Bool)] 
        private static extern bool IsUserAnAdmin();      

        public MainForm()
        {
            InitializeComponent(); 
            // 子窗口
            _isDownloadFlashFileFormOpen = false; // 刷机包窗口
            _isAdbDebugFormOpen = false; // ADB 调试窗口          
            _isCustomFlashFormOpen = false; // 自定义刷写区窗口
            _isDeviceInfoFormOpen = false; // 查询设备信息窗口
            _isRecoveryFormOpen = false; // Recovery 分区窗口
            // 注册编辑框拖拽
            Payload_File_Path_TextBox.DragEnter += Payload_File_Path_TextBox_DragEnter;
            Payload_File_Path_TextBox.DragDrop += Payload_File_Path_TextBox_DragDrop;
            IMG_Vbmeta_File_Path_TextBox.DragEnter += IMG_Vbmeta_File_Path_TextBox_DragEnter;
            IMG_Vbmeta_File_Path_TextBox.DragDrop += IMG_Vbmeta_File_Path_TextBox_DragDrop;
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 禁止重复运行
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                Application.Exit();
            }
            
    

            // 选择程序根目录下的 Payload.bin（如果有）
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "Payload.bin"))) 
            {
                Payload_File_Path_TextBox.Text = Path.Combine(Environment.CurrentDirectory, "Payload.bin");
            }
            // 选择程序根目录下的 Vbmeta.img（如果有）
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "Vbmeta.img")))
            {
                IMG_Vbmeta_File_Path_TextBox.Text = Path.Combine(Environment.CurrentDirectory, "Vbmeta.img");
            }
            Input_IMG_TextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);           
            Check_Application_File();
            this.Text += Application.ProductName + "  @编译版本：" + Application.ProductVersion;
            Input_Specific_IMG_ComboBox.Text = "Vbmeta";
        }

        // 检查驱动文件
        private void Check_Drive_File()
        {
            string[] driveFolders = new[] { "Google", "Nvidia", "Microsoft", "Qualcomm" };
            foreach (string driveFolder in driveFolders)
            {
                if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, driveFolder)))
                {
                    MessageBox.Show($"没有找到“{driveFolder}”的驱动文件，请重新部署程序。", "驱动程序不存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        // 检查程序文件
        private void Check_Application_File()
        {
            var fileChecks = new[]
            {
                new {FilePath = "adb.exe", ExpectedHash = "705ddc21f33ac52105d1b075b019962ad0e44fb3d560bde69ce8cb3a36bca183"},
                new {FilePath = "AdbWinApi.dll", ExpectedHash = "9ffacedc41b2752075571e1a474ff50c5dcbe1f64db56db24aaec78aea1126df"},
                new {FilePath = "AdbWinUsbApi.dll", ExpectedHash = "13918fdab0c3ac77d077453a6036247cfeca10910aec845f188c41148c630bb2"},
                new {FilePath = "Aliyun.OSS.Core.dll", ExpectedHash = "d304e843cdb7f7b47fb03bdf0ca589a3dd8b940a3f74872374e0344511f085bc"},
                new {FilePath = "Aliyun.OSS.Core.pdb", ExpectedHash = "f7f21492c445654930ad3e2e17e3f1d782885b5e11f3a61aead63151baf4bf92"},
                new {FilePath = "Aliyun.OSS.Core.xml", ExpectedHash = "46f0fd315fbe9e9c5798af9bbf5b0b849c65f70c05b27a5069d883bb84b38074"},
                new {FilePath = "app-release.apk", ExpectedHash = "f279baebba45f5c5a302dcc6aa42cfe5254869cf3c9777fff4e7352eafc42cc3"},
                new {FilePath = "fastboot.exe", ExpectedHash = "377ff87ec40a2a9b947e00b487f4f4a42b03e195612bdcd8a526b70a1b0a918a"},
                new {FilePath = "Humanizer.dll", ExpectedHash = "2c522cd285de2e3a02520f91203f548e454b980821f10df90e801bd7d3f5c43e"},
                new {FilePath = "Humanizer.xml", ExpectedHash = "d500e81f3aaccc2fee969ffdd90818ef84541fbbb4ca8595b07beaccba2bb229"},
                new {FilePath = "icon.ico", ExpectedHash = "f2825f9565f7c693e277139f6a5cad91041f73e6e2f8709048858727814a167f"},
                new {FilePath = "Json.More.dll", ExpectedHash = "ff24e08fb7e36bda16d7673a3c5a1585d448ca9eebc540adb0cee16863e04fad"},
                new {FilePath = "Json.More.xml", ExpectedHash = "7a62826516a8f2d81a0d3e01d74e8cd5a37d5a75889c1d46b89a2a97ce705722"},
                new {FilePath = "JsonPatch.Net.dll", ExpectedHash = "f10863c4b17a615fb06d33546f7f0e2460a2b431cc222ea3281ca4772b379672"},
                new {FilePath = "JsonPatch.Net.xml", ExpectedHash = "5dea4b1e0b459e85613122933136401761850fc1454bee59da6c845bc8598537"},
                new {FilePath = "JsonPointer.Net.dll", ExpectedHash = "570b1697efc002497f662524507c3d3d8e9a9fefb8ed9542a0aabd5ed1fdea46"},
                new {FilePath = "JsonPointer.Net.xml", ExpectedHash = "86e3f8faf53ac982e2f1a19295a550865af96a1dfb83c08fb8a7467eee4528fe"},
                new {FilePath = "Microsoft.Bcl.AsyncInterfaces.dll", ExpectedHash = "80678203bd0203a6594f4e330b22543c0de5059382bb1c9334b7868b8f31b1bc"},
                new {FilePath = "Microsoft.Bcl.AsyncInterfaces.xml", ExpectedHash = "3d06c35d7b0eca37abe2d135cfe12d1012816a99e5e92e0cf4e8501e1b540aae"},
                new {FilePath = "payload-dumper-go.exe", ExpectedHash = "c79c8a8066bd39279c161598cee101772b29a0f0be90e5326ea8193f0d3f8eb5"},
                new {FilePath = "System.Buffers.dll", ExpectedHash = "accccfbe45d9f08ffeed9916e37b33e98c65be012cfff6e7fa7b67210ce1fefb"},
                new {FilePath = "System.Buffers.xml", ExpectedHash = "2ec7fb12e11f9831e40524427f6d88a3c9ffdd56ccfa81d373467b75b479a578"},
                new {FilePath = "System.IO.Compression.FileSystem.dll", ExpectedHash = "88ee59d81b5eeb341e3f751668aa73ce85d0099196b28d8055399b5de1deae45"},
                new {FilePath = "System.Memory.dll", ExpectedHash = "bf3fb84664f4097f1a8a9bc71a51dcf8cf1a905d4080a4d290da1730866e856f"},
                new {FilePath = "System.Memory.xml", ExpectedHash = "d5714c96607eb1a9d0f90f57ca194d8a9c3ede0656a1d1f461e78b209f054813"},
                new {FilePath = "System.Numerics.Vectors.dll", ExpectedHash = "1d3ef8698281e7cf7371d1554afef5872b39f96c26da772210a33da041ba1183"},
                new {FilePath = "System.Numerics.Vectors.xml", ExpectedHash = "ae2c3de9ad57d7091d9f44dcdee3f88eccf2ba7cb43adc9bb24769154a532dc7"},
                new {FilePath = "System.Runtime.CompilerServices.Unsafe.dll", ExpectedHash = "37768488e8ef45729bc7d9a2677633c6450042975bb96516e186da6cb9cd0dcf"},
                new {FilePath = "System.Runtime.CompilerServices.Unsafe.xml", ExpectedHash = "39c2d4a63a186d423e9c866f4d3e9a6acba0103398f20baf8b92a38744894215"},
                new {FilePath = "System.Shim.dll", ExpectedHash = "25ebc84a160d8ede07bdbbaabc81a88278338fad115d2b49b591cb9671ad01fc"},
                new {FilePath = "System.Text.Encodings.Web.dll", ExpectedHash = "e9c4f5eed186cb129c527c4b8d67d163ea2f2396e9d8b96e30b5e7c12203ce84"},
                new {FilePath = "System.Text.Encodings.Web.xml", ExpectedHash = "8e96160dd96e742f859587a710bbcfa2f11813bfe560ca823da00d3557520d3d"},
                new {FilePath = "System.Text.Json.dll", ExpectedHash = "86c3f263ae9b4469ab1266c80471087082447eb4a38e6b97bf5e84de15c07a1d"},
                new {FilePath = "System.Text.Json.xml", ExpectedHash = "2ce568cc3584f2c68e3037a4d2529e4467bf955d5b433790291e914d7a95366a"},
                new {FilePath = "System.Threading.Tasks.Extensions.dll", ExpectedHash = "4f81ffd0dc7204db75afc35ea4291769b07c440592f28894260eea76626a23c6"},
                new {FilePath = "System.Threading.Tasks.Extensions.xml", ExpectedHash = "975a9555f561b363c3e02fd533f6bf7083aa11bbc7cbf2b46c31df3d3696b97b"},
                new {FilePath = "System.ValueTuple.dll", ExpectedHash = "e905d102585b22c6df04f219af5cbdbfa7bc165979e9788b62df6dcc165e10f4"},
                new {FilePath = "System.ValueTuple.xml", ExpectedHash = "c37e163fa76629c196460c7b4d54e95b1a46a4c66ab7b6f3311959c8137dc5f1"},
            };
            string programDirectory = AppDomain.CurrentDomain.BaseDirectory;
            foreach (var check in fileChecks)
            {
                string filePath = Path.Combine(programDirectory, check.FilePath);
                if (!File.Exists(filePath))
                {
                    if (MessageBox.Show($"文件 {check.FilePath} 不存在，请重新部署程序。但你也可以点击“是”继续运行。", "文件不存在", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
                string actualHash = ComputeSHA256Hash(filePath);
                if (actualHash != check.ExpectedHash)
                {
                    if (MessageBox.Show($"文件 {check.FilePath} 已损坏，请重新部署程序。但你也可以点击“是”继续运行。", "文件校验失败", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
            }           
        }
        // 计算文件哈希
        private static string ComputeSHA256Hash(string filePath)
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
        // 封装安装驱动方法
        public static async Task Install_Drive()
        {
            if (!IsUserAnAdmin())
            {
                MessageBox.Show("权限不足，请以管理员身份运行此程序。", "权限不足", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var drivers = new[]
            {
                Path.Combine(ProgramRoot, @"Google\Driver\android_winusb.inf"),
                Path.Combine(ProgramRoot, @"Microsoft\Driver\wpdmtphw.inf"),
                Path.Combine(ProgramRoot, @"Nvidia\Driver\NvidiaUsb.inf"),
                Path.Combine(ProgramRoot, @"Qualcomm\Driver\qcser.inf")
            };

            foreach (var driver in drivers)
            {
                if (!File.Exists(driver))
                {
                    MessageBox.Show($"驱动文件不存在: {driver}", "文件不存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                var result = await InstallDriverAsync(driver);
                if (result == 0)
                {
                    MessageBox.Show($"驱动 {Path.GetFileName(driver)} 安装成功。", "安装成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 1)
                {
                    MessageBox.Show($"驱动 {Path.GetFileName(driver)} 安装失败。", "安装失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"安装驱动 {Path.GetFileName(driver)} 时发生未知错误，错误代码: {result}。", "未知错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // 安装驱动
        private static async Task<int> InstallDriverAsync(string driverPath)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "pnputil.exe",
                Arguments = $"-a -i \"{driverPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new Process { StartInfo = processStartInfo })
            {
                process.Start();

                var output = await process.StandardOutput.ReadToEndAsync();
                var error = await process.StandardError.ReadToEndAsync();

                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    Console.WriteLine(error);
                }

                return process.ExitCode;
            }
        }
        private void Recovery_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isRecoveryFormOpen)
            { 
                _recoveryForm = new Recovery_Form();
                _recoveryForm.FormClosed += RecoveryForm_FormClosed;
                _recoveryForm.Show();
                _isRecoveryFormOpen = true;
            }
            else
            {
                _recoveryForm.BringToFront();
            }
        }
        private void RecoveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isRecoveryFormOpen = false;
        }
        private void Download_Flash_File_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isDownloadFlashFileFormOpen)
            {
                _downloadFlashFileForm = new Download_Flash_File_Form();
                _downloadFlashFileForm.FormClosed += DownloadFlashFileForm_FormClosed;
                _downloadFlashFileForm.Show();
                _isDownloadFlashFileFormOpen = true;
            }
            else
            {
                _downloadFlashFileForm.BringToFront();
            }
        }
        private void Read_Device_Info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Device_Name_Lable.Text == "无法识别的设备" | Device_Name_Lable.Text == "请选择连接模式")
            {
                MessageBox.Show("需要正确连接设备才可以读取信息。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_isDeviceInfoFormOpen)
            {
                _deviceInfoForm = new Device_Info_Form();
                _deviceInfoForm.FormClosed += DeviceInfoForm_FormClosed;
                _deviceInfoForm.Show();
                _isDeviceInfoFormOpen = true;
            }
            else
            {
                _deviceInfoForm.BringToFront();
            }
        }

        private void DeviceInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isDeviceInfoFormOpen = false;
            _deviceInfoForm = null;
        }

        private void DownloadFlashFileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isDownloadFlashFileFormOpen = false;
            _downloadFlashFileForm = null;
        }
        private void Custom_Flash_Button_Click(object sender, EventArgs e)
        {
            if (!_isCustomFlashFormOpen)
            {
                _customFlashForm = new Custom_Flash_Form();
                _customFlashForm.FormClosed += CustomFlashForm_FormClosed;
                _customFlashForm.Show();
                _isCustomFlashFormOpen = true;
            }
            else
            {
                _customFlashForm.BringToFront();
            }
        }
        private void CustomFlashForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isCustomFlashFormOpen = false;
            _customFlashForm = null;
        }        
        private void ADB_Debug_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_isAdbDebugFormOpen)
            {
                _adbDebugForm = new ADB_Debug_Form();
                _adbDebugForm.FormClosed += ADB_Debug_Form_FormClosed;
                _adbDebugForm.Show();
                _isAdbDebugFormOpen = true;
            }
            else
            {
                _adbDebugForm.BringToFront();
            }
        }
        private void ADB_Debug_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isAdbDebugFormOpen = false;
            _adbDebugForm = null;
        }        
        private async void UnlockBL_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("强制降级和解锁 BL 利用了小米尚未封堵的漏洞。\n\n若你的设备出厂搭载 MIUI 系统，但不小心升级了 Hyper OS，则可以通过此功能强制降级至 MIUI 系统，然后通过原有途径解锁 BL。\n\n如果你的设备出厂搭载 Hyper OS，则无法使用此功能。\n\n注意：强制降级和解锁 BL 带来的不良后果均由你自行承担。", "请知悉", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                string output = await Task.Run(() =>
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = new ProcessStartInfo
                        {
                            FileName = ".\\unlock_string.exe",
                            Arguments = "\\unlock -s -nogui",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        process.Start();
                        string result = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();
                        return result;
                    }
                });
                ShowOperationResult(output); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出现了意料之外的错误：{ex.Message}", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 操作结果
        private void ShowOperationResult(string errorCode)
        {
            var dictionary = new Dictionary<string, dynamic>
            {
            { "400", new { message = "成功：所有操作均已成功。之后请使用 MiFlash 刷回 MIUI 系统。", icon = MessageBoxIcon.Information } },
            { "401", new { message = "错误：设备绑定的小米账号已被小米风控。", icon = MessageBoxIcon.Error} },
            { "402", new { message = "错误：设备未登录小米账号。", icon = MessageBoxIcon.Error} },
            { "403", new { message = "错误：小米账号登录凭据已过期，请在系统设置中重新登陆。", icon = MessageBoxIcon.Error} },
            { "404", new { message = "错误：设备凭据已过期，请重启手机。", icon = MessageBoxIcon.Error} },
            { "405", new { message = "错误：该设备需要强制验证小米账户资格。", icon = MessageBoxIcon.Error} },
            { "406", new { message = "错误：所有操作均已成功，但你仍然需要在最后一次绑定设备后等待 168 小时才可以刷回 MIUI 系统。", icon = MessageBoxIcon.Error} },
            { "407", new { message = "错误：需要关闭“查找手机”。", icon = MessageBoxIcon.Error} },
            { "408", new { message = "错误：需要在开发者选项中打开 USB 调试和 USB 调试（安全设置）。", icon = MessageBoxIcon.Error} },
            { "409", new { message = "错误：需要在开发者选项中打开 OEM 解锁。", icon = MessageBoxIcon.Error} },
            { "410", new { message = "错误：尚未在开发者选项 -> 设备解锁状态中绑定账号和设备。", icon = MessageBoxIcon.Error} },
            { "411", new { message = "错误：该设备已无法解锁，小米已在 UBL 解锁服务器层面屏蔽该设备。", icon = MessageBoxIcon.Error} },
            { "412", new { message = "错误：沟通设备无响应或时断时续，请检查连接线缆是否牢固。", icon = MessageBoxIcon.Error} },
            { "413", new { message = "错误：疑似非小米 / Redmi 设备。", icon = MessageBoxIcon.Error} },
            { "465", new { message = "错误：设备处于恢复模式，请重启至 ADB 模式。", icon = MessageBoxIcon.Error} },
            { "468", new { message = "错误：设备处于引导模式，请重启至 ADB 模式。", icon = MessageBoxIcon.Error} },
            { "475", new { message = "错误：数据包传输速度太慢，请检查线缆或将设备连接 USB 3.0 及以上的接口 。", icon = MessageBoxIcon.Error} },
            { "476", new { message = "错误：设备已正常连接，但无法对设备发送数据包。", icon = MessageBoxIcon.Error} },           
            };

            if (dictionary.TryGetValue(errorCode, out dynamic messageData))
            {
                MessageBox.Show(messageData.message, "操作结果", MessageBoxButtons.OK, messageData.icon);
            }
            else
            {
                MessageBox.Show("出现了意料之外的错误。", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Select_Payload_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Payload.bin|Payload.bin",
                Title = "选择 Payload.bin 文件"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Payload_File_Path_TextBox.Text = openFileDialog.FileName;
            }
        }
        private void Payload_File_Path_TextBox_DragEnter(object sender, DragEventArgs e)
        {           
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {  
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                bool isValidFile = false;
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower() == ".bin")
                    {
                        isValidFile = true;
                        break;
                    }
                }  
                e.Effect = isValidFile ? DragDropEffects.Copy : DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void Payload_File_Path_TextBox_DragDrop(object sender, DragEventArgs e)
        {  
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);  
            if (files.Length > 0)
            {
                string filePath = files[0];  
                if (Path.GetExtension(filePath).ToLower() == ".bin")
                {  
                    Payload_File_Path_TextBox.Text = filePath;
                }
            }
        }

        private void IMG_Vbmeta_File_Path_TextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                bool isValidFile = false;
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower() == "Vbmeta.img")
                    {
                        isValidFile = true;
                        break;
                    }
                }
                e.Effect = isValidFile ? DragDropEffects.Copy : DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void IMG_Vbmeta_File_Path_TextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                if (Path.GetExtension(filePath).ToLower() == "Vbmeta.img")
                {
                    IMG_Vbmeta_File_Path_TextBox.Text = filePath;
                }
            }
        }

        private void Input_IMG_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "选择要导出 IMG 文件的文件夹"
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath.TrimEnd('\\');
                Input_IMG_TextBox.Text = selectedPath;
            }
        }
        private async void Input_Button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Payload_File_Path_TextBox.Text) || string.IsNullOrWhiteSpace(Input_IMG_TextBox.Text))
            {
                MessageBox.Show("路径不能为空或仅包含空格。", "路径无效", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Directory.Exists(Path.GetPathRoot(Payload_File_Path_TextBox.Text)) == false || Directory.Exists(Path.GetPathRoot(Input_IMG_TextBox.Text)) == false)
            {
                MessageBox.Show("请选择一个有效路径。", "路径无效", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 删去 Input_IMG_TextBox.Text 末尾的反斜杠
            if (Input_IMG_TextBox.Text.EndsWith("\\"))
            {
                Input_IMG_TextBox.Text = Input_IMG_TextBox.Text.TrimEnd('\\');
            }

            Input_Button.Text = "稍等...";
            Input_Button.Enabled = false;

            string arguments;
            if (Input_ALL_IMG_RadioButton.Checked)
            {
                MessageBox.Show("导出全部镜像需要较长时间，请耐心等待。","导出全部镜像",MessageBoxButtons.OK,MessageBoxIcon.Information);
                arguments = $"/c .\\payload-dumper-go.exe -o \"{Input_IMG_TextBox.Text}\" \"{Payload_File_Path_TextBox.Text}\"";
            }
            else if (Input_Boot_IMG_RadioButton.Checked)
            {
                arguments = $"/c .\\payload-dumper-go.exe -p boot -o \"{Input_IMG_TextBox.Text}\" \"{Payload_File_Path_TextBox.Text}\"";
            }
            else if (Input_Init_IMG_RadioButton.Checked)
            {
                arguments = $"/c .\\payload-dumper-go.exe -p init_boot -o \"{Input_IMG_TextBox.Text}\" \"{Payload_File_Path_TextBox.Text}\"";
            }
            else if (Input_Specific_IMG_RadioButton.Checked)
            {
                arguments = $"/c .\\payload-dumper-go.exe -p {Input_Specific_IMG_ComboBox.Text} -o \"{Input_IMG_TextBox.Text}\" \"{Payload_File_Path_TextBox.Text}\"";                
            }

            else
            {
                MessageBox.Show("未选择任何镜像类型。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            await RunProcessAsync(arguments);
            // 如果用户选择了导出 vbmeta，则自动填充路径
            if (Input_Specific_IMG_ComboBox.Text == "vbmeta")
            {
                IMG_Vbmeta_File_Path_TextBox.Text = Input_IMG_TextBox.Text + "\\Vbmeta.img";
            }

            Input_Button.Text = "完成";

            if (Open_File_Path_CheckBox.Checked)
            {
                Process.Start(Input_IMG_TextBox.Text);
            }
            await Task.Delay(1500);           
            Input_Button.Enabled = true;
            Input_Button.Text = "导出";            
        }
        private async Task RunProcessAsync(string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                FileName = "cmd.exe",
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.EnableRaisingEvents = true;
                var tcs = new TaskCompletionSource<bool>();
                process.Exited += (s, e) => tcs.SetResult(true);
                process.Start();
                Task<string> outputTask = process.StandardOutput.ReadToEndAsync();
                Task<string> errorTask = process.StandardError.ReadToEndAsync();
                await tcs.Task;
                string output = await outputTask;
                string error = await errorTask;
                if (process.ExitCode != 0)
                {
                    MessageBox.Show("导出失败。请检查 Payload.bin 文件是否正确，或者将以下报错信息反馈给开发者。\n" + error, "导出失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        private void Clear_Data_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清除数据？此操作无法撤销，请三思。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<string> commands = new List<string>();
                if (CL_System_CheckBox.Checked)
                {
                    commands.Add("fastboot erase system");
                }
                if (CL_Boot_CheckBox.Checked)
                {
                    commands.Add("fastboot erase boot");
                }
                if (CL_Cache_CheckBox.Checked)
                {
                    commands.Add("fastboot erase cache");
                }
                if (CL_UserData_CheckBox.Checked)
                {
                    commands.Add("fastboot erase userdata");
                }
                if (commands.Count == 0)
                {
                    MessageBox.Show("请至少选择一个要清除的分区。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var command in commands)
                {
                    try
                    {
                        Process.Start("cmd.exe", "/c " + command);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"执行命令 {command} 失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("数据清除操作已完成。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Input_Init_IMG_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Input_Specific_IMG_ComboBox.Enabled = false;
            if (Input_Init_IMG_RadioButton.Checked)
            {
                MessageBox.Show("部分机型并不存在“Init_boot.img”镜像，如果没有导出文件则表示该机型不支持。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void About_Me_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + " \n\n" + "本程序基于 GPL 3.0 协议开源，你可以任意地查阅、修改和分发。\n\n作者：" + Application.CompanyName + "\n\n邮箱：xingsenfirst@gmail.com" + "\n\n编译版本：" + Application.ProductVersion, "关于我", MessageBoxButtons.OK);
        }        
        private void Open_Source_License_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xingsen2005/SPFlash");
        }
        
        // 命令输出异步
        private async Task<string> ExecuteCommandAsync(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c {command}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string output = await process.StandardOutput.ReadToEndAsync();
            process.WaitForExit();
            return output.Trim();
        }
        private async Task UpdateDeviceNameLabelAsync(string command)
        {
            string output = await ExecuteCommandAsync(command);                  


            if (deviceNameMapping.TryGetValue(output, out string deviceName))
            {
                Device_Name_Lable.Text = deviceName;
            }
            else
            {
                Device_Name_Lable.Text = "无法识别的设备";
                MessageBox.Show("无法识别的设备：\n\n1、是否已连接设备并开启和授权 USB 调试？\n2、可能是过于老旧的小米 / 红米设备；\n3、非小米 / Redmi 设备暂未适配。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Link_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ADB_RadioButton.Checked)
                {
                    await UpdateDeviceNameLabelAsync("adb shell getprop ro.product.name");
                }
                else if (FASTBOOT_RadioButton.Checked)
                {
                    await UpdateDeviceNameLabelAsync("fastboot getvar product");                                       
                }
                else if (Recovery_RadioButton.Checked)
                {
                    await ExecuteCommandAsync("adb reboot bootloader");
                    await UpdateDeviceNameLabelAsync("fastboot getvar product");
                }               
            }
            catch (Exception ex)
            {
                Device_Name_Lable.Text = "无法识别的设备。";
                MessageBox.Show($"尝试连接设备或读取设备型号时出现错误：{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private readonly Dictionary<string, string> deviceNameMapping = new Dictionary<string, string>
        {
            {"aurora","小米 14 Ultra"},
            {"ruan","红米平板 Pro 5G"},
            {"moon","红米 13 / POCO M6"},
            {"earth","红米 12C / POCO C55"},
            {"dizi","红米平板 Pro"},
            {"agate","小米 11T"},
            {"cupid","小米 12"},
            {"light","红米 Note 11E / POCO M4 5G / 红米 10 Prime+ 5G"},
            {"fleur","红米 Note 11S / POCO M4 Pro 4G"},
            {"air","红米13R 5G / 红米13C 5G / POCO M6 5G"},
            {"garnet","红米 Note 13 Pro 5G / POCO X6"},
            {"goku","小米 MIX Fold 4"},
            {"vili","小米11T Pro"},
            {"pearl","红米 Note12T Pro"},
            {"ingres","Redm K50 电竞版 / POCO F4 GT"},
            {"star","小米 11 Pro / 小米 11 Ultra"},
            {"plato","小米 12T"},
            {"pissarro","红米 Note 11 Pro / 红米 Note11 Pro+ / 小米 11i"},
            {"liuqin","小米平板 6 Pro"},
            {"taoyao","小米 12 Lite"},
            {"munch","Redmi K40S（POCO F4）"},
            {"zeus","小米 12 Pro"},
            {"emerald","POCO M6 Pro 4G"},
            {"gold","红米 Note13 5G / 红米 Note 13R Pro"},
            {"nabu","小米平板 5"},
            {"rembrandt","Redmi K60E"},
            {"klein","红米 A3X"},
            {"lisa","小米 11 青春活力版 / 小米11 Lite 5G NE"},
            {"ziyi","小米 CIVI 2 / 小米 13 Lite"},
            {"veux","红米 Note 11E Pro / 红米 Note 11 Pro 5G"},
            {"chenfeng","小米 CIVI 4 Pro"},
            {"fire","红米 12"},
            {"pipa","小米平板 6"},
            {"evergreen","POCO M4 Pro 5G"},
            {"lake","红米 14C / 红米 A3 Pro / POCO C75"},
            {"diting","红米 K50 至尊版 / 小米 12T Pro"},
            {"xun","红米平板 SE"},
            {"breeze","红米 Note 13R / 红米 13 5G / POCO M6 Plus 5G"},
            {"sheng","小米平板 6S Pro 12.4"},
            {"rock","POCO M5 / 红米 11 Prime 4G"},
            {"zircon","红米 Note13 Pro+ 5G"},
            {"sapphiren","红米 Note13 4G NFC"},
            {"ruby","红米 Note12 Pro"},
            {"matisse","Redmi K50 Pro"},
            {"daumier","小米12 Pro 天玑版"},
            {"marble","红米 Note12 Turbo / POCO F5 5G"},
            {"psyche","小米 12X"},
            {"venus","小米 11"},
            {"gale","红米 13 / CPOCO C65"},
            {"yuechu","小米 CIVI 3"},
            {"sweet_k6a","红米 Note12 Pro 4G"},
            {"sky","红米 Note12R / POCO M6 Pro 5G / 红米12 5G"},
            {"moonstone","POCO X5 5G"},
            {"ishtar","小米 13 Ultra"},
            {"mondrian","Redmi K60 / POCO F5 Pro"},
            {"spark","红米平板 SE 8.7 4G"},
            {"flare","红米平板 SE 8.7 WiFi"},
            {"redwood","红米 Note12 Pro 极速版 / POCO X5 Pro 5G"},
            {"haydn","Redmi K40 Pro / Redmi K40 Pro+ / 小米11i / 小米 11X Pro"},
            {"sunstone","红米 Note12 5G / 红米 Note 12R Pro"},
            {"sea","红米 Note12S"},
            {"peridot","红米 Turbo 3 / POCO F6"},
            {"opal","红米 Note 11S 5G"},
            {"yudi","小米平板 6 Max"},
            {"ruyi","小米 MIX Flip"},
            {"yunluo","红米平板"},
            {"houji","小米 14"},
            {"zizhan","小米 MIX Fold 2"},
            {"vermeer","Redmi K70 / POCO F6 Pro"},
            {"nuwa","小米 13 Pro"},
            {"fuxi","小米 13"},
            {"babylon","小米 MIX Fold 3"},
            {"sapphire","红米 Note13 4G"},
            {"odin","小米 MIX4"},
            {"rubens","Redmi K50"},
            {"unicorn","小米 12S Pro"},
            {"duchamp","Redmi K70E / POCO X6 Pro 5G"},
            {"alioth","Redmi K40 / POCO F3 / 小米 11X"},
            {"mayfly","小米 12S"},
            {"socrates","Redmi K60 Pro"},
            {"shennongt","小米 14 钛金属版"},
            {"corot","Redmi K60 至尊版 / 小米 13T Pro"},
            {"manet","Redmi K70 Pro"},
            {"rothko","Redmi K70 至尊版 / 小米 13T Pro"},
            {"zijin","小米CIVI 1S"},
            {"dagu","小米平板 5 Pro 12.4"},
            {"tapas","红米 Note12 4G"},
            {"thor","小米 12S Ultra"},
            {"topaz","红米 Note12 4G NFC"},
            {"shennong","小米 14 Pro"},
            {"aristotle","小米 13T"},
            {"thyme","小米 10S"},
            {"cmi","小米 10 Pro"},
            {"cas","小米 10 至尊纪念版"},
            {"umi","小米 10"},
            {"enuma","小米平板 5 Pro（5G）"},
            {"elish","小米平板 5 Pro（WiFi）"},
            {"fog","红米 10C"},
            {"blue","红米 A3 / POCO C61"},
            {"ice","红米 A1 / POCO C50"},
            {"evergo","红米 Note11 5G"},
            {"dandelion","红米 10A"},
            {"biloba","红米 Note 8 (2021年款)"},
            {"ares","Redmi K40 游戏增强版 / POCO F3 GT"},
            {"water","POCO C51 / 红米 A2 / 红米 A2+"},
            {"rosemary","红米 Note 10S"},
            {"rosemary_p","POCO M5S"},
            {"frost","POCO C40"},
            {"mona","小米 CIVI"},
            {"renoir","小米 11 青春版"},
            {"lilac","红米 Note 10T"},
            {"selene","红米 10 / 红米10 Prime"},
            {"chopin","红米 Note 10 Pro / POCO X3 GT"},
            {"lightcm","红米 Note 11R"},
            {"sweet","红米 Note 10 Pro"},
            {"mojito","红米 Note 10"},
            {"cetus","小米 MIX Fold"},
            {"cannong","红米 Note 9T 5G"},
            {"courbet","小米 11 Lite"},
            {"cannon","红米 Note 9 5G"},
            {"camellia","红米 Note 10 / POCO M3 Pro / 红米 Note 11 SE"},
            {"camellian","红米 Note 10 5G"},
            {"joyeuse","红米 Note 9 Pro"},
            {"curtana","红米 Note 9S / 红米 Note 9 Pro（印度版）"},
            {"surya","POCO X3 NFC"},
            {"angelicain","POCO C3"},
            {"lime","红米 Note 9 4G / 红米 9T 红米 9 Power"},
            {"bomb","红米 10X Pro"},
            {"atom","红米 10X 5G"},
            {"gram","POCO M2 Pro"},
            {"apollo","Redmi K30S 至尊纪念版 / 小米 10T / 小米 10T Pro"},
            {"cezanne","Redmi K30 至尊纪念版"},
            {"gauguin","红米 Note 9 Pro / 小米 10T Lite / 小米10i"},
            {"vayu","POCO X3 Pro"},
            {"citrus","POCO M3"},
            {"excalibur","红米 Note 9 Pro Max（印度版）"},
            {"lmi","Redmi K30 Pro / Redmi K30 Pro 变焦版 / POCO F2 Pro"},
            {"angelica","红米 9C"},
            {"lancelot","红米 9 / 红米 9 Prime"},
            {"merlin","红米 10X 4G / 红米 Note 9"},
            {"toco","小米 Note 10 Lite"},
            {"ginkgo","红米 Note 8"},
            {"monet","小米 10 Lite"},
            {"vangogh","小米 10 青春版"},
            {"picasso","Redmi K30 5G"},
            {"picasso_48m","Redmi K30i 5G"},
            {"angelican","红米 9C NFC"},
            {"phoenix","Redmi K30 4G / POCO X2"},
            {"tucana","小米 CC9 Pro / 小米 Note 10 / 小米 Note 10 Pro"},
            {"begonia","红米 Note 8 Pro"},
            {"olivewood","红米 8A Dual / 红米 8A Pro"},
            {"cattail","红米 9（印度版）"},
            {"olive","红米 8"},
            {"olivelite","红米 8A"},
            {"pyxis","小米 CC9 / 小米9 Lite"},
            {"shiva","POCO M2"},
            {"laurel_sprout","小米 A3"},
            {"xaga","红米 Note11T Pro / 红米 Note11T Pro+ / POCO X4 GT / POCO X4 GT Pro"},
            {"willow","红米 Note 8T"},
            {"crux","小米 9 Pro 5G"},
            {"selenes","红米 Note11 4G"},
            {"pine","红米 7A"},
            {"equuleus","小米 8 Pro 屏幕指纹版"},
            {"dipper","小米 8"},
            {"lavender","红米 Note 7"},
            {"cepheus","小米 9"},
            {"laurus","小米 CC9 E"},
            {"grus","小米 9 SE"},
            {"davinci","Redmi K20 / 小米 9T"},
            {"violet","红米 Note 7 Pro"},
            {"vela","小米 CC9 美图定制版"},
            {"ursa","小米 8 透明探索版"},
            {"onclite","红米 7"},
            {"raphael","Redmi K20 Pro / 小米 9T Pro"},
            {"polaris","小米 MIX 2S"},
            {"jasmine","小米 A2"},
            {"perseus","小米 MIX 3"},
            {"daisy","小米 A2 Lite"},
            {"sirius","小米 8 SE"},
            {"cactus","红米 6A"},
            {"cereus","红米 6"},
            {"platina","小米 8 Lite"},
            {"nitrogen","小米 Max 3"},
            {"whyred","红米 Note 5"},
            {"andromeda","小米 MIX 3 5G"},
            {"tiare","红米 Go"},
            {"onc","红米 Y3"},
            {"wayne","小米 6X"},
            {"beryllium","POCO F1"},
            {"lotus","小米 Play"},
            {"tulip","红米 Note 6 Pro"},
            {"ysl","红米 S2 / 红米 Y2"},
            {"sakura","红米 6 Pro"},
            {"chiron","小米 MIX 2"},
            {"jason","小米 Note 3"},
            {"tissot","小米 A1"},
            {"sagit","小米 6"},
            {"rosy","红米 5"},
            {"riva","红米 5A"},
            {"tiffany","小米 5X"},
            {"vince","红米 5 Plus"},
            {"santoni","红米 4X"},
            {"mido","红米 Note 4X 高通版"},
            {"capricorn","小米 5S"},
            {"natrium","小米 5S Plus"},
            {"lithium","小米 MIX"},
            {"oxygen","小米 Max 2"},
            {"scorpio","小米 Note 2"},
            {"ugglite","红米 Note 5A 标准版"},
            {"ugg","红米 Note 5A 高配版"},
            {"raphaels","Redmi K20 Pro 尊享版"},
            {"cappu","小米平板 3"},
            {"clover","小米平板 4 / 小米平板 4 Plus"},
            {"meri","小米 5C"},
            {"rolex","红米 4A"},
            {"hydrogen","小米 Max 标准版"},
            {"helium","小米 Max 高配版"},
            {"prada","红米 4"},
            {"markw","红米 4 高配版"},
            {"land","红米 3S"},
            {"nikel","红米 Note 4 联发科版"},
            {"kate","红米 Note 3 台湾特别版"},
            {"kenzo","红米 Note 3 全网通版"},
            {"gemini","小米 5"},
            {"cancro","小米 3 / 小米 4"},
            {"wt88047_1","红米手机 2 联通电信增强版"},
            {"hermes","红米 Note 2"},
            {"mocha","小米平板"},
            {"ferrari","小米 4i"},
            {"armani","红米手机 1S"},
            {"aries","小米 2S"},
            {"latte","小米平板 2"},
            {"dior","红米 Note 4G 单卡版"},
            {"virgo","小米 Note 双网通版"},
            {"hennessy","红米 Note 3 双网通版"},
            {"libra","小米 4C"},
            {"ido","红米 3 / 红米 3 Pro"},
            {"lcsh92_wet_jb9","红米 Note 3G 联通版"},
            {"wt88047","红米手机 2 移动增强版"},
            {"wt88047_2","红米手机 2 移动标配版"},
            {"wt98007","红米手机"},
            {"omega","红米 Pro"},
            {"gucci","红米 Note 4G 双卡版"}
        };
        private void Input_Boot_IMG_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Input_Specific_IMG_ComboBox.Enabled = false;
        }

        private void Input_ALL_IMG_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Input_Specific_IMG_ComboBox.Enabled = false;
        }

        private void Input_Specific_IMG_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Input_Specific_IMG_ComboBox.Enabled = true;
        }

        private void Select_Vbmeta_IMG_Button_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "vbmeta.img|vbmeta.img",
                Title = "请选择 vbmeta.img 文件"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IMG_Vbmeta_File_Path_TextBox.Text = openFileDialog.FileName;
            }
        }

        private bool ValidateVbmetaFilePath()
        {
            if (string.IsNullOrEmpty(IMG_Vbmeta_File_Path_TextBox.Text))
            {
                MessageBox.Show("请选择 Vbmeta.img 文件，操作 AVB 2.0 需要这个文件。\n\n如果还没有该文件，请在“Setup 01.导出镜像”组合框中找到“导出指定镜像”，然后选择“vbmeta”，最后再点击“导出”。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async Task ExecuteFastbootCommandAsync(string command)
        {          

            try
            {
                await ExecuteCommandAsync(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"执行命令时出错：{ex.Message}，请将以上报错信息反馈给开发者。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Enable_AVB2_Flash_Button_Click(object sender, EventArgs e)
        {            
            if (IMG_Vbmeta_File_Path_TextBox.Text == "" || Directory.Exists(Path.GetPathRoot(IMG_Vbmeta_File_Path_TextBox.Text)) == false)
            {
                MessageBox.Show("请选择一个有效路径。", "路径无效", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateVbmetaFilePath()) return;
            try
            {
                string command = "fastboot flash vbmeta " + IMG_Vbmeta_File_Path_TextBox.Text;
                await ExecuteFastbootCommandAsync(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"执行命令时出错：{ex.Message}，请将以上报错信息反馈给开发者。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Disable_AVB2_Flash_Button_Click(object sender, EventArgs e)
        {
            if (IMG_Vbmeta_File_Path_TextBox.Text == "" || Directory.Exists(Path.GetPathRoot(IMG_Vbmeta_File_Path_TextBox.Text)) == false)
            {
                MessageBox.Show("请选择一个有效路径。", "路径无效", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateVbmetaFilePath()) return;
            try
            {
                string command = "fastboot --disable-verity --disable-verification flash vbmeta " + IMG_Vbmeta_File_Path_TextBox.Text;
                await ExecuteFastbootCommandAsync(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"执行命令时出错：{ex.Message}，请将以上报错信息反馈给开发者。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reboot_to_Fstboot_Button_Click(object sender, EventArgs e)
        {
            Reboot_Device();
        }

        private void Input_Specific_IMG_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (Input_Specific_IMG_ComboBox.SelectedItem.ToString() == "init_boot")
            {
                MessageBox.Show("部分机型并不存在“Init_boot.img”镜像，如果没有导出文件则表示该机型不支持。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Install_Device_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_Drive_File();
        }       
    }   
}

