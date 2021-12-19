
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
            this.contextMenu.SuspendLayout();
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
            this.contextMenu.Size = new System.Drawing.Size(179, 76);
            // 
            // addRecordContextMenu
            // 
            this.addRecordContextMenu.Image = global::PAIN_WF_Pojazdy.Properties.Resources.add_record;
            this.addRecordContextMenu.Name = "addRecordContextMenu";
            this.addRecordContextMenu.Size = new System.Drawing.Size(178, 24);
            this.addRecordContextMenu.Text = "Dodaj wpis";
            // 
            // modifyRecordContextMenu
            // 
            this.modifyRecordContextMenu.Image = global::PAIN_WF_Pojazdy.Properties.Resources.modify_record;
            this.modifyRecordContextMenu.Name = "modifyRecordContextMenu";
            this.modifyRecordContextMenu.Size = new System.Drawing.Size(178, 24);
            this.modifyRecordContextMenu.Text = "Modyfikuj wpis";
            // 
            // deleteRecordContextMenu
            // 
            this.deleteRecordContextMenu.Image = global::PAIN_WF_Pojazdy.Properties.Resources.delete_record;
            this.deleteRecordContextMenu.Name = "deleteRecordContextMenu";
            this.deleteRecordContextMenu.Size = new System.Drawing.Size(178, 24);
            this.deleteRecordContextMenu.Text = "Usuń wpis";
            // 
            // VehiclesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.vehiclesList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehiclesView";
            this.Text = "Widok pojazdów";
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}