
namespace PAIN_WF_Pojazdy
{
    partial class VehicleTypeSwitcher
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.vehicleTypePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleTypePicture
            // 
            this.vehicleTypePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypePicture.Location = new System.Drawing.Point(0, 0);
            this.vehicleTypePicture.MaximumSize = new System.Drawing.Size(96, 96);
            this.vehicleTypePicture.MinimumSize = new System.Drawing.Size(96, 96);
            this.vehicleTypePicture.Name = "vehicleTypePicture";
            this.vehicleTypePicture.Size = new System.Drawing.Size(96, 96);
            this.vehicleTypePicture.TabIndex = 0;
            this.vehicleTypePicture.TabStop = false;
            this.vehicleTypePicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vehicleTypePicture_MouseDown);
            // 
            // VehicleTypeSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.vehicleTypePicture);
            this.MaximumSize = new System.Drawing.Size(96, 96);
            this.MinimumSize = new System.Drawing.Size(96, 96);
            this.Name = "VehicleTypeSwitcher";
            this.Size = new System.Drawing.Size(94, 94);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vehicleTypePicture;
    }
}
