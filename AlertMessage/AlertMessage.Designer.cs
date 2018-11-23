namespace AlertMessage
{
    partial class AlertMessage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.Info;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Cursor = System.Windows.Forms.Cursors.Default;
            this.content.Enabled = false;
            this.content.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.content.ForeColor = System.Drawing.SystemColors.Desktop;
            this.content.Location = new System.Drawing.Point(12, 12);
            this.content.Margin = new System.Windows.Forms.Padding(8);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(850, 200);
            this.content.TabIndex = 0;
            this.content.Text = "None";
            // 
            // AlertMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(878, 225);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AlertMessage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlertMessage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content;

    }
}

