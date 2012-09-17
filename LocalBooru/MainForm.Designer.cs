namespace LocalBooru
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripItem,
            this.exportToolStripItem,
            this.importToolStripItem,
            this.toolStripSeparator1,
            this.closeToolStripItem,
            this.quitToolStripItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripItem
            // 
            this.openToolStripItem.Name = "openToolStripItem";
            this.openToolStripItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripItem.Text = "&Open Booru";
            // 
            // exportToolStripItem
            // 
            this.exportToolStripItem.Name = "exportToolStripItem";
            this.exportToolStripItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripItem.Text = "&Export Booru";
            // 
            // importToolStripItem
            // 
            this.importToolStripItem.Name = "importToolStripItem";
            this.importToolStripItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripItem.Text = "&Import Booru";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // closeToolStripItem
            // 
            this.closeToolStripItem.Name = "closeToolStripItem";
            this.closeToolStripItem.ShortcutKeyDisplayString = "Alt+F4";
            this.closeToolStripItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripItem.Text = "&Close";
            // 
            // quitToolStripItem
            // 
            this.quitToolStripItem.Name = "quitToolStripItem";
            this.quitToolStripItem.ShortcutKeyDisplayString = "Alt+Q";
            this.quitToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitToolStripItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripItem.Text = "&Quit";
            this.quitToolStripItem.Click += new System.EventHandler(this.quitToolStripItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "LocalBooru";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripItem;
    }
}

