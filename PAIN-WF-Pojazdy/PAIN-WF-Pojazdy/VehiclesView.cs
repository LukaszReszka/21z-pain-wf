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
    public partial class VehiclesView : Form
    {

        public VehiclesView()
        {
            InitializeComponent();
        }

        private void VehiclesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow parent = (mainWindow) this.MdiParent;
            e.Cancel = !parent.IsClosingEnabled;
        }
    }
}
