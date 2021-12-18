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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.viewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.addViewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.closeViewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.recordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.addViewButton = new System.Windows.Forms.ToolStripButton();
            this.closeViewButton = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.addRecordButton = new System.Windows.Forms.ToolStripButton();
            this.modifyRecordButton = new System.Windows.Forms.ToolStripButton();
            this.deleteRecordButton = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.filterText = new System.Windows.Forms.ToolStripLabel();
            this.filterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.labelStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordNumberStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.recordOption,
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
            // 
            // closeViewOption
            // 
            this.closeViewOption.Name = "closeViewOption";
            this.closeViewOption.Size = new System.Drawing.Size(180, 24);
            this.closeViewOption.Text = "Zamknij widok";
            // 
            // mdiOption
            // 
            this.mdiOption.Name = "mdiOption";
            this.mdiOption.Size = new System.Drawing.Size(49, 24);
            this.mdiOption.Text = "&MDI";
            // 
            // recordOption
            // 
            this.recordOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordOption,
            this.modifyRecordOption,
            this.deleteRecordOption});
            this.recordOption.Name = "recordOption";
            this.recordOption.Size = new System.Drawing.Size(54, 24);
            this.recordOption.Text = "W&pis";
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
            this.quitProgramOption.Text = "&Zakończ";
            this.quitProgramOption.Click += new System.EventHandler(this.quitProgramOption_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addViewButton,
            this.closeViewButton,
            this.toolBarSeparator,
            this.addRecordButton,
            this.modifyRecordButton,
            this.deleteRecordButton,
            this.toolBarSeparator2,
            this.filterText,
            this.filterComboBox});
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
            // 
            // closeViewButton
            // 
            this.closeViewButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.close_view;
            this.closeViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.Size = new System.Drawing.Size(110, 40);
            this.closeViewButton.Text = "Zamknij widok";
            this.closeViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolBarSeparator
            // 
            this.toolBarSeparator.Name = "toolBarSeparator";
            this.toolBarSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // addRecordButton
            // 
            this.addRecordButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.add_record;
            this.addRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(88, 40);
            this.addRecordButton.Text = "Dodaj wpis";
            this.addRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // modifyRecordButton
            // 
            this.modifyRecordButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.modify_record;
            this.modifyRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifyRecordButton.Name = "modifyRecordButton";
            this.modifyRecordButton.Size = new System.Drawing.Size(113, 40);
            this.modifyRecordButton.Text = "Modyfikuj wpis";
            this.modifyRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.delete_record;
            this.deleteRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(79, 40);
            this.deleteRecordButton.Text = "Usuń wpis";
            this.deleteRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolBarSeparator2
            // 
            this.toolBarSeparator2.Name = "toolBarSeparator2";
            this.toolBarSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // filterText
            // 
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(37, 40);
            this.filterText.Text = "Filtr:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Items.AddRange(new object[] {
            "wszystko",
            "< 100 km/h",
            ">= 100 km/h"});
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 43);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatusBar,
            this.recordNumberStatusBar});
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
            // recordNumberStatusBar
            // 
            this.recordNumberStatusBar.Name = "recordNumberStatusBar";
            this.recordNumberStatusBar.Size = new System.Drawing.Size(17, 20);
            this.recordNumberStatusBar.Text = "0";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainWindow";
            this.Text = "Pojazdy";
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
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem mdiOption;
        private System.Windows.Forms.ToolStripMenuItem recordOption;
        private System.Windows.Forms.ToolStripMenuItem quitProgramOption;
        private System.Windows.Forms.ToolStripMenuItem addViewOption;
        private System.Windows.Forms.ToolStripMenuItem closeViewOption;
        private System.Windows.Forms.ToolStripMenuItem addRecordOption;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordOption;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordOption;
        private System.Windows.Forms.ToolStripButton addViewButton;
        private System.Windows.Forms.ToolStripButton closeViewButton;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator;
        private System.Windows.Forms.ToolStripButton addRecordButton;
        private System.Windows.Forms.ToolStripButton modifyRecordButton;
        private System.Windows.Forms.ToolStripButton deleteRecordButton;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator2;
        private System.Windows.Forms.ToolStripComboBox filterComboBox;
        private System.Windows.Forms.ToolStripLabel filterText;
        private System.Windows.Forms.ToolStripStatusLabel labelStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel recordNumberStatusBar;
    }
}

