using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_and_Doctor_Management_System.Interfaces
{
    internal interface IDoctor
    {
        void AddDoctor();
        void ViewDoctors();
        void UpdateDoctor();
        void DeleteDoctor();
    }
}
