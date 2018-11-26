using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertMessage
{
    public partial class AlertMessage : Form
    {
        string[] args;
        public AlertMessage(string[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private void AlertMessage_Load(object sender, EventArgs e)
        {
            string originStr = string.Join(" ", args);
            this.content.Text = StrGBKToUTF8(originStr);
        }

        private void AlertMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
        }

        private string StrGBKToUTF8(string originStr)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("GBK").GetBytes(originStr);
            string targetStr = Encoding.UTF8.GetString(bytes);
            return targetStr;
        }

        private string StrUTF8ToGBK(string originStr)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(originStr);
            string targetStr = Encoding.GetEncoding("GBK").GetString(bytes);
            return targetStr;
        }

    }
}
