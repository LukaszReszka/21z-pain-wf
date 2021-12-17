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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();

            VehiclesView view = new VehiclesView();
            view.MdiParent = this;
            view.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void quitProgramOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
