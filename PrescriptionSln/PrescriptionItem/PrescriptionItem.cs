using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionItemSln
{
    public class PrescriptionItem
    {
        public PrescriptionItem()
        {

        }
        public string PharmaceuticalName { get; private set; }
        public int PrescribedDailyDose { get; set; }
        public int Duration { get; set; }
        public int ContainerSize { get; private set; }
        public bool AvailableOverTheCounter { get; private set; }
        public string Comments { get; set; }
        public int NumberOfContainers { get; set; }

    }
}
