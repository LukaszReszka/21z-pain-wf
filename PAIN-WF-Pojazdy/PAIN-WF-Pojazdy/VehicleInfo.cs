using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_WF_Pojazdy
{

    public partial class VehicleInfo : Form
    {

        public const ulong MAX_SPEED_LIMIT = 400;

        public string vehicleBrad
        {
            get
            {
                return carBrandTextBox.Text.Trim(' ');
            }
        }

        public ulong maxVelocity
        {
            get
            {
                return ulong.Parse(maxVelocityTextBox.Text);
            }
        }

        public DateTime productionDate
        {
            get
            {
                return productionDatePicker.Value;
            }
        }

        public string vehicleType
        {
            get
            {
                return vehicleTypeTextBox.Text;
            }
        }


        public VehicleInfo()
        {
            InitializeComponent();
            vehicleTypeSwitcher_VehicleTypeChangedEvent(vehicleTypeSwitcher.VehicleType);
        }

        public VehicleInfo (Vehicle vehicle)
        {
            InitializeComponent();
            vehicleTypeSwitcher_VehicleTypeChangedEvent(vehicleTypeSwitcher.VehicleType);
            carBrandTextBox.Text = vehicle.Brand;
            maxVelocityTextBox.Text = vehicle.maxVelocity.ToString();
            productionDatePicker.Value = vehicle.productionDate;
            if (vehicle.Type == "osobowy")
            {
                vehicleTypeSwitcher.VehicleType = VehicleType.Car;
            }
            else if (vehicle.Type == "ciężarowy")
            {
                vehicleTypeSwitcher.VehicleType = VehicleType.Truck;
            }
            else if (vehicle.Type == "jednoślad")
            {
                vehicleTypeSwitcher.VehicleType = VehicleType.Motocycle;
            }
            else
                throw new Exception("Inapprioprate vehicle type !!!");
        }

        private void vehicleTypeSwitcher_VehicleTypeChangedEvent(VehicleType type)
        {
            if(type == VehicleType.Car)
            {
                vehicleTypeTextBox.Text = "osobowy";
            }
            else if (type == VehicleType.Truck)
            {
                vehicleTypeTextBox.Text = "ciężarowy";
            }
            else
            {
                vehicleTypeTextBox.Text = "jednoślad";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void maxVelocityTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ulong velocity = ulong.Parse(maxVelocityTextBox.Text);
                if (velocity > MAX_SPEED_LIMIT || velocity == 0)
                    throw new Exception("Velocity not from proper range!!!");
            }
            catch
            {
                e.Cancel = true;
                errorProvider.SetError(maxVelocityTextBox, "Wymagana liczba z przedziału 1-400.");
            }
        }

        private void maxVelocityTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(maxVelocityTextBox, "");
        }

        private void carBrandTextBox_Validating(object sender, CancelEventArgs e)
        {
            foreach(char c in carBrandTextBox.Text)
            {
                if(!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == ' '))
                {
                    e.Cancel = true;
                    errorProvider.SetError(carBrandTextBox, "Wymagany tekst złożony wyłącznie z liter A-Za-z i spacji.");
                    break;
                }
            }

            string trimmed_text = carBrandTextBox.Text.Trim(' ');
            if (trimmed_text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(carBrandTextBox, "To pole nie może być puste.");
            }
        }

        private void carBrandTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(carBrandTextBox, "");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
                DialogResult = DialogResult.OK;
        }
    }
}
