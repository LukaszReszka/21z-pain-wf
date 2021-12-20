
namespace PAIN_WF_Pojazdy
{
    partial class VehicleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleInfo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.maxVelocityLabel = new System.Windows.Forms.Label();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.productionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.maxVelocityTextBox = new System.Windows.Forms.TextBox();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeSwitcher = new PAIN_WF_Pojazdy.VehicleTypeSwitcher();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(454, 261);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.vehicleTypeSwitcher);
            this.splitContainer2.Size = new System.Drawing.Size(454, 200);
            this.splitContainer2.SplitterDistance = 339;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.carBrandLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maxVelocityLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productionDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.carTypeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.productionDatePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.vehicleTypeTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maxVelocityTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.carBrandTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // carBrandLabel
            // 
            this.carBrandLabel.AutoSize = true;
            this.carBrandLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.carBrandLabel.Location = new System.Drawing.Point(58, 0);
            this.carBrandLabel.Name = "carBrandLabel";
            this.carBrandLabel.Size = new System.Drawing.Size(40, 50);
            this.carBrandLabel.TabIndex = 0;
            this.carBrandLabel.Text = "Marka:";
            this.carBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxVelocityLabel
            // 
            this.maxVelocityLabel.AutoSize = true;
            this.maxVelocityLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxVelocityLabel.Location = new System.Drawing.Point(28, 50);
            this.maxVelocityLabel.Name = "maxVelocityLabel";
            this.maxVelocityLabel.Size = new System.Drawing.Size(70, 50);
            this.maxVelocityLabel.TabIndex = 1;
            this.maxVelocityLabel.Text = "Vmax [km/h]:";
            this.maxVelocityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.productionDateLabel.Location = new System.Drawing.Point(19, 100);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(79, 50);
            this.productionDateLabel.TabIndex = 2;
            this.productionDateLabel.Text = "Data produkcji:";
            this.productionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.carTypeLabel.Location = new System.Drawing.Point(30, 150);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(68, 50);
            this.carTypeLabel.TabIndex = 3;
            this.carTypeLabel.Text = "Typ pojazdu:";
            this.carTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productionDatePicker
            // 
            this.productionDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productionDatePicker.Location = new System.Drawing.Point(104, 115);
            this.productionDatePicker.Name = "productionDatePicker";
            this.productionDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productionDatePicker.Size = new System.Drawing.Size(210, 20);
            this.productionDatePicker.TabIndex = 4;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(104, 165);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.ReadOnly = true;
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(210, 20);
            this.vehicleTypeTextBox.TabIndex = 5;
            // 
            // maxVelocityTextBox
            // 
            this.maxVelocityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxVelocityTextBox.Location = new System.Drawing.Point(104, 65);
            this.maxVelocityTextBox.Name = "maxVelocityTextBox";
            this.maxVelocityTextBox.Size = new System.Drawing.Size(210, 20);
            this.maxVelocityTextBox.TabIndex = 6;
            this.maxVelocityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.maxVelocityTextBox_Validating);
            this.maxVelocityTextBox.Validated += new System.EventHandler(this.maxVelocityTextBox_Validated);
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.carBrandTextBox.Location = new System.Drawing.Point(104, 15);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(210, 20);
            this.carBrandTextBox.TabIndex = 7;
            this.carBrandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.carBrandTextBox_Validating);
            this.carBrandTextBox.Validated += new System.EventHandler(this.carBrandTextBox_Validated);
            // 
            // vehicleTypeSwitcher
            // 
            this.vehicleTypeSwitcher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleTypeSwitcher.BackColor = System.Drawing.Color.White;
            this.vehicleTypeSwitcher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleTypeSwitcher.Location = new System.Drawing.Point(7, 52);
            this.vehicleTypeSwitcher.MaximumSize = new System.Drawing.Size(96, 96);
            this.vehicleTypeSwitcher.MinimumSize = new System.Drawing.Size(96, 96);
            this.vehicleTypeSwitcher.Name = "vehicleTypeSwitcher";
            this.vehicleTypeSwitcher.Size = new System.Drawing.Size(96, 96);
            this.vehicleTypeSwitcher.TabIndex = 0;
            this.vehicleTypeSwitcher.VehicleType = PAIN_WF_Pojazdy.VehicleType.Car;
            this.vehicleTypeSwitcher.VehicleTypeChangedEvent += new PAIN_WF_Pojazdy.VehicleTypeSwitcher.VehicleTypeChanged(this.vehicleTypeSwitcher_VehicleTypeChangedEvent);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(89, 17);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(286, 17);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // VehicleInfo
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 300);
            this.Name = "VehicleInfo";
            this.Text = "Informacje o pojeździe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehicleInfo_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private VehicleTypeSwitcher vehicleTypeSwitcher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label carBrandLabel;
        private System.Windows.Forms.Label maxVelocityLabel;
        private System.Windows.Forms.Label productionDateLabel;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.DateTimePicker productionDatePicker;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.TextBox maxVelocityTextBox;
        private System.Windows.Forms.TextBox carBrandTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}