namespace PAIN_WF_Pojazdy
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.viewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.addViewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.closeViewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.addViewButton = new System.Windows.Forms.ToolStripButton();
            this.closeViewButton = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.labelStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOption,
            this.mdiOption,
            this.quitProgramOption});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.MdiWindowListItem = this.mdiOption;
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 28);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuBar";
            // 
            // viewOption
            // 
            this.viewOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addViewOption,
            this.closeViewOption});
            this.viewOption.Name = "viewOption";
            this.viewOption.Size = new System.Drawing.Size(64, 24);
            this.viewOption.Text = "&Widok";
            // 
            // addViewOption
            // 
            this.addViewOption.Name = "addViewOption";
            this.addViewOption.Size = new System.Drawing.Size(180, 24);
            this.addViewOption.Text = "Dodaj widok";
            this.addViewOption.Click += new System.EventHandler(this.addViewButton_Click);
            // 
            // closeViewOption
            // 
            this.closeViewOption.Enabled = false;
            this.closeViewOption.Name = "closeViewOption";
            this.closeViewOption.Size = new System.Drawing.Size(180, 24);
            this.closeViewOption.Text = "Zamknij widok";
            this.closeViewOption.Click += new System.EventHandler(this.closeViewButton_Click);
            // 
            // mdiOption
            // 
            this.mdiOption.Name = "mdiOption";
            this.mdiOption.Size = new System.Drawing.Size(49, 24);
            this.mdiOption.Text = "&MDI";
            // 
            // quitProgramOption
            // 
            this.quitProgramOption.Name = "quitProgramOption";
            this.quitProgramOption.Size = new System.Drawing.Size(76, 24);
            this.quitProgramOption.Text = "&Zakończ";
            this.quitProgramOption.Click += new System.EventHandler(this.quitProgramOption_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addViewButton,
            this.closeViewButton,
            this.toolBarSeparator});
            this.toolBar.Location = new System.Drawing.Point(0, 28);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(784, 43);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolBar";
            // 
            // addViewButton
            // 
            this.addViewButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.add_view;
            this.addViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addViewButton.Name = "addViewButton";
            this.addViewButton.Size = new System.Drawing.Size(98, 40);
            this.addViewButton.Text = "Dodaj widok";
            this.addViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addViewButton.Click += new System.EventHandler(this.addViewButton_Click);
            // 
            // closeViewButton
            // 
            this.closeViewButton.Enabled = false;
            this.closeViewButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.close_view;
            this.closeViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.Size = new System.Drawing.Size(110, 40);
            this.closeViewButton.Text = "Zamknij widok";
            this.closeViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeViewButton.Click += new System.EventHandler(this.closeViewButton_Click);
            // 
            // toolBarSeparator
            // 
            this.toolBarSeparator.Name = "toolBarSeparator";
            this.toolBarSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatusBar});
            this.statusBar.Location = new System.Drawing.Point(0, 636);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 25);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusBar";
            // 
            // labelStatusBar
            // 
            this.labelStatusBar.Name = "labelStatusBar";
            this.labelStatusBar.Size = new System.Drawing.Size(108, 20);
            this.labelStatusBar.Text = "Liczba wpisów:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainWindow";
            this.Text = "Pojazdy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem viewOption;
        private System.Windows.Forms.ToolStripMenuItem mdiOption;
        private System.Windows.Forms.ToolStripMenuItem quitProgramOption;
        private System.Windows.Forms.ToolStripMenuItem addViewOption;
        private System.Windows.Forms.ToolStripMenuItem closeViewOption;
        private System.Windows.Forms.ToolStripButton addViewButton;
        private System.Windows.Forms.ToolStripButton closeViewButton;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator;
        private System.Windows.Forms.ToolStripStatusLabel labelStatusBar;
        public System.Windows.Forms.ToolStrip toolBar;
        public System.Windows.Forms.StatusStrip statusBar;
    }
}

