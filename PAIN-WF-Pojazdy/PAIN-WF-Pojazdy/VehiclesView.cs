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

        //public delegate void SetCurrentFilter(FilterIndex index);
        //public event SetCurrentFilter SetCurrentFilterEvent;
        //public void TriggerSetCurrentFilterEvent(FilterIndex i) => SetCurrentFilterEvent?.Invoke(i);

        public VehiclesView()
        {
            InitializeComponent();
            filterComboBox.SelectedIndex = (int) FilterIndex.AllRecords;
        }

        private void VehiclesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainWindow parent = (MainWindow) this.MdiParent;
            e.Cancel = !parent.IsClosingEnabled;
        }

        private void VehiclesView_Activated(object sender, EventArgs e)
        {
            MainWindow parent = (MainWindow) this.MdiParent;
            ToolStripManager.Merge(this.toolBar, parent.toolBar);
            ToolStripManager.Merge(this.statusBar, parent.statusBar);
        }

        private void VehiclesView_Deactivate(object sender, EventArgs e)
        {
            MainWindow parent = (MainWindow)this.MdiParent;
            ToolStripManager.RevertMerge(parent.toolBar, this.toolBar);
            ToolStripManager.RevertMerge(parent.statusBar, this.statusBar);
        }
    }
}
