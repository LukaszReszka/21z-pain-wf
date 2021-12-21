using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_WF_Pojazdy
{
    public class Vehicle
    {
        public string Brand
        {
            get; set;
        }

        public ulong maxVelocity
        {
            get; set;
        }

        public DateTime productionDate
        {
            get; set;
        }

        public string Type
        {
            get; set;
        }
    }
}
