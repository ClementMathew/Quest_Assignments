using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patient_and_Doctor_Management_System.Models.GenderType;

namespace Patient_and_Doctor_Management_System.Models
{
    internal class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string MedicalCondition { get; set; }
    }
}
