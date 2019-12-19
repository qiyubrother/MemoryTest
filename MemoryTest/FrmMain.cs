using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryTest
{
    // Any CPU | 首选32位
    // x86
    public partial class FrmMain : Form
    {
        Process p = null;
        List<int[]> lst = new List<int[]>(102400);
        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            p = Process.GetCurrentProcess();

            txtMemoryAllowed.Text = FormatSize(p.PrivateMemorySize64);
            txtAllowVirtualMemorySize64.Text = FormatSize(p.VirtualMemorySize64);
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            btnBegin.Visible = false;
            while (true)
            {
                try
                {
                    var arr = new int[102400]; /* 400K */
                    for (var i = 0; i < arr.Length; i++)
                    {
                        arr[i] = i * 2;
                    }
                    lst.Add(arr);
                    p = Process.GetCurrentProcess();
                    txtMemoryAllowed.Text = FormatSize(p.PrivateMemorySize64);
                    txtAllowVirtualMemorySize64.Text = FormatSize(p.VirtualMemorySize64);
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtMemoryAllowed.Text = FormatSize(p.PrivateMemorySize64);
                    txtAllowVirtualMemorySize64.Text = FormatSize(p.VirtualMemorySize64);
                    break;
                }
                finally
                {
                    btnBegin.Visible = true;
                }
            }

        }

        const string B = "B";
        const string KB = "KB";
        const string MB = "MB";
        const string GB = "GB";
        const string TB = "TB";
        string unit = string.Empty;
        /// <summary>
        /// 格式化尺寸
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        private string FormatSize(long size)
        {
            var rtnValue = string.Empty;
            unit = B;
            double sz = size;
            if (sz >= 1024)
            {
                sz = sz / 1024;
                unit = KB;
            }
            if (sz >= 1024)
            {
                sz = sz / 1024;
                unit = MB;
            }
            if (sz >= 1024)
            {
                sz = sz / 1024;
                unit = GB;
            }
            if (sz >= 1024)
            {
                sz = sz / 1024;
                unit = TB;
            }
            rtnValue = $"{sz.ToString("f2")} {unit}";

            return rtnValue;
        }
    }
}
