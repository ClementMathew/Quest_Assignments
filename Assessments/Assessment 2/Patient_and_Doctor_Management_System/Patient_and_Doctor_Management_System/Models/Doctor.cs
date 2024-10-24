using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_and_Doctor_Management_System.Models.Types;
using static Patient_and_Doctor_Management_System.Models.Types.SpecializationType;

namespace Patient_and_Doctor_Management_System.Models
{
    internal class Doctor
    {
        public string Name { get; set; }
        public Specializations Specialization { get; set; }
        public int PatientId { get; set; }
    }
}
