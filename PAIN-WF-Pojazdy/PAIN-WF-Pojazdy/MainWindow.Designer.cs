namespace PAIN_WF_Pojazdy
{
    partial class mainWindow
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.viewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.addViewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteViewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.recordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOption,
            this.mdiOption,
            this.recordOption,
            this.quitProgramOption});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(886, 28);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuBar";
            // 
            // viewOption
            // 
            this.viewOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addViewOption,
            this.deleteViewOption});
            this.viewOption.Name = "viewOption";
            this.viewOption.Size = new System.Drawing.Size(64, 24);
            this.viewOption.Text = "Widok";
            // 
            // addViewOption
            // 
            this.addViewOption.Name = "addViewOption";
            this.addViewOption.Size = new System.Drawing.Size(180, 24);
            this.addViewOption.Text = "Dodaj widok";
            // 
            // deleteViewOption
            // 
            this.deleteViewOption.Name = "deleteViewOption";
            this.deleteViewOption.Size = new System.Drawing.Size(180, 24);
            this.deleteViewOption.Text = "Usuń widok";
            // 
            // mdiOption
            // 
            this.mdiOption.Name = "mdiOption";
            this.mdiOption.Size = new System.Drawing.Size(49, 24);
            this.mdiOption.Text = "MDI";
            // 
            // recordOption
            // 
            this.recordOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordOption,
            this.modifyRecordOption,
            this.deleteRecordOption});
            this.recordOption.Name = "recordOption";
            this.recordOption.Size = new System.Drawing.Size(54, 24);
            this.recordOption.Text = "Wpis";
            // 
            // addRecordOption
            // 
            this.addRecordOption.Name = "addRecordOption";
            this.addRecordOption.Size = new System.Drawing.Size(178, 24);
            this.addRecordOption.Text = "Dodaj wpis";
            // 
            // modifyRecordOption
            // 
            this.modifyRecordOption.Name = "modifyRecordOption";
            this.modifyRecordOption.Size = new System.Drawing.Size(178, 24);
            this.modifyRecordOption.Text = "Modyfikuj wpis";
            // 
            // deleteRecordOption
            // 
            this.deleteRecordOption.Name = "deleteRecordOption";
            this.deleteRecordOption.Size = new System.Drawing.Size(178, 24);
            this.deleteRecordOption.Text = "Usuń wpis";
            // 
            // quitProgramOption
            // 
            this.quitProgramOption.Name = "quitProgramOption";
            this.quitProgramOption.Size = new System.Drawing.Size(76, 24);
            this.quitProgramOption.Text = "Zakończ";
            this.quitProgramOption.Click += new System.EventHandler(this.quitProgramOption_Click);
            // 
            // toolBar
            // 
            this.toolBar.Location = new System.Drawing.Point(0, 28);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(886, 25);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolBar";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 492);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(886, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusBar";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 514);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.IsMdiContainer = true;
            this.Name = "mainWindow";
            this.Text = "Pojazdy";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem viewOption;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem mdiOption;
        private System.Windows.Forms.ToolStripMenuItem recordOption;
        private System.Windows.Forms.ToolStripMenuItem quitProgramOption;
        private System.Windows.Forms.ToolStripMenuItem addViewOption;
        private System.Windows.Forms.ToolStripMenuItem deleteViewOption;
        private System.Windows.Forms.ToolStripMenuItem addRecordOption;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordOption;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordOption;
    }
}

