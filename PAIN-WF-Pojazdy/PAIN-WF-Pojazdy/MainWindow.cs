﻿using System;
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
    public partial class MainWindow : Form
    {
        public delegate void ModelEvent(Vehicle vehicle);
        public event ModelEvent AddedNewVehicleEvent;
        public event ModelEvent DeletedVehicleEvent;
        public event ModelEvent ModifiedVehicleEvent;
        public void TriggerAddedNewVehicleEvent(Vehicle v) => AddedNewVehicleEvent?.Invoke(v);
        public void TriggerDeletedVehicleEvent(Vehicle v) => DeletedVehicleEvent?.Invoke(v);
        public void TriggerModifiedVehicleEvent(Vehicle v) => ModifiedVehicleEvent?.Invoke(v);

        public List<Vehicle> Model;

        public bool IsClosingEnabled
        {
            get; set;
        }

        public MainWindow()
        {
            InitializeComponent();
            Model = new List<Vehicle>();
            IsClosingEnabled = false;
            addViewButton_Click(null, null);
        }

        private void quitProgramOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addViewButton_Click(object sender, EventArgs e)
        {
            VehiclesView view = new VehiclesView();
            view.MdiParent = this;
            view.FormClosed += new FormClosedEventHandler(this.VehiclesView_FormClosed);
            AddedNewVehicleEvent += view.HandleAddedNewVehicleEvent;
            DeletedVehicleEvent += view.HandleDeletedVehicleEvent;
            ModifiedVehicleEvent += view.HandleModifiedVehicleEvent;
            view.SetFilter();
            view.Show();

            if (this.MdiChildren.Length > 1)
            {
                closeViewButton.Enabled = true;
                closeViewOption.Enabled = true;
                IsClosingEnabled = true;
            }
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            Form activeView = this.ActiveMdiChild;
            if (activeView != null)
                activeView.Close();
            else
                throw new Exception("Error - no child windows present!");

            if (this.MdiChildren.Length <= 1)
            {
                closeViewButton.Enabled = false;
                closeViewOption.Enabled = false;
                IsClosingEnabled = false;
            }
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsClosingEnabled)
            {
                IsClosingEnabled = true;
                this.Close();
            }
        }

        private void VehiclesView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiChildren.Length <= 2)       //2, bo vehicle view jeszcze nie zamknięty (przed wywołaniem Dispose())
            {
                closeViewButton.Enabled = false;
                closeViewOption.Enabled = false;
                IsClosingEnabled = false;
            }
        }
    }
}
