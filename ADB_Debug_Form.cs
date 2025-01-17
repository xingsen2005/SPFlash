using System;
using System.Windows.Forms;
namespace SPFlash
{
    public partial class ADB_Debug_Form : Form
    {
        readonly string NowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public ADB_Debug_Form()
        {
            InitializeComponent();
        }

        private void ADB_Debug_Form_Load(object sender, EventArgs e)
        {           
            if (string.IsNullOrEmpty(USB_Debug_RichTextBox.Text) || string.IsNullOrEmpty(WiFi_Debug_Rich_TextBox.Text))
            {
                USB_Debug_RichTextBox.Text = "[" + NowTime + "] " + Application.ProductName + "：USB 调试";
                WiFi_Debug_Rich_TextBox.Text = "[" + NowTime + "] " + Application.ProductName + "：无线调试";
            }
        }
    }
}
