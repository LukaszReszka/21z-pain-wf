
namespace PAIN_WF_Pojazdy
{
    partial class VehiclesView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesView));
            this.vehiclesList = new System.Windows.Forms.ListView();
            this.vehicleBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRecordContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.recordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.addRecordButton = new System.Windows.Forms.ToolStripButton();
            this.modifyRecordButton = new System.Windows.Forms.ToolStripButton();
            this.deleteRecordButton = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.filterText = new System.Windows.Forms.ToolStripLabel();
            this.filterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.recordCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesList
            // 
            this.vehiclesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vehicleBrand,
            this.maxVelocity,
            this.productionDate,
            this.vehicleType});
            this.vehiclesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiclesList.HideSelection = false;
            this.vehiclesList.Location = new System.Drawing.Point(0, 0);
            this.vehiclesList.Name = "vehiclesList";
            this.vehiclesList.Size = new System.Drawing.Size(484, 361);
            this.vehiclesList.TabIndex = 0;
            this.vehiclesList.UseCompatibleStateImageBehavior = false;
            this.vehiclesList.View = System.Windows.Forms.View.Details;
            this.vehiclesList.SelectedIndexChanged += new System.EventHandler(this.vehiclesList_SelectedIndexChanged);
            // 
            // vehicleBrand
            // 
            this.vehicleBrand.Text = "Marka";
            this.vehicleBrand.Width = 120;
            // 
            // maxVelocity
            // 
            this.maxVelocity.Text = "Vmax [km/h]";
            this.maxVelocity.Width = 120;
            // 
            // productionDate
            // 
            this.productionDate.Text = "Data produkcji";
            this.productionDate.Width = 120;
            // 
            // vehicleType
            // 
            this.vehicleType.Text = "Typ pojazdu";
            this.vehicleType.Width = 120;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordContextMenu,
            this.modifyRecordContextMenu,
            this.deleteRecordContextMenu});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 98);
            // 
            // addRecordContextMenu
            // 
            this.addRecordContextMenu.Image = global::PAIN_WF_Pojazdy.Properties.Resources.add_record;
            this.addRecordContextMenu.Name = "addRecordContextMenu";
            this.addRecordContextMenu.Size = new System.Drawing.Size(180, 24);
            this.addRecordContextMenu.Text = "Dodaj wpis";
            this.addRecordContextMenu.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // modifyRecordContextMenu
            // 
            this.modifyRecordContextMenu.Image = global::PAIN_WF_Pojazdy.Properties.Resources.modify_record;
            this.modifyRecordContextMenu.Name = "modifyRecordContextMenu";
            this.modifyRecordContextMenu.Size = new System.Drawing.Size(180, 24);
            this.modifyRecordContextMenu.Text = "Modyfikuj wpis";
            this.modifyRecordContextMenu.Click += new System.EventHandler(this.modifyRecordButton_Click);
            // 
            // deleteRecordContextMenu
            // 
            this.deleteRecordContextMenu.Image = global::PAIN_WF_Pojazdy.Properties.Resources.delete_record;
            this.deleteRecordContextMenu.Name = "deleteRecordContextMenu";
            this.deleteRecordContextMenu.Size = new System.Drawing.Size(180, 24);
            this.deleteRecordContextMenu.Text = "Usuń wpis";
            this.deleteRecordContextMenu.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordOption});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(484, 28);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuBar";
            this.menuBar.Visible = false;
            // 
            // recordOption
            // 
            this.recordOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordOption,
            this.modifyRecordOption,
            this.deleteRecordOption});
            this.recordOption.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.recordOption.MergeIndex = 2;
            this.recordOption.Name = "recordOption";
            this.recordOption.Size = new System.Drawing.Size(54, 24);
            this.recordOption.Text = "W&pis";
            // 
            // addRecordOption
            // 
            this.addRecordOption.Image = global::PAIN_WF_Pojazdy.Properties.Resources.add_record;
            this.addRecordOption.Name = "addRecordOption";
            this.addRecordOption.Size = new System.Drawing.Size(180, 24);
            this.addRecordOption.Text = "Dodaj wpis";
            this.addRecordOption.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // modifyRecordOption
            // 
            this.modifyRecordOption.Image = global::PAIN_WF_Pojazdy.Properties.Resources.modify_record;
            this.modifyRecordOption.Name = "modifyRecordOption";
            this.modifyRecordOption.Size = new System.Drawing.Size(180, 24);
            this.modifyRecordOption.Text = "Modyfikuj wpis";
            this.modifyRecordOption.Click += new System.EventHandler(this.modifyRecordButton_Click);
            // 
            // deleteRecordOption
            // 
            this.deleteRecordOption.Image = global::PAIN_WF_Pojazdy.Properties.Resources.delete_record;
            this.deleteRecordOption.Name = "deleteRecordOption";
            this.deleteRecordOption.Size = new System.Drawing.Size(180, 24);
            this.deleteRecordOption.Text = "Usuń wpis";
            this.deleteRecordOption.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordButton,
            this.modifyRecordButton,
            this.deleteRecordButton,
            this.toolBarSeparator,
            this.filterText,
            this.filterComboBox});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(484, 43);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolStrip1";
            this.toolBar.Visible = false;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.add_record;
            this.addRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(88, 40);
            this.addRecordButton.Text = "Dodaj wpis";
            this.addRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // modifyRecordButton
            // 
            this.modifyRecordButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.modify_record;
            this.modifyRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifyRecordButton.Name = "modifyRecordButton";
            this.modifyRecordButton.Size = new System.Drawing.Size(113, 40);
            this.modifyRecordButton.Text = "Modyfikuj wpis";
            this.modifyRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.modifyRecordButton.Click += new System.EventHandler(this.modifyRecordButton_Click);
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Image = global::PAIN_WF_Pojazdy.Properties.Resources.delete_record;
            this.deleteRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(79, 40);
            this.deleteRecordButton.Text = "Usuń wpis";
            this.deleteRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteRecordButton.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // toolBarSeparator
            // 
            this.toolBarSeparator.Name = "toolBarSeparator";
            this.toolBarSeparator.Size = new System.Drawing.Size(6, 43);
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
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordCounter});
            this.statusBar.Location = new System.Drawing.Point(0, 336);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(484, 25);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            this.statusBar.Visible = false;
            // 
            // recordCounter
            // 
            this.recordCounter.Name = "recordCounter";
            this.recordCounter.Size = new System.Drawing.Size(17, 20);
            this.recordCounter.Text = "0";
            // 
            // VehiclesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.vehiclesList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehiclesView";
            this.Text = "Widok pojazdów";
            this.Activated += new System.EventHandler(this.VehiclesView_Activated);
            this.Deactivate += new System.EventHandler(this.VehiclesView_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehiclesView_FormClosing);
            this.contextMenu.ResumeLayout(false);
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

        private System.Windows.Forms.ListView vehiclesList;
        private System.Windows.Forms.ColumnHeader vehicleBrand;
        private System.Windows.Forms.ColumnHeader maxVelocity;
        private System.Windows.Forms.ColumnHeader productionDate;
        private System.Windows.Forms.ColumnHeader vehicleType;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addRecordContextMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordContextMenu;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem recordOption;
        private System.Windows.Forms.ToolStripMenuItem addRecordOption;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordOption;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordOption;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton addRecordButton;
        private System.Windows.Forms.ToolStripButton modifyRecordButton;
        private System.Windows.Forms.ToolStripButton deleteRecordButton;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator;
        private System.Windows.Forms.ToolStripLabel filterText;
        private System.Windows.Forms.ToolStripComboBox filterComboBox;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel recordCounter;
    }
}