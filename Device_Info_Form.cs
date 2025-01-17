using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPFlash
{
    public partial class Device_Info_Form : Form
    {
        readonly string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string manufacturer; // 设备制造商
        string model;// 设备型号
        string name;// 设备代号
        string incremental;// 系统版本号
        string androidVersion; // 安卓版本号
        string wmSize; // 屏幕分辨率
        string cpuAbi; // 架构
        string sdk;// sdk版本
        string buildDate;// 构建日期
        string gnss_back; // GNSS 后台优化
        string mobiledata; // 移动数据状态
        string dfcservice; // DFC 服务状态
        string wmDensity; // 屏幕密度
        string androidID; // Android ID
        string batteryInfo; // 电池信息
        string batteryStatus; // 电池状态
        public Device_Info_Form()
        {
            InitializeComponent();
        }

        private async void Device_Info_Form_LoadAsync(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "：设备信息";
            manufacturer = await ExecuteCommandAsync("adb shell getprop ro.product.manufacturer");
            model = await ExecuteCommandAsync("adb shell getprop ro.product.model");
            name = await ExecuteCommandAsync("adb shell getprop ro.product.name");
            incremental = await ExecuteCommandAsync("adb shell getprop ro.build.version.incremental");
            androidVersion = await ExecuteCommandAsync("adb shell getprop ro.build.version.release");
            cpuAbi = await ExecuteCommandAsync("adb shell getprop ro.product.cpu.abi");
            sdk = await ExecuteCommandAsync("adb shell getprop ro.build.version.sdk");
            buildDate = await ExecuteCommandAsync("adb shell getprop ro.build.date.utc");
            gnss_back = await ExecuteCommandAsync("adb shell getprop persist.sys.gnss_back.opt");
            mobiledata = await ExecuteCommandAsync("ro.com.android.mobiledata");
            dfcservice = await ExecuteCommandAsync("sys.dfcservice.ctrl");
            wmDensity = await ExecuteCommandAsync("adb shell wm density");
            wmSize = await ExecuteCommandAsync("adb shell wm size");
            androidID = await ExecuteCommandAsync("adb shell settings get secure android_id");
            batteryInfo = await ExecuteCommandAsync("adb shell dumpsys battery");

            DateTime buildDateTimeUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(long.Parse(buildDate));
            TimeZoneInfo chinaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            DateTime buildDateTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(buildDateTimeUtc, chinaTimeZone);
            
            var wmSizeParts = wmSize.Split(new[] { "Physical size: ", "Override size: " }, StringSplitOptions.RemoveEmptyEntries);
            string physicalSize = wmSizeParts.Length > 0 ? wmSizeParts[0] : "未知";
            string overrideSize = wmSizeParts.Length > 1 ? wmSizeParts[1] : "未知";

            var wmDensityParts = wmDensity.Split(new[] { "Physical density: ", "Override density: " }, StringSplitOptions.RemoveEmptyEntries);
            string physicalDensity = wmDensityParts.Length > 0 ? wmDensityParts[0] : "未知";
            string overrideDensity = wmDensityParts.Length > 1 ? wmDensityParts[1] : "未知";

            var batteryInfoParts = batteryInfo.Split(new[] { "AC powered: ", "USB powered: ", "Wireless powered: ", "Dock powered: ", "Max charging current: ", "Max charging voltage: ", "Charge counter: ", "level: ", "voltage: ", "temperature: ", "technology: ", "health: " }, StringSplitOptions.RemoveEmptyEntries);
            bool acPowered = bool.Parse(batteryInfoParts[0]);
            bool usbPowered = bool.Parse(batteryInfoParts[1]);
            bool wirelessPowered = bool.Parse(batteryInfoParts[2]);
            bool dockPowered = bool.Parse(batteryInfoParts[3]);
            string maxChargingCurrent = batteryInfoParts[4].Replace("µA", "");
            string maxChargingVoltage = batteryInfoParts[5].Replace("µV", "");
            string chargeCounter = batteryInfoParts[6];
            string batteryLevel = batteryInfoParts[7];
            string voltage = batteryInfoParts[8].Replace("µV", "");   
            string temperature = batteryInfoParts[9];
            string technology = batteryInfoParts[10];
            string health = batteryInfoParts[11];
            
            if (acPowered)
                batteryStatus = "交流电充电";
            else if (usbPowered)
                batteryStatus = "USB 端口充电";
            else if (wirelessPowered) 
                batteryStatus = "无线充电";
            else if (dockPowered)
                batteryStatus = "扩展坞或底座充电";
            else
                batteryStatus = "正在放电";

            string maxChargingCurrentMa = $"{double.Parse(maxChargingCurrent) / 1000} mA";
            string maxChargingVoltageV = $"{double.Parse(maxChargingVoltage) / 1000000} V";
            string currentBatteryVoltageMa = $"{double.Parse(voltage) / 1000} mA";
            string currentBatteryTemperature = $"{double.Parse(temperature) / 10} ℃";
            string batteryHealth = health == "0" ? "未知" :
                                   health == "1" ? "极佳" :
                                   health == "2" ? "良好" :
                                   health == "3" ? "普通" :
                                                   "欠压" ;

            gnss_back = gnss_back == "true" ? "开启" : "关闭";
            mobiledata = mobiledata == "true" ? "开启" : "关闭";
            dfcservice = dfcservice == "true" ? "开启" : "关闭";

            RichTextBox.Text =
                  $"设备制造商：{manufacturer}\n"
                + $"设备型号：{model}\n"
                + $"设备代号：{name}\n"
                + $"系统版本号：{incremental}\n"
                + $"安卓版本号：{androidVersion}\n"
                + $"架构：{cpuAbi}\n"
                + $"SDK 版本：{sdk}\n"
                + $"构建日期：{buildDateTimeLocal:yyyy-MM-dd HH:mm:ss} (UTC + 8)\n"
                + $"Android ID：{androidID}\n"
                + $"GNSS 后台优化：{gnss_back}\n"
                + $"移动数据状态：{mobiledata}\n"
                + $"DFC 服务状态：{dfcservice}\n"
                + $"最大分辨率：{physicalSize}"
                + $"当前分辨率：{overrideSize}\n"
                + $"最大屏幕密度：{physicalDensity}"
                + $"当前屏幕密度：{overrideDensity}\n"
                + $"电池状态：{batteryStatus}\n"
                + $"最大充电电流：{maxChargingCurrentMa}\n"
                + $"最大充电电压：{maxChargingVoltageV}\n"
                + $"已充入：{batteryLevel}% ({chargeCounter} mAh)\n"
                + $"当前电池电压：{currentBatteryVoltageMa}\n"
                + $"当前电池温度：{currentBatteryTemperature}\n"
                + $"电池技术：{technology}\n"
                + $"电池健康度：{batteryHealth}\n";
        }

        private async Task<string> ExecuteCommandAsync(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c {command}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            return await Task.Run(() =>
            {
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                return output.Trim();
            });
        }
        private void Output_Button_Click(object sender, EventArgs e)
        {            
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "文本文档 (*.txt)|*.txt",
                Title = "导出设备信息",
            }; 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            { 
                string filePath = saveFileDialog.FileName;
                try
                { 
                    File.WriteAllText(filePath, RichTextBox.Text + $"\n\n导出时间：{nowTime}\n软件版本：{Application.ProductVersion}"); 
                    MessageBox.Show("文件已保存。", "导出设备信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"导出设备信息时出现错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Copy_Button_Click(object sender, EventArgs e)
        {            
            Clipboard.SetText(RichTextBox.Text + $"\n\n导出时间：{nowTime}\n软件版本：{Application.ProductVersion}");
        }
    }
}
