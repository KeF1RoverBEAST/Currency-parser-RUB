namespace Currency_parser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NI_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMS_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.authorSiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NI_icon
            // 
            this.NI_icon.ContextMenuStrip = this.CMS_menu;
            this.NI_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("NI_icon.Icon")));
            this.NI_icon.Visible = true;
            // 
            // CMS_menu
            // 
            this.CMS_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.authorSiteToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.CMS_menu.Name = "contextMenuStrip1";
            this.CMS_menu.Size = new System.Drawing.Size(134, 70);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // authorSiteToolStripMenuItem1
            // 
            this.authorSiteToolStripMenuItem1.Name = "authorSiteToolStripMenuItem1";
            this.authorSiteToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.authorSiteToolStripMenuItem1.Text = "Author Site";
            this.authorSiteToolStripMenuItem1.Click += new System.EventHandler(this.authorSiteToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(147, 108);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Exchange Rates";
            this.CMS_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NI_icon;
        private System.Windows.Forms.ContextMenuStrip CMS_menu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem authorSiteToolStripMenuItem1;
    }
}

