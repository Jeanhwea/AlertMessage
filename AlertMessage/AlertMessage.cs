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
            this.content.Text = string.Join(" ", args);
        }


        private void AlertMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
        }
    }
}
