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
    public enum FilterIndex {
        AllRecords = 0,
        LessThan100,
        MoreEqual100

    }
    public partial class VehiclesView : Form
    {
        public VehiclesView()
        {
            InitializeComponent();
            vehiclesList_SelectedIndexChanged(null, null);
        }

        public void SetFilter(FilterIndex index = FilterIndex.AllRecords)
        {
            parent = (MainWindow)this.MdiParent;
            filterComboBox.SelectedIndex = (int)index;
        }

        public void HandleAddedNewVehicleEvent(Vehicle newVehicle)
        {
            if (currentFilter == FilterIndex.AllRecords
                || (currentFilter == FilterIndex.LessThan100 && newVehicle.maxVelocity < 100)
                || (currentFilter == FilterIndex.MoreEqual100 && newVehicle.maxVelocity >= 100))
            {
                AddVehicleToList(newVehicle);
                recordCounter.Text = vehiclesList.Items.Count.ToString();
            }
        }

        public void HandleDeletedVehicleEvent(Vehicle deletedVehicle)
        {
            foreach (ListViewItem item in vehiclesList.Items)
            {
                if(Object.ReferenceEquals(item.Tag, deletedVehicle))
                {
                    vehiclesList.Items.Remove(item);
                    break;
                }
            }
            recordCounter.Text = vehiclesList.Items.Count.ToString();
        }

        public void HandleModifiedVehicleEvent(Vehicle modifiedVehicle)
        {
            for(int i = 0; i < vehiclesList.Items.Count; ++i)
            {
                if (Object.ReferenceEquals(vehiclesList.Items[i].Tag, modifiedVehicle))
                {
                    vehiclesList.Items.RemoveAt(i);
                    string[] row = { modifiedVehicle.Brand, modifiedVehicle.maxVelocity.ToString(), 
                        modifiedVehicle.productionDate.ToString("d"), modifiedVehicle.Type };
                    var listViewItem = new ListViewItem(row);
                    listViewItem.Tag = modifiedVehicle;
                    vehiclesList.Items.Insert(i, listViewItem);
                    break;
                }
            }
        }

        private void VehiclesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !parent.IsClosingEnabled;
        }

        private void VehiclesView_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(this.toolBar, parent.toolBar);
            ToolStripManager.Merge(this.statusBar, parent.statusBar);
        }

        private void VehiclesView_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(parent.toolBar, this.toolBar);
            ToolStripManager.RevertMerge(parent.statusBar, this.statusBar);
        }

        private void vehiclesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehiclesList.SelectedIndices.Count == 0)
            {
                SetModifyRecordAvaiability(false);
                SetDeleteRecordAvaiability(false);
            }
            else if (vehiclesList.SelectedIndices.Count >= 1)
            {
                SetDeleteRecordAvaiability(true);
                SetModifyRecordAvaiability(vehiclesList.SelectedIndices.Count == 1);
            }
        }

        private void SetModifyRecordAvaiability (bool isAvaiable)
        {
            modifyRecordButton.Enabled = isAvaiable;
            modifyRecordContextMenu.Enabled = isAvaiable;
            modifyRecordOption.Enabled = isAvaiable;
        }

        private void SetDeleteRecordAvaiability(bool isAvaiable)
        {
            deleteRecordButton.Enabled = isAvaiable;
            deleteRecordContextMenu.Enabled = isAvaiable;
            deleteRecordOption.Enabled = isAvaiable;
        }

        private void AddVehicleToList(Vehicle vehicle)
        {
            string[] row = { vehicle.Brand, vehicle.maxVelocity.ToString(), vehicle.productionDate.ToString("d"), vehicle.Type};
            var listViewItem = new ListViewItem(row);
            listViewItem.Tag = vehicle;
            vehiclesList.Items.Add(listViewItem);
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFilter = (FilterIndex)filterComboBox.SelectedIndex;
            vehiclesList.Items.Clear();
            if (currentFilter == FilterIndex.LessThan100)
            {
                foreach (Vehicle vehicle in parent.Model)
                {
                    if (vehicle.maxVelocity < 100)
                        AddVehicleToList(vehicle);
                }

            }
            else if (currentFilter == FilterIndex.MoreEqual100)
            {
                foreach (Vehicle vehicle in parent.Model)
                {
                    if (vehicle.maxVelocity >= 100)
                        AddVehicleToList(vehicle);
                }
            }
            else
            {
                foreach (Vehicle vehicle in parent.Model)
                    AddVehicleToList(vehicle);
            }

            recordCounter.Text = vehiclesList.Items.Count.ToString();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            VehicleInfo dialog = new VehicleInfo();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Vehicle newVehicle = new Vehicle();
                newVehicle.Brand = dialog.vehicleBrad;
                newVehicle.maxVelocity = dialog.maxVelocity;
                newVehicle.productionDate = dialog.productionDate;
                newVehicle.Type = dialog.vehicleType;
                parent.Model.Add(newVehicle);
                parent.TriggerAddedNewVehicleEvent(newVehicle);
            }
        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Usunąć wszystkie zaznaczone pojazdy?", "Potwierdzenie operacji usuwania",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                foreach(ListViewItem item in vehiclesList.SelectedItems)
                {
                    parent.Model.Remove((Vehicle) item.Tag);
                    parent.TriggerDeletedVehicleEvent((Vehicle)item.Tag);
                }
            }
        }

        private void modifyRecordButton_Click(object sender, EventArgs e)
        {
            Vehicle modifiedVehicle = (Vehicle) vehiclesList.SelectedItems[0].Tag;
            VehicleInfo dialog = new VehicleInfo(modifiedVehicle);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(modifiedVehicle.Brand != dialog.vehicleBrad || modifiedVehicle.maxVelocity != dialog.maxVelocity
                    || modifiedVehicle.productionDate != dialog.productionDate || modifiedVehicle.Type != dialog.vehicleType)
                {
                    modifiedVehicle.Brand = dialog.vehicleBrad;
                    modifiedVehicle.maxVelocity = dialog.maxVelocity;
                    modifiedVehicle.productionDate = dialog.productionDate;
                    modifiedVehicle.Type = dialog.vehicleType;
                    parent.TriggerModifiedVehicleEvent(modifiedVehicle);
                }
            }
        }

        private MainWindow parent;
        private FilterIndex currentFilter;
    }
}
