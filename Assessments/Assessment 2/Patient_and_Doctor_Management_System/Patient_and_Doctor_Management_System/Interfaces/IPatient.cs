using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_and_Doctor_Management_System.Interfaces
{
    internal interface IPatient
    {
        void AddPatient();
        void ViewPatients();
        void UpdatePatient();
        void DeletePatient();
    }
}
