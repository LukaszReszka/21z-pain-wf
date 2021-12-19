using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PAIN_WF_Pojazdy
{
    public partial class VehicleTypeSwitcher : UserControl
    {

        public delegate void VehicleTypeChanged(VehicleType type);
        public event VehicleTypeChanged VehicleTypeChangedEvent;
        public void TriggerEvent(VehicleType t) => VehicleTypeChangedEvent?.Invoke(t);

        public VehicleTypeSwitcher() : this(VehicleType.Car)
        {

        }

        public VehicleTypeSwitcher(VehicleType type)
        {
            InitializeComponent();
            VehicleType = type;
        }

        [Category("Vehicle Type")]
        [BrowsableAttribute(true)]
        [EditorAttribute(typeof(VehicleTypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public VehicleType VehicleType
        {
            get
            {
                return vehType;
            }

            set
            {
                vehType = value;
                Invalidate();
                if (VehicleType == VehicleType.Car)
                {
                    vehicleTypePicture.Image = Properties.Resources.car;
                }
                else if (VehicleType == VehicleType.Truck)
                {
                    vehicleTypePicture.Image = Properties.Resources.truck;
                }
                else
                {
                    vehicleTypePicture.Image = Properties.Resources.motocycle;
                }
                TriggerEvent(VehicleType);
            }
        }

        private VehicleType vehType;

        private void vehicleTypePicture_MouseDown(object sender, MouseEventArgs e)
        {
            VehicleType = (VehicleType)((((int)VehicleType) + 1) % 3);
        }
    }

    public enum VehicleType
    {
        Car = 0,
        Truck,
        Motocycle
    }

    public class VehicleTypeEditor : UITypeEditor
    {
        public VehicleTypeEditor()
        {

        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService) provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                VehicleTypeSwitcher switcher = new VehicleTypeSwitcher((VehicleType)value);
                edSvc.DropDownControl(switcher);
                return switcher.VehicleType;
            }
            return value;
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return false;
        }
    }
}
