using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrescriptionItemSln;

namespace PrescriptionSln
{
    public class Prescription
    {
        public void AddPrescriptionItem(string name, int dosage, int duration, 
            int containerSize, bool overCounter, string comments)
        {

        }
        public void RemovePrescriptionItem(string name)
        {

        }
        public void ClearPrescription()
        {

        }
        public PrescriptionItem PrescriptionItems { get; set; }
        public int NumberOfPharmaceuticals { get; private set; }
        public int NumberOfContainers { get; private set; }
    }
}
