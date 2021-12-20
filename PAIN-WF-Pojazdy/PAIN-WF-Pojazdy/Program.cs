//<a target="_blank" href="https://icons8.com/icon/84991/add">Add</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/60953/add">Add</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/83754/gear">Gear</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/oDHHAAMTJoSY/car-racing">Car Racing</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/99680/table">Table</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/93752/wheel">Wheel</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/25070/motocross">Motocross</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/9341/truck">Truck</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//<a target="_blank" href="https://icons8.com/icon/84852/car">Car</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
//Wszystkie ikony pochodzą ze strony: https://icons8.com/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_WF_Pojazdy
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
//Podpowiedzi:
//ListView.SelectedIndices
//// Adds a new item with ImageIndex 3
//listView1.Items.Add("List item text", 3);
// Removes the first item in the list.
//listView1.Items.RemoveAt(0);
// Clears all the items.
//listView1.Items.Clear();
//ListView.SelectedItems.Count == 2