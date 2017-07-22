namespace CopyHistory
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CopyHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(21, 29);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(795, 260);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coded by Onurgule";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.CopyHistory;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // CopyHistory
            // 
            this.CopyHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CopyHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Hide,
            this.Close});
            this.CopyHistory.Name = "CopyHistory";
            this.CopyHistory.Size = new System.Drawing.Size(176, 104);
            // 
            // Open
            // 
            this.Open.AccessibleName = "tOpen";
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(175, 24);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Hide
            // 
            this.Hide.AccessibleName = "tHide";
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(175, 24);
            this.Hide.Text = "Hide";
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Close
            // 
            this.Close.AccessibleName = "tClose";
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(175, 24);
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CopyHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip CopyHistory;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Hide;
        private System.Windows.Forms.ToolStripMenuItem Close;
    }
}

